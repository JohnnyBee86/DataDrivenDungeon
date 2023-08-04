namespace DataDrivenDungeon
{
    partial class BankForm
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
            DepositItemsBtn = new Button();
            WithdrawBtn = new Button();
            DepositMoneyBtn = new Button();
            WithdrawMoneyBtn = new Button();
            HubBtn = new Button();
            DepositItemsCbb = new ComboBox();
            WithdrawItemsCbb = new ComboBox();
            DepositMoneyNud = new NumericUpDown();
            WithdrawMoneyNud = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DepositMoneyNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WithdrawMoneyNud).BeginInit();
            SuspendLayout();
            // 
            // DepositItemsBtn
            // 
            DepositItemsBtn.Location = new Point(198, 92);
            DepositItemsBtn.Name = "DepositItemsBtn";
            DepositItemsBtn.Size = new Size(157, 89);
            DepositItemsBtn.TabIndex = 0;
            DepositItemsBtn.Text = "Deposit items";
            DepositItemsBtn.UseVisualStyleBackColor = true;
            DepositItemsBtn.Click += DepositItemsBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(198, 232);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(157, 89);
            WithdrawBtn.TabIndex = 1;
            WithdrawBtn.Text = "Withdraw Items";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // DepositMoneyBtn
            // 
            DepositMoneyBtn.Location = new Point(445, 93);
            DepositMoneyBtn.Name = "DepositMoneyBtn";
            DepositMoneyBtn.Size = new Size(157, 89);
            DepositMoneyBtn.TabIndex = 2;
            DepositMoneyBtn.Text = "Deposit Money";
            DepositMoneyBtn.UseVisualStyleBackColor = true;
            DepositMoneyBtn.Click += DepositMoneyBtn_Click;
            // 
            // WithdrawMoneyBtn
            // 
            WithdrawMoneyBtn.Location = new Point(445, 233);
            WithdrawMoneyBtn.Name = "WithdrawMoneyBtn";
            WithdrawMoneyBtn.Size = new Size(157, 89);
            WithdrawMoneyBtn.TabIndex = 3;
            WithdrawMoneyBtn.Text = "Withdraw Money";
            WithdrawMoneyBtn.UseVisualStyleBackColor = true;
            WithdrawMoneyBtn.Click += WithdrawMoneyBtn_Click;
            // 
            // HubBtn
            // 
            HubBtn.Location = new Point(342, 351);
            HubBtn.Name = "HubBtn";
            HubBtn.Size = new Size(116, 87);
            HubBtn.TabIndex = 4;
            HubBtn.Text = "Leave";
            HubBtn.UseVisualStyleBackColor = true;
            HubBtn.Click += HubBtn_Click;
            // 
            // DepositItemsCbb
            // 
            DepositItemsCbb.FormattingEnabled = true;
            DepositItemsCbb.Location = new Point(12, 122);
            DepositItemsCbb.Name = "DepositItemsCbb";
            DepositItemsCbb.Size = new Size(180, 33);
            DepositItemsCbb.TabIndex = 5;
            // 
            // WithdrawItemsCbb
            // 
            WithdrawItemsCbb.FormattingEnabled = true;
            WithdrawItemsCbb.Location = new Point(12, 261);
            WithdrawItemsCbb.Name = "WithdrawItemsCbb";
            WithdrawItemsCbb.Size = new Size(180, 33);
            WithdrawItemsCbb.TabIndex = 6;
            // 
            // DepositMoneyNud
            // 
            DepositMoneyNud.Location = new Point(608, 123);
            DepositMoneyNud.Name = "DepositMoneyNud";
            DepositMoneyNud.Size = new Size(180, 31);
            DepositMoneyNud.TabIndex = 9;
            // 
            // WithdrawMoneyNud
            // 
            WithdrawMoneyNud.Location = new Point(608, 264);
            WithdrawMoneyNud.Name = "WithdrawMoneyNud";
            WithdrawMoneyNud.Size = new Size(180, 31);
            WithdrawMoneyNud.TabIndex = 10;
            // 
            // BankForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WithdrawMoneyNud);
            Controls.Add(DepositMoneyNud);
            Controls.Add(WithdrawItemsCbb);
            Controls.Add(DepositItemsCbb);
            Controls.Add(HubBtn);
            Controls.Add(WithdrawMoneyBtn);
            Controls.Add(DepositMoneyBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositItemsBtn);
            Name = "BankForm";
            Text = "BankForm";
            ((System.ComponentModel.ISupportInitialize)DepositMoneyNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)WithdrawMoneyNud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button DepositItemsBtn;
        private Button WithdrawBtn;
        private Button DepositMoneyBtn;
        private Button WithdrawMoneyBtn;
        private Button HubBtn;
        private ComboBox DepositItemsCbb;
        private ComboBox WithdrawItemsCbb;
        private NumericUpDown DepositMoneyNud;
        private NumericUpDown WithdrawMoneyNud;
    }
}