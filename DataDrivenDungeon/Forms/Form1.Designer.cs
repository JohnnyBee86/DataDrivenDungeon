namespace DataDrivenDungeon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLbl = new Label();
            NewGameBtn = new Button();
            PlayerNameTxt = new TextBox();
            PlayerNameLbl = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            LoadGamebtn = new Button();
            SuspendLayout();
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(83, 20);
            TitleLbl.Margin = new Padding(2, 0, 2, 0);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(156, 15);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "Data Driven Dungeon Delver";
            // 
            // NewGameBtn
            // 
            NewGameBtn.Location = new Point(69, 85);
            NewGameBtn.Margin = new Padding(2);
            NewGameBtn.Name = "NewGameBtn";
            NewGameBtn.Size = new Size(205, 41);
            NewGameBtn.TabIndex = 1;
            NewGameBtn.Text = "New Game";
            NewGameBtn.UseVisualStyleBackColor = true;
            NewGameBtn.Click += NewGameBtn_Click;
            // 
            // PlayerNameTxt
            // 
            PlayerNameTxt.Location = new Point(146, 51);
            PlayerNameTxt.Margin = new Padding(2);
            PlayerNameTxt.MaxLength = 15;
            PlayerNameTxt.Name = "PlayerNameTxt";
            PlayerNameTxt.Size = new Size(145, 23);
            PlayerNameTxt.TabIndex = 2;
            // 
            // PlayerNameLbl
            // 
            PlayerNameLbl.AutoSize = true;
            PlayerNameLbl.Location = new Point(57, 53);
            PlayerNameLbl.Margin = new Padding(2, 0, 2, 0);
            PlayerNameLbl.Name = "PlayerNameLbl";
            PlayerNameLbl.Size = new Size(77, 15);
            PlayerNameLbl.TabIndex = 3;
            PlayerNameLbl.Text = "Player Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 167);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 4;
            label1.Text = "Saved Games";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(83, 197);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 94);
            listBox1.TabIndex = 5;
            // 
            // LoadGamebtn
            // 
            LoadGamebtn.Location = new Point(69, 323);
            LoadGamebtn.Name = "LoadGamebtn";
            LoadGamebtn.Size = new Size(205, 41);
            LoadGamebtn.TabIndex = 6;
            LoadGamebtn.Text = "Load Game";
            LoadGamebtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 444);
            Controls.Add(LoadGamebtn);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(PlayerNameLbl);
            Controls.Add(PlayerNameTxt);
            Controls.Add(NewGameBtn);
            Controls.Add(TitleLbl);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Data Driven Dungeon Delver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLbl;
        private Button NewGameBtn;
        private TextBox PlayerNameTxt;
        private Label PlayerNameLbl;
        private Label label1;
        private ListBox listBox1;
        private Button LoadGamebtn;
    }
}