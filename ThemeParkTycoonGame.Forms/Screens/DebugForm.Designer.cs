namespace ThemeParkTycoonGame.Forms.Screens
{
    partial class DebugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugForm));
            this.addGuestButton = new System.Windows.Forms.Button();
            this.editGuestButton = new System.Windows.Forms.Button();
            this.generateMoreMoneyButton = new System.Windows.Forms.Button();
            this.generateMoneyButton = new System.Windows.Forms.Button();
            this.changeWeatherButton = new System.Windows.Forms.Button();
            this.moreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addGuestButton
            // 
            this.addGuestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addGuestButton.Location = new System.Drawing.Point(0, 0);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(354, 29);
            this.addGuestButton.TabIndex = 0;
            this.addGuestButton.Text = "Add New Guest";
            this.addGuestButton.UseVisualStyleBackColor = true;
            this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // editGuestButton
            // 
            this.editGuestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editGuestButton.Location = new System.Drawing.Point(0, 29);
            this.editGuestButton.Name = "editGuestButton";
            this.editGuestButton.Size = new System.Drawing.Size(354, 29);
            this.editGuestButton.TabIndex = 4;
            this.editGuestButton.Text = "Edit Guest (change name, stats)";
            this.editGuestButton.UseVisualStyleBackColor = true;
            this.editGuestButton.Click += new System.EventHandler(this.editGuestButton_Click);
            // 
            // generateMoreMoneyButton
            // 
            this.generateMoreMoneyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.generateMoreMoneyButton.Location = new System.Drawing.Point(0, 116);
            this.generateMoreMoneyButton.Name = "generateMoreMoneyButton";
            this.generateMoreMoneyButton.Size = new System.Drawing.Size(354, 29);
            this.generateMoreMoneyButton.TabIndex = 7;
            this.generateMoreMoneyButton.Text = "Generate $10,000";
            this.generateMoreMoneyButton.UseVisualStyleBackColor = true;
            this.generateMoreMoneyButton.Click += new System.EventHandler(this.generateMoreMoneyButton_Click);
            // 
            // generateMoneyButton
            // 
            this.generateMoneyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.generateMoneyButton.Location = new System.Drawing.Point(0, 87);
            this.generateMoneyButton.Name = "generateMoneyButton";
            this.generateMoneyButton.Size = new System.Drawing.Size(354, 29);
            this.generateMoneyButton.TabIndex = 6;
            this.generateMoneyButton.Text = "Generate $1,000";
            this.generateMoneyButton.UseVisualStyleBackColor = true;
            this.generateMoneyButton.Click += new System.EventHandler(this.generateMoneyButton_Click);
            // 
            // changeWeatherButton
            // 
            this.changeWeatherButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeWeatherButton.Location = new System.Drawing.Point(0, 58);
            this.changeWeatherButton.Name = "changeWeatherButton";
            this.changeWeatherButton.Size = new System.Drawing.Size(354, 29);
            this.changeWeatherButton.TabIndex = 5;
            this.changeWeatherButton.Text = "Change Weather";
            this.changeWeatherButton.UseVisualStyleBackColor = true;
            // 
            // moreButton
            // 
            this.moreButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moreButton.Location = new System.Drawing.Point(0, 145);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(354, 42);
            this.moreButton.TabIndex = 8;
            this.moreButton.Text = "More...";
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 187);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.generateMoreMoneyButton);
            this.Controls.Add(this.generateMoneyButton);
            this.Controls.Add(this.changeWeatherButton);
            this.Controls.Add(this.editGuestButton);
            this.Controls.Add(this.addGuestButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebugForm";
            this.Text = "Debugging";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addGuestButton;
        private System.Windows.Forms.Button editGuestButton;
        private System.Windows.Forms.Button generateMoreMoneyButton;
        private System.Windows.Forms.Button generateMoneyButton;
        private System.Windows.Forms.Button changeWeatherButton;
        private System.Windows.Forms.Button moreButton;
    }
}