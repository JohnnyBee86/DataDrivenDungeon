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
            txtboxWeapon = new TextBox();
            txtboxPotionCnt = new TextBox();
            txtboxFireballCnt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            MonsterGrb.SuspendLayout();
            SuspendLayout();
            // 
            // FireballBtn
            // 
            FireballBtn.Location = new Point(8, 199);
            FireballBtn.Margin = new Padding(2);
            FireballBtn.Name = "FireballBtn";
            FireballBtn.Size = new Size(120, 45);
            FireballBtn.TabIndex = 1;
            FireballBtn.Text = "Fireball";
            FireballBtn.UseVisualStyleBackColor = true;
            FireballBtn.Click += FireballBtn_Click;
            // 
            // PotionBtn
            // 
            PotionBtn.Location = new Point(8, 261);
            PotionBtn.Margin = new Padding(2);
            PotionBtn.Name = "PotionBtn";
            PotionBtn.Size = new Size(120, 45);
            PotionBtn.TabIndex = 2;
            PotionBtn.Text = "Potion";
            PotionBtn.UseVisualStyleBackColor = true;
            PotionBtn.Click += PotionBtn_Click;
            // 
            // RetreatBtn
            // 
            RetreatBtn.Location = new Point(431, 139);
            RetreatBtn.Margin = new Padding(2);
            RetreatBtn.Name = "RetreatBtn";
            RetreatBtn.Size = new Size(120, 45);
            RetreatBtn.TabIndex = 3;
            RetreatBtn.Text = "Retreat";
            RetreatBtn.UseVisualStyleBackColor = true;
            RetreatBtn.Click += RetreatBtn_Click;
            // 
            // AttackBtn
            // 
            AttackBtn.Location = new Point(8, 139);
            AttackBtn.Margin = new Padding(2);
            AttackBtn.Name = "AttackBtn";
            AttackBtn.Size = new Size(120, 45);
            AttackBtn.TabIndex = 0;
            AttackBtn.Text = "Attack";
            AttackBtn.UseVisualStyleBackColor = true;
            AttackBtn.Click += AttackBtn_Click;
            // 
            // Monster1Rdb
            // 
            Monster1Rdb.AutoSize = true;
            Monster1Rdb.Location = new Point(77, 37);
            Monster1Rdb.Margin = new Padding(2);
            Monster1Rdb.Name = "Monster1Rdb";
            Monster1Rdb.Size = new Size(121, 19);
            Monster1Rdb.TabIndex = 4;
            Monster1Rdb.Text = "[Monster 1 Name]";
            Monster1Rdb.UseVisualStyleBackColor = true;
            // 
            // MonsterGrb
            // 
            MonsterGrb.Controls.Add(Monster3Rdb);
            MonsterGrb.Controls.Add(Monster2Rdb);
            MonsterGrb.Controls.Add(Monster1Rdb);
            MonsterGrb.Location = new Point(8, 32);
            MonsterGrb.Margin = new Padding(2);
            MonsterGrb.Name = "MonsterGrb";
            MonsterGrb.Padding = new Padding(2);
            MonsterGrb.Size = new Size(543, 77);
            MonsterGrb.TabIndex = 5;
            MonsterGrb.TabStop = false;
            MonsterGrb.Text = "Monsters";
            // 
            // Monster3Rdb
            // 
            Monster3Rdb.AutoSize = true;
            Monster3Rdb.Location = new Point(336, 37);
            Monster3Rdb.Margin = new Padding(2);
            Monster3Rdb.Name = "Monster3Rdb";
            Monster3Rdb.Size = new Size(121, 19);
            Monster3Rdb.TabIndex = 6;
            Monster3Rdb.Text = "[Monster 3 Name]";
            Monster3Rdb.UseVisualStyleBackColor = true;
            // 
            // Monster2Rdb
            // 
            Monster2Rdb.AutoSize = true;
            Monster2Rdb.Location = new Point(207, 37);
            Monster2Rdb.Margin = new Padding(2);
            Monster2Rdb.Name = "Monster2Rdb";
            Monster2Rdb.Size = new Size(121, 19);
            Monster2Rdb.TabIndex = 5;
            Monster2Rdb.Text = "[Monster 2 Name]";
            Monster2Rdb.UseVisualStyleBackColor = true;
            // 
            // txtboxWeapon
            // 
            txtboxWeapon.Enabled = false;
            txtboxWeapon.Location = new Point(215, 151);
            txtboxWeapon.Name = "txtboxWeapon";
            txtboxWeapon.Size = new Size(121, 23);
            txtboxWeapon.TabIndex = 6;
            txtboxWeapon.TabStop = false;
            // 
            // txtboxPotionCnt
            // 
            txtboxPotionCnt.Enabled = false;
            txtboxPotionCnt.Location = new Point(215, 273);
            txtboxPotionCnt.Name = "txtboxPotionCnt";
            txtboxPotionCnt.Size = new Size(62, 23);
            txtboxPotionCnt.TabIndex = 7;
            txtboxPotionCnt.TabStop = false;
            // 
            // txtboxFireballCnt
            // 
            txtboxFireballCnt.Enabled = false;
            txtboxFireballCnt.Location = new Point(215, 211);
            txtboxFireballCnt.Name = "txtboxFireballCnt";
            txtboxFireballCnt.Size = new Size(62, 23);
            txtboxFireballCnt.TabIndex = 8;
            txtboxFireballCnt.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 276);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 9;
            label1.Text = "Player HP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 154);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Weapon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 214);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 11;
            label3.Text = "Count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 276);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Count:";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(411, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 23);
            textBox4.TabIndex = 13;
            textBox4.TabStop = false;
            // 
            // DungeonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 332);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxFireballCnt);
            Controls.Add(txtboxPotionCnt);
            Controls.Add(txtboxWeapon);
            Controls.Add(MonsterGrb);
            Controls.Add(RetreatBtn);
            Controls.Add(FireballBtn);
            Controls.Add(AttackBtn);
            Controls.Add(PotionBtn);
            Margin = new Padding(2);
            Name = "DungeonForm";
            Text = "Dungeon [Current Dungeon Level]";
            MonsterGrb.ResumeLayout(false);
            MonsterGrb.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtboxWeapon;
        private TextBox txtboxPotionCnt;
        private TextBox txtboxFireballCnt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
    }
}