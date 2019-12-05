namespace ThemeParkTycoonGame.Forms.Screens
{
    partial class ParkConfigurationForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Coasters", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkConfigurationForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.objectsListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.walletBalanceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeEnteredColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entryFeeNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Park Name:";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Location = new System.Drawing.Point(12, 32);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(55, 13);
            this.entryFeeLabel.TabIndex = 1;
            this.entryFeeLabel.Text = "Entry Fee:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(81, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(282, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // entryFeeNumericUpDown
            // 
            this.entryFeeNumericUpDown.DecimalPlaces = 2;
            this.entryFeeNumericUpDown.Location = new System.Drawing.Point(73, 30);
            this.entryFeeNumericUpDown.Name = "entryFeeNumericUpDown";
            this.entryFeeNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.entryFeeNumericUpDown.TabIndex = 3;
            this.entryFeeNumericUpDown.ValueChanged += new System.EventHandler(this.entryFeeNumericUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inventoryLabel);
            this.groupBox1.Controls.Add(this.objectsListView);
            this.groupBox1.Controls.Add(this.balanceTextBox);
            this.groupBox1.Controls.Add(this.currentBalanceLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Stuff:";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(8, 53);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(334, 13);
            this.inventoryLabel.TabIndex = 7;
            this.inventoryLabel.Text = "Your Rides and Shops";
            this.inventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objectsListView
            // 
            this.objectsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.objectsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.walletBalanceColumnHeader,
            this.timeEnteredColumnHeader});
            listViewGroup1.Header = "Coasters";
            listViewGroup1.Name = "coasterListViewGroup";
            this.objectsListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.objectsListView.Location = new System.Drawing.Point(8, 69);
            this.objectsListView.MultiSelect = false;
            this.objectsListView.Name = "objectsListView";
            this.objectsListView.Size = new System.Drawing.Size(334, 229);
            this.objectsListView.TabIndex = 6;
            this.objectsListView.UseCompatibleStateImageBehavior = false;
            this.objectsListView.ItemActivate += new System.EventHandler(this.objectsListView_ItemActivate);
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
            // timeEnteredColumnHeader
            // 
            this.timeEnteredColumnHeader.Text = "Time Entered";
            this.timeEnteredColumnHeader.Width = 127;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.balanceTextBox.Enabled = false;
            this.balanceTextBox.Location = new System.Drawing.Point(106, 18);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(236, 20);
            this.balanceTextBox.TabIndex = 5;
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Location = new System.Drawing.Point(5, 21);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(98, 13);
            this.currentBalanceLabel.TabIndex = 5;
            this.currentBalanceLabel.Text = "Current Balance:  $";
            // 
            // ParkConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.entryFeeNumericUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParkConfigurationForm";
            this.Text = "Park";
            this.Load += new System.EventHandler(this.ParkConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryFeeNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown entryFeeNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.ListView objectsListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader walletBalanceColumnHeader;
        private System.Windows.Forms.ColumnHeader timeEnteredColumnHeader;
    }
}