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
            txtMoney = new TextBox();
            txtEmblems = new TextBox();
            btnContinue = new Button();
            btnHealContinue = new Button();
            btnRetreat = new Button();
            label3 = new Label();
            txtPotions = new TextBox();
            label4 = new Label();
            txtFireballs = new TextBox();
            label5 = new Label();
            txtRoundNumber = new TextBox();
            txtPlayerHealth = new TextBox();
            label6 = new Label();
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
            // txtMoney
            // 
            txtMoney.Enabled = false;
            txtMoney.Location = new Point(109, 101);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(100, 23);
            txtMoney.TabIndex = 2;
            txtMoney.TabStop = false;
            // 
            // txtEmblems
            // 
            txtEmblems.Enabled = false;
            txtEmblems.Location = new Point(377, 101);
            txtEmblems.Name = "txtEmblems";
            txtEmblems.Size = new Size(100, 23);
            txtEmblems.TabIndex = 3;
            txtEmblems.TabStop = false;
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
            // txtPotions
            // 
            txtPotions.Enabled = false;
            txtPotions.Location = new Point(109, 140);
            txtPotions.Name = "txtPotions";
            txtPotions.Size = new Size(100, 23);
            txtPotions.TabIndex = 5;
            txtPotions.TabStop = false;
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
            // txtFireballs
            // 
            txtFireballs.Enabled = false;
            txtFireballs.Location = new Point(377, 140);
            txtFireballs.Name = "txtFireballs";
            txtFireballs.Size = new Size(100, 23);
            txtFireballs.TabIndex = 7;
            txtFireballs.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 9);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Round #:";
            // 
            // txtRoundNumber
            // 
            txtRoundNumber.Enabled = false;
            txtRoundNumber.Location = new Point(271, 6);
            txtRoundNumber.Name = "txtRoundNumber";
            txtRoundNumber.Size = new Size(100, 23);
            txtRoundNumber.TabIndex = 9;
            txtRoundNumber.TabStop = false;
            // 
            // txtPlayerHealth
            // 
            txtPlayerHealth.Enabled = false;
            txtPlayerHealth.Location = new Point(271, 51);
            txtPlayerHealth.Name = "txtPlayerHealth";
            txtPlayerHealth.Size = new Size(100, 23);
            txtPlayerHealth.TabIndex = 10;
            txtPlayerHealth.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 54);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 11;
            label6.Text = "Player HP:";
            // 
            // PostEncounterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 293);
            Controls.Add(label6);
            Controls.Add(txtPlayerHealth);
            Controls.Add(txtRoundNumber);
            Controls.Add(label5);
            Controls.Add(txtFireballs);
            Controls.Add(label4);
            Controls.Add(txtPotions);
            Controls.Add(label3);
            Controls.Add(btnRetreat);
            Controls.Add(btnHealContinue);
            Controls.Add(btnContinue);
            Controls.Add(txtEmblems);
            Controls.Add(txtMoney);
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
        private TextBox txtMoney;
        private TextBox txtEmblems;
        private Button btnContinue;
        private Button btnHealContinue;
        private Button btnRetreat;
        private Label label3;
        private TextBox txtPotions;
        private Label label4;
        private TextBox txtFireballs;
        private Label label5;
        private TextBox txtRoundNumber;
        private TextBox txtPlayerHealth;
        private Label label6;
    }
}