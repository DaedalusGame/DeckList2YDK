using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decklist2YDK
{
    public partial class Form1 : Form
    {
        Regex CardRegex = new Regex(@"(\d+)([ ]+?|[xX*])\s(.+)");
        SQLiteConnection Connection;
        MultiValueDictionary<String, int> CardDatabase = new MultiValueDictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            dialog.ShowDialog();
            DirectoryInfo directory = new DirectoryInfo(dialog.FileName);
            
            foreach (var file in directory.EnumerateFiles("*.cdb", SearchOption.AllDirectories))
            {
                Connection = new SQLiteConnection($"Data Source = {file.FullName}");
                Connection.Open();

                using (var cmd = Connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT id,name FROM texts";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            String name = reader.GetString(1);
                            CardDatabase.Add(name, id);
                        }
                    }
                }

                Connection.Close();
                Connection.Dispose();
            }


            var list = CardDatabase.Keys.ToList();
            list.Sort();
            list.ForEach(x => lst_cards.Items.Add(x));

            BringToFront();

            tooltip.SetToolTip(txt_mainlist, "Main Deck");
            tooltip.SetToolTip(txt_extralist, "Extra Deck");
            tooltip.SetToolTip(txt_sidelist, "Side Deck");
            tooltip.SetToolTip(txt_ydk, ".ydk format");
            tooltip.SetToolTip(lst_notfound, "Invalid Cards");
            tooltip.SetToolTip(lst_cards, "List of All Cards");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            lst_notfound.Items.Clear();
            var maindeck = ReadCardList(txt_mainlist.Text);
            var extradeck = ReadCardList(txt_extralist.Text);
            var sidedeck = ReadCardList(txt_sidelist.Text);

            StringBuilder output = new StringBuilder();
            output.AppendLine("#created by ...");
            output.AppendLine("#main");
            foreach (var cardname in maindeck)
                output.AppendLine(CardDatabase[cardname].First().ToString());
            output.AppendLine("#extra");
            foreach (var cardname in extradeck)
                output.AppendLine(CardDatabase[cardname].First().ToString());
            output.AppendLine("!side");
            foreach (var cardname in sidedeck)
                output.AppendLine(CardDatabase[cardname].First().ToString());

            txt_ydk.Text = output.ToString();
        }

        private List<string> ReadCardList(string text)
        {
            List<string> cards = new List<string>();
            foreach (string line in Regex.Split(text, "\r\n|\r|\n"))
            {
                var match = CardRegex.Match(line);
                if (match.Success)
                {
                    int amt = int.Parse(match.Groups[1].Value);
                    string name = match.Groups[3].Value;
                    if (CardDatabase.ContainsKey(name))
                        for (int i = 0; i < amt; i++)
                        {

                            cards.Add(name);

                        }
                    else
                        lst_notfound.Items.Add(name);
                }
            }
            return cards;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "YGOPro Deck Files (*.ydk)|*.ydk";
            dialog.AddExtension = true;
            dialog.OverwritePrompt = true;
            dialog.ShowDialog();
            File.WriteAllText(dialog.FileName, txt_ydk.Text);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "YGOPro Deck Files (*.ydk)|*.ydk";
            dialog.ShowDialog();
            txt_ydk.Text = File.ReadAllText(dialog.FileName);
        }
    }
}
