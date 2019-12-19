namespace ThemeParkTycoonGame.Forms.Screens
{
    partial class GuestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestsForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.guestsListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.walletBalanceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeEnteredColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 361);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(542, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // guestsListView
            // 
            this.guestsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.guestsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.walletBalanceColumnHeader,
            this.actionColumnHeader,
            this.timeEnteredColumnHeader});
            this.guestsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestsListView.Location = new System.Drawing.Point(0, 0);
            this.guestsListView.MultiSelect = false;
            this.guestsListView.Name = "guestsListView";
            this.guestsListView.Size = new System.Drawing.Size(542, 361);
            this.guestsListView.TabIndex = 2;
            this.guestsListView.UseCompatibleStateImageBehavior = false;
            this.guestsListView.View = System.Windows.Forms.View.Details;
            this.guestsListView.ItemActivate += new System.EventHandler(this.guestsListView_ItemActivate);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 100;
            // 
            // walletBalanceColumnHeader
            // 
            this.walletBalanceColumnHeader.Text = "$";
            // 
            // actionColumnHeader
            // 
            this.actionColumnHeader.Text = "Action";
            this.actionColumnHeader.Width = 250;
            // 
            // timeEnteredColumnHeader
            // 
            this.timeEnteredColumnHeader.Text = "Time Entered";
            this.timeEnteredColumnHeader.Width = 100;
            // 
            // GuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 383);
            this.Controls.Add(this.guestsListView);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestsForm";
            this.Text = "Guests";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ListView guestsListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader timeEnteredColumnHeader;
        private System.Windows.Forms.ColumnHeader walletBalanceColumnHeader;
        private System.Windows.Forms.ColumnHeader actionColumnHeader;
    }
}