namespace DataDrivenDungeon.Views
{
    partial class DungeonForm
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
            FireballBtn = new Button();
            PotionBtn = new Button();
            RetreatBtn = new Button();
            AttackBtn = new Button();
            Monster1Rdb = new RadioButton();
            MonsterGrb = new GroupBox();
            Monster3Rdb = new RadioButton();
            Monster2Rdb = new RadioButton();
            MonsterGrb.SuspendLayout();
            SuspendLayout();
            // 
            // FireballBtn
            // 
            FireballBtn.Location = new Point(494, 232);
            FireballBtn.Name = "FireballBtn";
            FireballBtn.Size = new Size(171, 75);
            FireballBtn.TabIndex = 1;
            FireballBtn.Text = "Fireball";
            FireballBtn.UseVisualStyleBackColor = true;
            FireballBtn.Click += FireballBtn_Click;
            // 
            // PotionBtn
            // 
            PotionBtn.Location = new Point(131, 332);
            PotionBtn.Name = "PotionBtn";
            PotionBtn.Size = new Size(171, 75);
            PotionBtn.TabIndex = 2;
            PotionBtn.Text = "Potion";
            PotionBtn.UseVisualStyleBackColor = true;
            PotionBtn.Click += PotionBtn_Click;
            // 
            // RetreatBtn
            // 
            RetreatBtn.Location = new Point(494, 332);
            RetreatBtn.Name = "RetreatBtn";
            RetreatBtn.Size = new Size(171, 75);
            RetreatBtn.TabIndex = 3;
            RetreatBtn.Text = "Retreat";
            RetreatBtn.UseVisualStyleBackColor = true;
            RetreatBtn.Click += RetreatBtn_Click;
            // 
            // AttackBtn
            // 
            AttackBtn.Location = new Point(131, 232);
            AttackBtn.Name = "AttackBtn";
            AttackBtn.Size = new Size(171, 75);
            AttackBtn.TabIndex = 0;
            AttackBtn.Text = "Attack";
            AttackBtn.UseVisualStyleBackColor = true;
            AttackBtn.Click += AttackBtn_Click;
            // 
            // Monster1Rdb
            // 
            Monster1Rdb.AutoSize = true;
            Monster1Rdb.Location = new Point(110, 62);
            Monster1Rdb.Name = "Monster1Rdb";
            Monster1Rdb.Size = new Size(180, 29);
            Monster1Rdb.TabIndex = 4;
            Monster1Rdb.TabStop = true;
            Monster1Rdb.Text = "[Monster 1 Name]";
            Monster1Rdb.UseVisualStyleBackColor = true;
            // 
            // MonsterGrb
            // 
            MonsterGrb.Controls.Add(Monster3Rdb);
            MonsterGrb.Controls.Add(Monster2Rdb);
            MonsterGrb.Controls.Add(Monster1Rdb);
            MonsterGrb.Location = new Point(12, 53);
            MonsterGrb.Name = "MonsterGrb";
            MonsterGrb.Size = new Size(776, 128);
            MonsterGrb.TabIndex = 5;
            MonsterGrb.TabStop = false;
            MonsterGrb.Text = "Monsters";
            // 
            // Monster3Rdb
            // 
            Monster3Rdb.AutoSize = true;
            Monster3Rdb.Location = new Point(480, 62);
            Monster3Rdb.Name = "Monster3Rdb";
            Monster3Rdb.Size = new Size(180, 29);
            Monster3Rdb.TabIndex = 6;
            Monster3Rdb.TabStop = true;
            Monster3Rdb.Text = "[Monster 3 Name]";
            Monster3Rdb.UseVisualStyleBackColor = true;
            // 
            // Monster2Rdb
            // 
            Monster2Rdb.AutoSize = true;
            Monster2Rdb.Location = new Point(296, 62);
            Monster2Rdb.Name = "Monster2Rdb";
            Monster2Rdb.Size = new Size(180, 29);
            Monster2Rdb.TabIndex = 5;
            Monster2Rdb.TabStop = true;
            Monster2Rdb.Text = "[Monster 2 Name]";
            Monster2Rdb.UseVisualStyleBackColor = true;
            // 
            // DungeonForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MonsterGrb);
            Controls.Add(RetreatBtn);
            Controls.Add(FireballBtn);
            Controls.Add(AttackBtn);
            Controls.Add(PotionBtn);
            Name = "DungeonForm";
            Text = "Dungeon [Current Dungeon Level]";
            MonsterGrb.ResumeLayout(false);
            MonsterGrb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button FireballBtn;
        private Button PotionBtn;
        private Button RetreatBtn;
        private Button AttackBtn;
        private RadioButton Monster1Rdb;
        private GroupBox MonsterGrb;
        private RadioButton Monster3Rdb;
        private RadioButton Monster2Rdb;
    }
}