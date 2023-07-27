namespace DataDrivenDungeon
{
    partial class HubForm
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
            SmithingBtn = new Button();
            RepositoryBtn = new Button();
            JackpotBtn = new Button();
            BankBtn = new Button();
            DungeonBtn = new Button();
            QuitBtn = new Button();
            SuspendLayout();
            // 
            // SmithingBtn
            // 
            SmithingBtn.Location = new Point(97, 130);
            SmithingBtn.Name = "SmithingBtn";
            SmithingBtn.Size = new Size(194, 84);
            SmithingBtn.TabIndex = 0;
            SmithingBtn.Text = "Stanley's Smithing";
            SmithingBtn.UseVisualStyleBackColor = true;
            SmithingBtn.Click += SmithingBtn_Click;
            // 
            // RepositoryBtn
            // 
            RepositoryBtn.Location = new Point(497, 130);
            RepositoryBtn.Name = "RepositoryBtn";
            RepositoryBtn.Size = new Size(194, 84);
            RepositoryBtn.TabIndex = 1;
            RepositoryBtn.Text = "Renaldo's Repository";
            RepositoryBtn.UseVisualStyleBackColor = true;
            RepositoryBtn.Click += RepositoryBtn_Click;
            // 
            // JackpotBtn
            // 
            JackpotBtn.Location = new Point(97, 314);
            JackpotBtn.Name = "JackpotBtn";
            JackpotBtn.Size = new Size(194, 84);
            JackpotBtn.TabIndex = 2;
            JackpotBtn.Text = "Jasper's Jackpot";
            JackpotBtn.UseVisualStyleBackColor = true;
            JackpotBtn.Click += JackpotBtn_Click;
            // 
            // BankBtn
            // 
            BankBtn.Location = new Point(497, 314);
            BankBtn.Name = "BankBtn";
            BankBtn.Size = new Size(194, 84);
            BankBtn.TabIndex = 3;
            BankBtn.Text = "The Bank";
            BankBtn.UseVisualStyleBackColor = true;
            BankBtn.Click += BankBtn_Click;
            // 
            // DungeonBtn
            // 
            DungeonBtn.Location = new Point(297, 130);
            DungeonBtn.Name = "DungeonBtn";
            DungeonBtn.Size = new Size(194, 84);
            DungeonBtn.TabIndex = 4;
            DungeonBtn.Text = "To The Dungeons";
            DungeonBtn.UseVisualStyleBackColor = true;
            DungeonBtn.Click += DungeonBtn_Click;
            // 
            // QuitBtn
            // 
            QuitBtn.Location = new Point(297, 314);
            QuitBtn.Name = "QuitBtn";
            QuitBtn.Size = new Size(194, 84);
            QuitBtn.TabIndex = 5;
            QuitBtn.Text = "Quit Game";
            QuitBtn.UseVisualStyleBackColor = true;
            QuitBtn.Click += QuitBtn_Click;
            // 
            // HubForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(QuitBtn);
            Controls.Add(DungeonBtn);
            Controls.Add(BankBtn);
            Controls.Add(JackpotBtn);
            Controls.Add(RepositoryBtn);
            Controls.Add(SmithingBtn);
            Name = "HubForm";
            Text = "Village Hub";
            ResumeLayout(false);
        }

        #endregion

        private Button SmithingBtn;
        private Button RepositoryBtn;
        private Button JackpotBtn;
        private Button BankBtn;
        private Button DungeonBtn;
        private Button QuitBtn;
    }
}