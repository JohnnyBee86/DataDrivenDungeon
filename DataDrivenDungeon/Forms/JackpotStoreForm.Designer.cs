namespace DataDrivenDungeon
{
    partial class JackpotStoreForm
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
            RiskBtn = new Button();
            HubBtn = new Button();
            SuspendLayout();
            // 
            // RiskBtn
            // 
            RiskBtn.Location = new Point(62, 307);
            RiskBtn.Name = "RiskBtn";
            RiskBtn.Size = new Size(262, 108);
            RiskBtn.TabIndex = 0;
            RiskBtn.Text = "Take a Risk (Goblin Emblem)";
            RiskBtn.UseVisualStyleBackColor = true;
            RiskBtn.Click += RiskBtn_Click;
            // 
            // HubBtn
            // 
            HubBtn.Location = new Point(474, 307);
            HubBtn.Name = "HubBtn";
            HubBtn.Size = new Size(262, 108);
            HubBtn.TabIndex = 1;
            HubBtn.Text = "Leave Shop";
            HubBtn.UseVisualStyleBackColor = true;
            HubBtn.Click += HubBtn_Click;
            // 
            // JackpotStoreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HubBtn);
            Controls.Add(RiskBtn);
            Name = "JackpotStoreForm";
            Text = "Jasper's Jackpot";
            ResumeLayout(false);
        }

        #endregion

        private Button RiskBtn;
        private Button HubBtn;
    }
}