namespace ThemeParkTycoonGame.Forms.Screens
{
    partial class SingleGuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleGuestForm));
            this.statsParent = new System.Windows.Forms.Panel();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.rideParent = new System.Windows.Forms.Panel();
            this.rideHistoryGroupBox = new System.Windows.Forms.GroupBox();
            this.actionsListView = new System.Windows.Forms.ListView();
            this.rideColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rideEntryTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desireParent = new System.Windows.Forms.Panel();
            this.desiresGroupBox = new System.Windows.Forms.GroupBox();
            this.desiresPanel = new System.Windows.Forms.Panel();
            this.financeParent = new System.Windows.Forms.Panel();
            this.financeGroupBox = new System.Windows.Forms.GroupBox();
            this.financeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statsParent.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.rideParent.SuspendLayout();
            this.rideHistoryGroupBox.SuspendLayout();
            this.desireParent.SuspendLayout();
            this.desiresGroupBox.SuspendLayout();
            this.financeParent.SuspendLayout();
            this.financeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statsParent
            // 
            this.statsParent.Controls.Add(this.statsGroupBox);
            this.statsParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsParent.Location = new System.Drawing.Point(0, 0);
            this.statsParent.Name = "statsParent";
            this.statsParent.Padding = new System.Windows.Forms.Padding(5);
            this.statsParent.Size = new System.Drawing.Size(767, 122);
            this.statsParent.TabIndex = 0;
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.statsPanel);
            this.statsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsGroupBox.Location = new System.Drawing.Point(5, 5);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(757, 112);
            this.statsGroupBox.TabIndex = 5;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Stats";
            // 
            // statsPanel
            // 
            this.statsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsPanel.AutoScroll = true;
            this.statsPanel.Location = new System.Drawing.Point(6, 19);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(745, 87);
            this.statsPanel.TabIndex = 0;
            // 
            // rideParent
            // 
            this.rideParent.Controls.Add(this.rideHistoryGroupBox);
            this.rideParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.rideParent.Location = new System.Drawing.Point(0, 122);
            this.rideParent.Name = "rideParent";
            this.rideParent.Padding = new System.Windows.Forms.Padding(5);
            this.rideParent.Size = new System.Drawing.Size(767, 150);
            this.rideParent.TabIndex = 1;
            // 
            // rideHistoryGroupBox
            // 
            this.rideHistoryGroupBox.Controls.Add(this.actionsListView);
            this.rideHistoryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rideHistoryGroupBox.Location = new System.Drawing.Point(5, 5);
            this.rideHistoryGroupBox.Name = "rideHistoryGroupBox";
            this.rideHistoryGroupBox.Size = new System.Drawing.Size(757, 140);
            this.rideHistoryGroupBox.TabIndex = 0;
            this.rideHistoryGroupBox.TabStop = false;
            this.rideHistoryGroupBox.Text = "Ride History";
            // 
            // actionsListView
            // 
            this.actionsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.actionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rideColumnHeader,
            this.rideEntryTimeColumnHeader,
            this.statColumnHeader});
            this.actionsListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.actionsListView.HideSelection = false;
            this.actionsListView.Location = new System.Drawing.Point(3, 16);
            this.actionsListView.Name = "actionsListView";
            this.actionsListView.Size = new System.Drawing.Size(767, 121);
            this.actionsListView.TabIndex = 6;
            this.actionsListView.UseCompatibleStateImageBehavior = false;
            this.actionsListView.View = System.Windows.Forms.View.Details;
            // 
            // rideColumnHeader
            // 
            this.rideColumnHeader.Text = "Ride";
            this.rideColumnHeader.Width = 100;
            // 
            // rideEntryTimeColumnHeader
            // 
            this.rideEntryTimeColumnHeader.Text = "Time Of Ride";
            this.rideEntryTimeColumnHeader.Width = 135;
            // 
            // statColumnHeader
            // 
            this.statColumnHeader.Text = "Stats Changes";
            this.statColumnHeader.Width = 500;
            // 
            // desireParent
            // 
            this.desireParent.Controls.Add(this.desiresGroupBox);
            this.desireParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.desireParent.Location = new System.Drawing.Point(0, 272);
            this.desireParent.Name = "desireParent";
            this.desireParent.Padding = new System.Windows.Forms.Padding(5);
            this.desireParent.Size = new System.Drawing.Size(767, 136);
            this.desireParent.TabIndex = 2;
            // 
            // desiresGroupBox
            // 
            this.desiresGroupBox.Controls.Add(this.desiresPanel);
            this.desiresGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desiresGroupBox.Location = new System.Drawing.Point(5, 5);
            this.desiresGroupBox.Name = "desiresGroupBox";
            this.desiresGroupBox.Size = new System.Drawing.Size(757, 126);
            this.desiresGroupBox.TabIndex = 7;
            this.desiresGroupBox.TabStop = false;
            this.desiresGroupBox.Text = "Desires";
            // 
            // desiresPanel
            // 
            this.desiresPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desiresPanel.AutoScroll = true;
            this.desiresPanel.Location = new System.Drawing.Point(6, 19);
            this.desiresPanel.Name = "desiresPanel";
            this.desiresPanel.Size = new System.Drawing.Size(742, 101);
            this.desiresPanel.TabIndex = 1;
            // 
            // financeParent
            // 
            this.financeParent.Controls.Add(this.financeGroupBox);
            this.financeParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financeParent.Location = new System.Drawing.Point(0, 408);
            this.financeParent.Name = "financeParent";
            this.financeParent.Padding = new System.Windows.Forms.Padding(5);
            this.financeParent.Size = new System.Drawing.Size(767, 131);
            this.financeParent.TabIndex = 3;
            // 
            // financeGroupBox
            // 
            this.financeGroupBox.Controls.Add(this.financeListView);
            this.financeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financeGroupBox.Location = new System.Drawing.Point(5, 5);
            this.financeGroupBox.Name = "financeGroupBox";
            this.financeGroupBox.Size = new System.Drawing.Size(757, 121);
            this.financeGroupBox.TabIndex = 0;
            this.financeGroupBox.TabStop = false;
            this.financeGroupBox.Text = "Financial History";
            // 
            // financeListView
            // 
            this.financeListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.financeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.financeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financeListView.HideSelection = false;
            this.financeListView.Location = new System.Drawing.Point(3, 16);
            this.financeListView.Name = "financeListView";
            this.financeListView.Size = new System.Drawing.Size(751, 102);
            this.financeListView.TabIndex = 7;
            this.financeListView.UseCompatibleStateImageBehavior = false;
            this.financeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Balance Changed";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time Of Transaction";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 500;
            // 
            // SingleGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 539);
            this.Controls.Add(this.financeParent);
            this.Controls.Add(this.desireParent);
            this.Controls.Add(this.rideParent);
            this.Controls.Add(this.statsParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleGuestForm";
            this.Text = "GuestForm";
            this.statsParent.ResumeLayout(false);
            this.statsGroupBox.ResumeLayout(false);
            this.rideParent.ResumeLayout(false);
            this.rideHistoryGroupBox.ResumeLayout(false);
            this.desireParent.ResumeLayout(false);
            this.desiresGroupBox.ResumeLayout(false);
            this.financeParent.ResumeLayout(false);
            this.financeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel statsParent;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel rideParent;
        private System.Windows.Forms.Panel desireParent;
        private System.Windows.Forms.GroupBox rideHistoryGroupBox;
        private System.Windows.Forms.ListView actionsListView;
        private System.Windows.Forms.ColumnHeader rideColumnHeader;
        private System.Windows.Forms.ColumnHeader rideEntryTimeColumnHeader;
        private System.Windows.Forms.ColumnHeader statColumnHeader;
        private System.Windows.Forms.GroupBox desiresGroupBox;
        private System.Windows.Forms.Panel desiresPanel;
        private System.Windows.Forms.Panel financeParent;
        private System.Windows.Forms.GroupBox financeGroupBox;
        private System.Windows.Forms.ListView financeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}