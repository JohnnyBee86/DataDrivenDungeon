namespace DataDrivenDungeon
{
    partial class RepositoryStoreForm
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
            PotionBtn = new Button();
            FireBallBtn = new Button();
            SellBtn = new Button();
            HubBtn = new Button();
            SuspendLayout();
            // 
            // PotionBtn
            // 
            PotionBtn.Location = new Point(76, 171);
            PotionBtn.Name = "PotionBtn";
            PotionBtn.Size = new Size(210, 106);
            PotionBtn.TabIndex = 0;
            PotionBtn.Text = "Buy Health Potion";
            PotionBtn.UseVisualStyleBackColor = true;
            PotionBtn.Click += PotionBtn_Click;
            // 
            // FireBallBtn
            // 
            FireBallBtn.Location = new Point(498, 171);
            FireBallBtn.Name = "FireBallBtn";
            FireBallBtn.Size = new Size(210, 106);
            FireBallBtn.TabIndex = 1;
            FireBallBtn.Text = "Buy Fireball";
            FireBallBtn.UseVisualStyleBackColor = true;
            FireBallBtn.Click += FireBallBtn_Click;
            // 
            // SellBtn
            // 
            SellBtn.Location = new Point(76, 355);
            SellBtn.Name = "SellBtn";
            SellBtn.Size = new Size(210, 56);
            SellBtn.TabIndex = 2;
            SellBtn.Text = "Sell Loot";
            SellBtn.UseVisualStyleBackColor = true;
            SellBtn.Click += SellBtn_Click;
            // 
            // HubBtn
            // 
            HubBtn.Location = new Point(498, 318);
            HubBtn.Name = "HubBtn";
            HubBtn.Size = new Size(210, 106);
            HubBtn.TabIndex = 3;
            HubBtn.Text = "Leave the Repository";
            HubBtn.UseVisualStyleBackColor = true;
            HubBtn.Click += HubBtn_Click;
            // 
            // RepositoryStoreForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(HubBtn);
            Controls.Add(SellBtn);
            Controls.Add(FireBallBtn);
            Controls.Add(PotionBtn);
            Name = "RepositoryStoreForm";
            Text = "Renaldo's Repository";
            ResumeLayout(false);
        }

        #endregion

        private Button PotionBtn;
        private Button FireBallBtn;
        private Button SellBtn;
        private Button HubBtn;
    }
}