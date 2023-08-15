namespace DataDrivenDungeon.Forms
{
    partial class PostEncounterForm
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
            label1 = new Label();
            label2 = new Label();
            txtboxMoney = new TextBox();
            txtboxEmblems = new TextBox();
            btnContinue = new Button();
            btnHealContinue = new Button();
            btnRetreat = new Button();
            label3 = new Label();
            txtboxPotions = new TextBox();
            label4 = new Label();
            txtboxFireballs = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 104);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Money:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 104);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Emblems:";
            // 
            // txtboxMoney
            // 
            txtboxMoney.Enabled = false;
            txtboxMoney.Location = new Point(109, 101);
            txtboxMoney.Name = "txtboxMoney";
            txtboxMoney.Size = new Size(100, 23);
            txtboxMoney.TabIndex = 2;
            txtboxMoney.TabStop = false;
            // 
            // txtboxEmblems
            // 
            txtboxEmblems.Enabled = false;
            txtboxEmblems.Location = new Point(377, 101);
            txtboxEmblems.Name = "txtboxEmblems";
            txtboxEmblems.Size = new Size(100, 23);
            txtboxEmblems.TabIndex = 3;
            txtboxEmblems.TabStop = false;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(41, 192);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(162, 54);
            btnContinue.TabIndex = 0;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            // 
            // btnHealContinue
            // 
            btnHealContinue.Location = new Point(209, 192);
            btnHealContinue.Name = "btnHealContinue";
            btnHealContinue.Size = new Size(162, 54);
            btnHealContinue.TabIndex = 1;
            btnHealContinue.Text = "Heal and Continue";
            btnHealContinue.UseVisualStyleBackColor = true;
            // 
            // btnRetreat
            // 
            btnRetreat.Location = new Point(377, 192);
            btnRetreat.Name = "btnRetreat";
            btnRetreat.Size = new Size(162, 54);
            btnRetreat.TabIndex = 2;
            btnRetreat.Text = "Retreat With Current Items";
            btnRetreat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 143);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Potions:";
            // 
            // txtboxPotions
            // 
            txtboxPotions.Enabled = false;
            txtboxPotions.Location = new Point(109, 140);
            txtboxPotions.Name = "txtboxPotions";
            txtboxPotions.Size = new Size(100, 23);
            txtboxPotions.TabIndex = 5;
            txtboxPotions.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 143);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "Fireballs:";
            // 
            // txtboxFireballs
            // 
            txtboxFireballs.Enabled = false;
            txtboxFireballs.Location = new Point(377, 140);
            txtboxFireballs.Name = "txtboxFireballs";
            txtboxFireballs.Size = new Size(100, 23);
            txtboxFireballs.TabIndex = 7;
            txtboxFireballs.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 39);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Round #:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(271, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.TabStop = false;
            // 
            // PostEncounterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 293);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(txtboxFireballs);
            Controls.Add(label4);
            Controls.Add(txtboxPotions);
            Controls.Add(label3);
            Controls.Add(btnRetreat);
            Controls.Add(btnHealContinue);
            Controls.Add(btnContinue);
            Controls.Add(txtboxEmblems);
            Controls.Add(txtboxMoney);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PostEncounterForm";
            Text = "Enounter Complete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtboxMoney;
        private TextBox txtboxEmblems;
        private Button btnContinue;
        private Button btnHealContinue;
        private Button btnRetreat;
        private Label label3;
        private TextBox txtboxPotions;
        private Label label4;
        private TextBox txtboxFireballs;
        private Label label5;
        private TextBox textBox1;
    }
}