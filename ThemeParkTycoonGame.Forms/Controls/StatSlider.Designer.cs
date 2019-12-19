namespace ThemeParkTycoonGame.Forms.Controls
{
    partial class StatSlider
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statLabel = new System.Windows.Forms.Label();
            this.statValueInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.statValueInput)).BeginInit();
            this.SuspendLayout();
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.Location = new System.Drawing.Point(2, 10);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(45, 13);
            this.statLabel.TabIndex = 4;
            this.statLabel.Text = "Hunger:";
            // 
            // statValueInput
            // 
            this.statValueInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statValueInput.DecimalPlaces = 2;
            this.statValueInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.statValueInput.Location = new System.Drawing.Point(114, 8);
            this.statValueInput.Name = "statValueInput";
            this.statValueInput.Size = new System.Drawing.Size(137, 20);
            this.statValueInput.TabIndex = 5;
            this.statValueInput.ValueChanged += new System.EventHandler(this.statValueInput_ValueChanged);
            // 
            // StatSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statValueInput);
            this.Controls.Add(this.statLabel);
            this.Name = "StatSlider";
            this.Size = new System.Drawing.Size(254, 33);
            ((System.ComponentModel.ISupportInitialize)(this.statValueInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.NumericUpDown statValueInput;
    }
}
