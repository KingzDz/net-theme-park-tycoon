namespace ThemeParkTycoonGame.Forms.Screens
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.parkConfigurationToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guestsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.weatherToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buyRideToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.debugToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parkConfigurationToolStripButton,
            this.guestsToolStripButton,
            this.weatherToolStripButton,
            this.toolStripSeparator1,
            this.buyRideToolStripButton,
            this.toolStripSeparator2,
            this.debugToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // parkConfigurationToolStripButton
            // 
            this.parkConfigurationToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.parkConfigurationToolStripButton.Image = global::ThemeParkTycoonGame.Forms.Properties.Resources.general_ledger_48;
            this.parkConfigurationToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.parkConfigurationToolStripButton.Name = "parkConfigurationToolStripButton";
            this.parkConfigurationToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.parkConfigurationToolStripButton.Text = "Park";
            this.parkConfigurationToolStripButton.Click += new System.EventHandler(this.parkConfigurationToolStripButton_Click);
            // 
            // guestsToolStripButton
            // 
            this.guestsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guestsToolStripButton.Image = global::ThemeParkTycoonGame.Forms.Properties.Resources.guests_48;
            this.guestsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guestsToolStripButton.Name = "guestsToolStripButton";
            this.guestsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.guestsToolStripButton.Text = "Guests";
            this.guestsToolStripButton.Click += new System.EventHandler(this.guestsToolStripButton_Click);
            // 
            // weatherToolStripButton
            // 
            this.weatherToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.weatherToolStripButton.Image = global::ThemeParkTycoonGame.Forms.Properties.Resources.weather_sun_48;
            this.weatherToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.weatherToolStripButton.Name = "weatherToolStripButton";
            this.weatherToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.weatherToolStripButton.Text = "Weather";
            this.weatherToolStripButton.Click += new System.EventHandler(this.weatherToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buyRideToolStripButton
            // 
            this.buyRideToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buyRideToolStripButton.Image = global::ThemeParkTycoonGame.Forms.Properties.Resources.roller_coaster_48;
            this.buyRideToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buyRideToolStripButton.Name = "buyRideToolStripButton";
            this.buyRideToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.buyRideToolStripButton.Text = "Buy Rides";
            this.buyRideToolStripButton.Click += new System.EventHandler(this.buyRideToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // debugToolStripButton
            // 
            this.debugToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.debugToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("debugToolStripButton.Image")));
            this.debugToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.debugToolStripButton.Name = "debugToolStripButton";
            this.debugToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.debugToolStripButton.Text = "Debugging";
            this.debugToolStripButton.Click += new System.EventHandler(this.debugToolStripButton_Click);
            // 
            // tickTimer
            // 
            this.tickTimer.Enabled = true;
            this.tickTimer.Interval = 1000;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 574);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ManagerForm";
            this.Text = "Theme Park Tycoon";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton parkConfigurationToolStripButton;
        private System.Windows.Forms.ToolStripButton guestsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton debugToolStripButton;
        private System.Windows.Forms.ToolStripButton weatherToolStripButton;
        private System.Windows.Forms.ToolStripButton buyRideToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer tickTimer;
    }
}

