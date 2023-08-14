namespace DataDrivenDungeon
{
    partial class SmithingStoreForm
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
            BuySwordBtn = new Button();
            BuyArmorBtn = new Button();
            HubBtn = new Button();
            SuspendLayout();
            // 
            // BuySwordBtn
            // 
            BuySwordBtn.Location = new Point(54, 216);
            BuySwordBtn.Name = "BuySwordBtn";
            BuySwordBtn.Size = new Size(227, 78);
            BuySwordBtn.TabIndex = 0;
            BuySwordBtn.Text = "Buy {nextSword}";
            BuySwordBtn.UseVisualStyleBackColor = true;
            BuySwordBtn.Click += BuySwordBtn_Click;
            // 
            // BuyArmorBtn
            // 
            BuyArmorBtn.Location = new Point(520, 216);
            BuyArmorBtn.Name = "BuyArmorBtn";
            BuyArmorBtn.Size = new Size(227, 78);
            BuyArmorBtn.TabIndex = 1;
            BuyArmorBtn.Text = "Buy {nextArmor}";
            BuyArmorBtn.UseVisualStyleBackColor = true;
            BuyArmorBtn.Click += BuyArmorBtn_Click;
            // 
            // HubBtn
            // 
            HubBtn.Location = new Point(287, 309);
            HubBtn.Name = "HubBtn";
            HubBtn.Size = new Size(227, 78);
            HubBtn.TabIndex = 2;
            HubBtn.Text = "Leave Store";
            HubBtn.UseVisualStyleBackColor = true;
            HubBtn.Click += HubBtn_Click;
            // 
            // SmithingStoreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HubBtn);
            Controls.Add(BuyArmorBtn);
            Controls.Add(BuySwordBtn);
            Name = "SmithingStoreForm";
            Text = "Stanley's Smithing";
            Load += SmithingStoreForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BuySwordBtn;
        private Button BuyArmorBtn;
        private Button HubBtn;
    }
}