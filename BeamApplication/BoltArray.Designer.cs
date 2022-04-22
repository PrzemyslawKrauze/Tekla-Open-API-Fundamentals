namespace TeklaOpenAPIFundamentals
{
    partial class BoltArray
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
            this.InsertBoltArrayButton = new System.Windows.Forms.Button();
            this.XDistanceTextBox = new System.Windows.Forms.TextBox();
            this.XDistanceLabel = new System.Windows.Forms.Label();
            this.YDistanceTextBox = new System.Windows.Forms.TextBox();
            this.YDistanceLabel = new System.Windows.Forms.Label();
            this.BeamClassTextBox = new System.Windows.Forms.TextBox();
            this.BeamClassLabel = new System.Windows.Forms.Label();
            this.BoltStandardTextBox = new System.Windows.Forms.TextBox();
            this.BoltStandardLabel = new System.Windows.Forms.Label();
            this.BoltSizeTextBox = new System.Windows.Forms.TextBox();
            this.BoltSizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InsertBoltArrayButton
            // 
            this.InsertBoltArrayButton.Location = new System.Drawing.Point(95, 167);
            this.InsertBoltArrayButton.Name = "InsertBoltArrayButton";
            this.InsertBoltArrayButton.Size = new System.Drawing.Size(102, 23);
            this.InsertBoltArrayButton.TabIndex = 0;
            this.InsertBoltArrayButton.Text = "InsertBoltArray";
            this.InsertBoltArrayButton.UseVisualStyleBackColor = true;
            this.InsertBoltArrayButton.Click += new System.EventHandler(this.InsertBoltArrayButton_Click);
            // 
            // XDistanceTextBox
            // 
            this.XDistanceTextBox.Location = new System.Drawing.Point(122, 12);
            this.XDistanceTextBox.Name = "XDistanceTextBox";
            this.XDistanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.XDistanceTextBox.TabIndex = 1;
            // 
            // XDistanceLabel
            // 
            this.XDistanceLabel.AutoSize = true;
            this.XDistanceLabel.Location = new System.Drawing.Point(30, 15);
            this.XDistanceLabel.Name = "XDistanceLabel";
            this.XDistanceLabel.Size = new System.Drawing.Size(56, 13);
            this.XDistanceLabel.TabIndex = 2;
            this.XDistanceLabel.Text = "XDistance";
            // 
            // YDistanceTextBox
            // 
            this.YDistanceTextBox.Location = new System.Drawing.Point(122, 38);
            this.YDistanceTextBox.Name = "YDistanceTextBox";
            this.YDistanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.YDistanceTextBox.TabIndex = 3;
            // 
            // YDistanceLabel
            // 
            this.YDistanceLabel.AutoSize = true;
            this.YDistanceLabel.Location = new System.Drawing.Point(30, 41);
            this.YDistanceLabel.Name = "YDistanceLabel";
            this.YDistanceLabel.Size = new System.Drawing.Size(56, 13);
            this.YDistanceLabel.TabIndex = 4;
            this.YDistanceLabel.Text = "YDistance";
            // 
            // BeamClassTextBox
            // 
            this.BeamClassTextBox.Location = new System.Drawing.Point(122, 64);
            this.BeamClassTextBox.Name = "BeamClassTextBox";
            this.BeamClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.BeamClassTextBox.TabIndex = 5;
            // 
            // BeamClassLabel
            // 
            this.BeamClassLabel.AutoSize = true;
            this.BeamClassLabel.Location = new System.Drawing.Point(30, 67);
            this.BeamClassLabel.Name = "BeamClassLabel";
            this.BeamClassLabel.Size = new System.Drawing.Size(59, 13);
            this.BeamClassLabel.TabIndex = 6;
            this.BeamClassLabel.Text = "BeamClass";
            // 
            // BoltStandardTextBox
            // 
            this.BoltStandardTextBox.Location = new System.Drawing.Point(122, 90);
            this.BoltStandardTextBox.Name = "BoltStandardTextBox";
            this.BoltStandardTextBox.Size = new System.Drawing.Size(100, 20);
            this.BoltStandardTextBox.TabIndex = 7;
            // 
            // BoltStandardLabel
            // 
            this.BoltStandardLabel.AutoSize = true;
            this.BoltStandardLabel.Location = new System.Drawing.Point(30, 93);
            this.BoltStandardLabel.Name = "BoltStandardLabel";
            this.BoltStandardLabel.Size = new System.Drawing.Size(68, 13);
            this.BoltStandardLabel.TabIndex = 8;
            this.BoltStandardLabel.Text = "BoltStandard";
            // 
            // BoltSizeTextBox
            // 
            this.BoltSizeTextBox.Location = new System.Drawing.Point(122, 116);
            this.BoltSizeTextBox.Name = "BoltSizeTextBox";
            this.BoltSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.BoltSizeTextBox.TabIndex = 9;
            // 
            // BoltSizeLabel
            // 
            this.BoltSizeLabel.AutoSize = true;
            this.BoltSizeLabel.Location = new System.Drawing.Point(30, 119);
            this.BoltSizeLabel.Name = "BoltSizeLabel";
            this.BoltSizeLabel.Size = new System.Drawing.Size(45, 13);
            this.BoltSizeLabel.TabIndex = 10;
            this.BoltSizeLabel.Text = "BoltSize";
            // 
            // BoltArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 254);
            this.Controls.Add(this.BoltSizeLabel);
            this.Controls.Add(this.BoltSizeTextBox);
            this.Controls.Add(this.BoltStandardLabel);
            this.Controls.Add(this.BoltStandardTextBox);
            this.Controls.Add(this.BeamClassLabel);
            this.Controls.Add(this.BeamClassTextBox);
            this.Controls.Add(this.YDistanceLabel);
            this.Controls.Add(this.YDistanceTextBox);
            this.Controls.Add(this.XDistanceLabel);
            this.Controls.Add(this.XDistanceTextBox);
            this.Controls.Add(this.InsertBoltArrayButton);
            this.Name = "BoltArray";
            this.Text = "BoltArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertBoltArrayButton;
        private System.Windows.Forms.TextBox XDistanceTextBox;
        private System.Windows.Forms.Label XDistanceLabel;
        private System.Windows.Forms.TextBox YDistanceTextBox;
        private System.Windows.Forms.Label YDistanceLabel;
        private System.Windows.Forms.TextBox BeamClassTextBox;
        private System.Windows.Forms.Label BeamClassLabel;
        private System.Windows.Forms.TextBox BoltStandardTextBox;
        private System.Windows.Forms.Label BoltStandardLabel;
        private System.Windows.Forms.TextBox BoltSizeTextBox;
        private System.Windows.Forms.Label BoltSizeLabel;
    }
}