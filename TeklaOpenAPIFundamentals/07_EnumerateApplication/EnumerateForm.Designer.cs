namespace TeklaOpenAPIFundamentals
{
    partial class EnumerateForm
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
            this.ExamineSolidButton = new System.Windows.Forms.Button();
            this.GetBeamsButton = new System.Windows.Forms.Button();
            this.GetContourPlateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExamineSolidButton
            // 
            this.ExamineSolidButton.Location = new System.Drawing.Point(25, 35);
            this.ExamineSolidButton.Name = "ExamineSolidButton";
            this.ExamineSolidButton.Size = new System.Drawing.Size(217, 23);
            this.ExamineSolidButton.TabIndex = 0;
            this.ExamineSolidButton.Text = "ExamineSolid";
            this.ExamineSolidButton.UseVisualStyleBackColor = true;
            this.ExamineSolidButton.Click += new System.EventHandler(this.ExamineSolidButton_Click);
            // 
            // GetBeamsButton
            // 
            this.GetBeamsButton.Location = new System.Drawing.Point(25, 64);
            this.GetBeamsButton.Name = "GetBeamsButton";
            this.GetBeamsButton.Size = new System.Drawing.Size(217, 23);
            this.GetBeamsButton.TabIndex = 1;
            this.GetBeamsButton.Text = "GetBeamsFromSelectedObjects";
            this.GetBeamsButton.UseVisualStyleBackColor = true;
            this.GetBeamsButton.Click += new System.EventHandler(this.GetBeamsButton_Click);
            // 
            // GetContourPlateButton
            // 
            this.GetContourPlateButton.Location = new System.Drawing.Point(25, 93);
            this.GetContourPlateButton.Name = "GetContourPlateButton";
            this.GetContourPlateButton.Size = new System.Drawing.Size(217, 23);
            this.GetContourPlateButton.TabIndex = 2;
            this.GetContourPlateButton.Text = "GetContourPlateFromSelectedObjects";
            this.GetContourPlateButton.UseVisualStyleBackColor = true;
            this.GetContourPlateButton.Click += new System.EventHandler(this.GetContourPlateButton_Click);
            // 
            // EnumerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 202);
            this.Controls.Add(this.GetContourPlateButton);
            this.Controls.Add(this.GetBeamsButton);
            this.Controls.Add(this.ExamineSolidButton);
            this.Name = "EnumerateForm";
            this.Text = "EnumerateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExamineSolidButton;
        private System.Windows.Forms.Button GetBeamsButton;
        private System.Windows.Forms.Button GetContourPlateButton;
    }
}