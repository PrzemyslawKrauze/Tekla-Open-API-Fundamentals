namespace TeklaOpenAPIFundamentals
{
    partial class ModifyObjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OnPlaneComboBox = new System.Windows.Forms.ComboBox();
            this.ModifyBeamButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.Label();
            this.DepthComboBox = new System.Windows.Forms.ComboBox();
            this.RotationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OnPlane";
            // 
            // OnPlaneComboBox
            // 
            this.OnPlaneComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Left",
            "Middle",
            "Right"});
            this.OnPlaneComboBox.FormattingEnabled = true;
            this.OnPlaneComboBox.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.OnPlaneComboBox.Location = new System.Drawing.Point(289, 57);
            this.OnPlaneComboBox.Name = "OnPlaneComboBox";
            this.OnPlaneComboBox.Size = new System.Drawing.Size(121, 21);
            this.OnPlaneComboBox.TabIndex = 3;
            // 
            // ModifyBeamButton
            // 
            this.ModifyBeamButton.Location = new System.Drawing.Point(44, 84);
            this.ModifyBeamButton.Name = "ModifyBeamButton";
            this.ModifyBeamButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyBeamButton.TabIndex = 4;
            this.ModifyBeamButton.Text = "ModifyBeam";
            this.ModifyBeamButton.UseVisualStyleBackColor = true;
            this.ModifyBeamButton.Click += new System.EventHandler(this.OnModifyButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSize = true;
            this.NameTextBox.Location = new System.Drawing.Point(159, 41);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(36, 13);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.Text = "Depth";
            // 
            // DepthComboBox
            // 
            this.DepthComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Left",
            "Middle",
            "Right"});
            this.DepthComboBox.FormattingEnabled = true;
            this.DepthComboBox.Items.AddRange(new object[] {
            "Front",
            "Middle",
            "Behind"});
            this.DepthComboBox.Location = new System.Drawing.Point(162, 57);
            this.DepthComboBox.Name = "DepthComboBox";
            this.DepthComboBox.Size = new System.Drawing.Size(121, 21);
            this.DepthComboBox.TabIndex = 7;
            // 
            // RotationComboBox
            // 
            this.RotationComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Left",
            "Middle",
            "Right"});
            this.RotationComboBox.FormattingEnabled = true;
            this.RotationComboBox.Items.AddRange(new object[] {
            "Top",
            "Front",
            "Back",
            "Below"});
            this.RotationComboBox.Location = new System.Drawing.Point(35, 57);
            this.RotationComboBox.Name = "RotationComboBox";
            this.RotationComboBox.Size = new System.Drawing.Size(121, 21);
            this.RotationComboBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rotation";
            // 
            // ModifyObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RotationComboBox);
            this.Controls.Add(this.DepthComboBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ModifyBeamButton);
            this.Controls.Add(this.OnPlaneComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ModifyObjectForm";
            this.Text = "ModifyObjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OnPlaneComboBox;
        private System.Windows.Forms.Button ModifyBeamButton;
        private System.Windows.Forms.Label NameTextBox;
        private System.Windows.Forms.ComboBox DepthComboBox;
        private System.Windows.Forms.ComboBox RotationComboBox;
        private System.Windows.Forms.Label label2;
    }
}