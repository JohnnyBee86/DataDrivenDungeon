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
            StartGameBtn = new Button();
            PlayerNameTxt = new TextBox();
            PlayerNameLbl = new Label();
            SuspendLayout();
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(119, 34);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(239, 25);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "Data Driven Dungeon Delver";
            // 
            // StartGameBtn
            // 
            StartGameBtn.Location = new Point(99, 142);
            StartGameBtn.Name = "StartGameBtn";
            StartGameBtn.Size = new Size(293, 68);
            StartGameBtn.TabIndex = 1;
            StartGameBtn.Text = "Start Game";
            StartGameBtn.UseVisualStyleBackColor = true;
            StartGameBtn.Click += StartGameBtn_Click;
            // 
            // PlayerNameTxt
            // 
            PlayerNameTxt.Location = new Point(227, 85);
            PlayerNameTxt.Name = "PlayerNameTxt";
            PlayerNameTxt.Size = new Size(165, 31);
            PlayerNameTxt.TabIndex = 2;
            // 
            // PlayerNameLbl
            // 
            PlayerNameLbl.AutoSize = true;
            PlayerNameLbl.Location = new Point(99, 88);
            PlayerNameLbl.Name = "PlayerNameLbl";
            PlayerNameLbl.Size = new Size(115, 25);
            PlayerNameLbl.TabIndex = 3;
            PlayerNameLbl.Text = "Player Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 244);
            Controls.Add(PlayerNameLbl);
            Controls.Add(PlayerNameTxt);
            Controls.Add(StartGameBtn);
            Controls.Add(TitleLbl);
            Name = "Form1";
            Text = "Data Driven Dungeon Delver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLbl;
        private Button StartGameBtn;
        private TextBox PlayerNameTxt;
        private Label PlayerNameLbl;
    }
}