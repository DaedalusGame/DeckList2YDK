namespace Decklist2YDK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_convert = new System.Windows.Forms.Button();
            this.txt_mainlist = new System.Windows.Forms.TextBox();
            this.txt_ydk = new System.Windows.Forms.TextBox();
            this.txt_extralist = new System.Windows.Forms.TextBox();
            this.txt_sidelist = new System.Windows.Forms.TextBox();
            this.lst_cards = new System.Windows.Forms.ListBox();
            this.lst_notfound = new System.Windows.Forms.ListBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(281, 12);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(186, 23);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // txt_mainlist
            // 
            this.txt_mainlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mainlist.Location = new System.Drawing.Point(12, 12);
            this.txt_mainlist.Multiline = true;
            this.txt_mainlist.Name = "txt_mainlist";
            this.txt_mainlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mainlist.Size = new System.Drawing.Size(243, 143);
            this.txt_mainlist.TabIndex = 1;
            // 
            // txt_ydk
            // 
            this.txt_ydk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ydk.Location = new System.Drawing.Point(491, 71);
            this.txt_ydk.Multiline = true;
            this.txt_ydk.Name = "txt_ydk";
            this.txt_ydk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ydk.Size = new System.Drawing.Size(228, 367);
            this.txt_ydk.TabIndex = 4;
            // 
            // txt_extralist
            // 
            this.txt_extralist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_extralist.Location = new System.Drawing.Point(12, 161);
            this.txt_extralist.Multiline = true;
            this.txt_extralist.Name = "txt_extralist";
            this.txt_extralist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_extralist.Size = new System.Drawing.Size(243, 143);
            this.txt_extralist.TabIndex = 2;
            // 
            // txt_sidelist
            // 
            this.txt_sidelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sidelist.Location = new System.Drawing.Point(12, 310);
            this.txt_sidelist.Multiline = true;
            this.txt_sidelist.Name = "txt_sidelist";
            this.txt_sidelist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_sidelist.Size = new System.Drawing.Size(243, 128);
            this.txt_sidelist.TabIndex = 3;
            // 
            // lst_cards
            // 
            this.lst_cards.FormattingEnabled = true;
            this.lst_cards.Location = new System.Drawing.Point(281, 161);
            this.lst_cards.Name = "lst_cards";
            this.lst_cards.Size = new System.Drawing.Size(186, 277);
            this.lst_cards.TabIndex = 5;
            // 
            // lst_notfound
            // 
            this.lst_notfound.FormattingEnabled = true;
            this.lst_notfound.Location = new System.Drawing.Point(281, 47);
            this.lst_notfound.Name = "lst_notfound";
            this.lst_notfound.Size = new System.Drawing.Size(186, 108);
            this.lst_notfound.TabIndex = 6;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(491, 13);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(228, 23);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load .ydk";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(491, 42);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(228, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save .ydk";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tooltip
            // 
            this.tooltip.AutoPopDelay = 5000;
            this.tooltip.InitialDelay = 500;
            this.tooltip.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.lst_notfound);
            this.Controls.Add(this.lst_cards);
            this.Controls.Add(this.txt_sidelist);
            this.Controls.Add(this.txt_extralist);
            this.Controls.Add(this.txt_ydk);
            this.Controls.Add(this.txt_mainlist);
            this.Controls.Add(this.btn_convert);
            this.Name = "Form1";
            this.Text = "Decklist to YDK Converter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.TextBox txt_mainlist;
        private System.Windows.Forms.TextBox txt_ydk;
        private System.Windows.Forms.TextBox txt_extralist;
        private System.Windows.Forms.TextBox txt_sidelist;
        private System.Windows.Forms.ListBox lst_cards;
        private System.Windows.Forms.ListBox lst_notfound;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ToolTip tooltip;
    }
}

