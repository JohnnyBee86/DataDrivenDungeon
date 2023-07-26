namespace DataDrivenDungeon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLbl = new Label();
            StartGameBtn = new Button();
            SuspendLayout();
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(21, 34);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(239, 25);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "Data Driven Dungeon Delver";
            // 
            // StartGameBtn
            // 
            StartGameBtn.Location = new Point(21, 100);
            StartGameBtn.Name = "StartGameBtn";
            StartGameBtn.Size = new Size(239, 68);
            StartGameBtn.TabIndex = 1;
            StartGameBtn.Text = "Start Game";
            StartGameBtn.UseVisualStyleBackColor = true;
            StartGameBtn.Click += StartGameBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 205);
            Controls.Add(StartGameBtn);
            Controls.Add(TitleLbl);
            Name = "Form1";
            Text = "DDDD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLbl;
        private Button StartGameBtn;
    }
}