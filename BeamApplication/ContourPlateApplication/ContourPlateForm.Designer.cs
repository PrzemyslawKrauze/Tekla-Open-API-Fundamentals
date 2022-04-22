namespace TeklaOpenAPIFundamentals
{
    partial class ContourPlateAppForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insertContourPlateButton = new System.Windows.Forms.Button();
            this.insertPolyBeamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // insertContourPlateButton
            // 
            this.insertContourPlateButton.Location = new System.Drawing.Point(100, 94);
            this.insertContourPlateButton.Name = "insertContourPlateButton";
            this.insertContourPlateButton.Size = new System.Drawing.Size(138, 23);
            this.insertContourPlateButton.TabIndex = 2;
            this.insertContourPlateButton.Text = "InsertContourPlate";
            this.insertContourPlateButton.UseVisualStyleBackColor = true;
            this.insertContourPlateButton.Click += new System.EventHandler(this.InsertContourPlateButton_Click);
            // 
            // insertPolyBeamButton
            // 
            this.insertPolyBeamButton.Location = new System.Drawing.Point(100, 123);
            this.insertPolyBeamButton.Name = "insertPolyBeamButton";
            this.insertPolyBeamButton.Size = new System.Drawing.Size(138, 23);
            this.insertPolyBeamButton.TabIndex = 3;
            this.insertPolyBeamButton.Text = "InsertPolyBeam";
            this.insertPolyBeamButton.UseVisualStyleBackColor = true;
            this.insertPolyBeamButton.Click += new System.EventHandler(this.InsertPolyBeamButton_Click);
            // 
            // ContourPlateAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 195);
            this.Controls.Add(this.insertPolyBeamButton);
            this.Controls.Add(this.insertContourPlateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ContourPlateAppForm";
            this.Text = "ContourPlateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertContourPlateButton;
        private System.Windows.Forms.Button insertPolyBeamButton;
    }
}