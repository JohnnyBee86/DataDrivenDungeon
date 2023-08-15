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
            btnFireball = new Button();
            btnPotion = new Button();
            btnRetreat = new Button();
            btnAttack = new Button();
            rdbMonster1 = new RadioButton();
            grbMonster = new GroupBox();
            rdbMonster3 = new RadioButton();
            rdbMonster2 = new RadioButton();
            txtWeapon = new TextBox();
            txtPotionCnt = new TextBox();
            txtFireballCnt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPlayerHealth = new TextBox();
            label5 = new Label();
            txtMoney = new TextBox();
            grbMonster.SuspendLayout();
            SuspendLayout();
            // 
            // btnFireball
            // 
            btnFireball.Location = new Point(8, 199);
            btnFireball.Margin = new Padding(2);
            btnFireball.Name = "btnFireball";
            btnFireball.Size = new Size(120, 45);
            btnFireball.TabIndex = 1;
            btnFireball.Text = "Fireball";
            btnFireball.UseVisualStyleBackColor = true;
            btnFireball.Click += FireballBtn_Click;
            // 
            // btnPotion
            // 
            btnPotion.Location = new Point(8, 261);
            btnPotion.Margin = new Padding(2);
            btnPotion.Name = "btnPotion";
            btnPotion.Size = new Size(120, 45);
            btnPotion.TabIndex = 2;
            btnPotion.Text = "Potion";
            btnPotion.UseVisualStyleBackColor = true;
            btnPotion.Click += PotionBtn_Click;
            // 
            // btnRetreat
            // 
            btnRetreat.Location = new Point(431, 139);
            btnRetreat.Margin = new Padding(2);
            btnRetreat.Name = "btnRetreat";
            btnRetreat.Size = new Size(120, 45);
            btnRetreat.TabIndex = 3;
            btnRetreat.Text = "Retreat";
            btnRetreat.UseVisualStyleBackColor = true;
            btnRetreat.Click += RetreatBtn_Click;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(8, 139);
            btnAttack.Margin = new Padding(2);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(120, 45);
            btnAttack.TabIndex = 0;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += AttackBtn_Click;
            // 
            // rdbMonster1
            // 
            rdbMonster1.AutoSize = true;
            rdbMonster1.Location = new Point(77, 37);
            rdbMonster1.Margin = new Padding(2);
            rdbMonster1.Name = "rdbMonster1";
            rdbMonster1.Size = new Size(121, 19);
            rdbMonster1.TabIndex = 4;
            rdbMonster1.Text = "[Monster 1 Name]";
            rdbMonster1.UseVisualStyleBackColor = true;
            // 
            // grbMonster
            // 
            grbMonster.Controls.Add(rdbMonster3);
            grbMonster.Controls.Add(rdbMonster2);
            grbMonster.Controls.Add(rdbMonster1);
            grbMonster.Location = new Point(8, 32);
            grbMonster.Margin = new Padding(2);
            grbMonster.Name = "grbMonster";
            grbMonster.Padding = new Padding(2);
            grbMonster.Size = new Size(543, 77);
            grbMonster.TabIndex = 5;
            grbMonster.TabStop = false;
            grbMonster.Text = "Monsters";
            // 
            // rdbMonster3
            // 
            rdbMonster3.AutoSize = true;
            rdbMonster3.Location = new Point(336, 37);
            rdbMonster3.Margin = new Padding(2);
            rdbMonster3.Name = "rdbMonster3";
            rdbMonster3.Size = new Size(121, 19);
            rdbMonster3.TabIndex = 6;
            rdbMonster3.Text = "[Monster 3 Name]";
            rdbMonster3.UseVisualStyleBackColor = true;
            // 
            // rdbMonster2
            // 
            rdbMonster2.AutoSize = true;
            rdbMonster2.Location = new Point(207, 37);
            rdbMonster2.Margin = new Padding(2);
            rdbMonster2.Name = "rdbMonster2";
            rdbMonster2.Size = new Size(121, 19);
            rdbMonster2.TabIndex = 5;
            rdbMonster2.Text = "[Monster 2 Name]";
            rdbMonster2.UseVisualStyleBackColor = true;
            // 
            // txtWeapon
            // 
            txtWeapon.Enabled = false;
            txtWeapon.Location = new Point(215, 151);
            txtWeapon.Name = "txtWeapon";
            txtWeapon.Size = new Size(121, 23);
            txtWeapon.TabIndex = 6;
            txtWeapon.TabStop = false;
            // 
            // txtPotionCnt
            // 
            txtPotionCnt.Enabled = false;
            txtPotionCnt.Location = new Point(215, 273);
            txtPotionCnt.Name = "txtPotionCnt";
            txtPotionCnt.Size = new Size(62, 23);
            txtPotionCnt.TabIndex = 7;
            txtPotionCnt.TabStop = false;
            // 
            // txtFireballCnt
            // 
            txtFireballCnt.Enabled = false;
            txtFireballCnt.Location = new Point(215, 211);
            txtFireballCnt.Name = "txtFireballCnt";
            txtFireballCnt.Size = new Size(62, 23);
            txtFireballCnt.TabIndex = 8;
            txtFireballCnt.TabStop = false;
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
            // txtPlayerHealth
            // 
            txtPlayerHealth.Enabled = false;
            txtPlayerHealth.Location = new Point(411, 273);
            txtPlayerHealth.Name = "txtPlayerHealth";
            txtPlayerHealth.Size = new Size(100, 23);
            txtPlayerHealth.TabIndex = 13;
            txtPlayerHealth.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 214);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 14;
            label5.Text = "Money:";
            // 
            // txtMoney
            // 
            txtMoney.Enabled = false;
            txtMoney.Location = new Point(411, 211);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(100, 23);
            txtMoney.TabIndex = 15;
            txtMoney.TabStop = false;
            // 
            // DungeonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 332);
            Controls.Add(txtMoney);
            Controls.Add(label5);
            Controls.Add(txtPlayerHealth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFireballCnt);
            Controls.Add(txtPotionCnt);
            Controls.Add(txtWeapon);
            Controls.Add(grbMonster);
            Controls.Add(btnRetreat);
            Controls.Add(btnFireball);
            Controls.Add(btnAttack);
            Controls.Add(btnPotion);
            Margin = new Padding(2);
            Name = "DungeonForm";
            Text = "Dungeon [Current Dungeon Level]";
            grbMonster.ResumeLayout(false);
            grbMonster.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFireball;
        private Button btnPotion;
        private Button btnRetreat;
        private Button btnAttack;
        private RadioButton rdbMonster1;
        private GroupBox grbMonster;
        private RadioButton rdbMonster3;
        private RadioButton rdbMonster2;
        private TextBox txtWeapon;
        private TextBox txtPotionCnt;
        private TextBox txtFireballCnt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPlayerHealth;
        private Label label5;
        private TextBox txtMoney;
    }
}