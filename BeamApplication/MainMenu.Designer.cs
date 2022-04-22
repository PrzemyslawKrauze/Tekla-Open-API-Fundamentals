namespace TeklaOpenAPIFundamentals
{
    partial class MainMenu
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
            this.BeamApplicationButton = new System.Windows.Forms.Button();
            this.ContourPlateButton = new System.Windows.Forms.Button();
            this.ModifyObjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BeamApplicationButton
            // 
            this.BeamApplicationButton.Location = new System.Drawing.Point(12, 12);
            this.BeamApplicationButton.Name = "BeamApplicationButton";
            this.BeamApplicationButton.Size = new System.Drawing.Size(220, 23);
            this.BeamApplicationButton.TabIndex = 0;
            this.BeamApplicationButton.Text = "BeamApplication";
            this.BeamApplicationButton.UseVisualStyleBackColor = true;
            this.BeamApplicationButton.Click += new System.EventHandler(this.BeamAplltication_Click);
            // 
            // ContourPlateButton
            // 
            this.ContourPlateButton.Location = new System.Drawing.Point(12, 41);
            this.ContourPlateButton.Name = "ContourPlateButton";
            this.ContourPlateButton.Size = new System.Drawing.Size(220, 23);
            this.ContourPlateButton.TabIndex = 1;
            this.ContourPlateButton.Text = "ContourPlateApplication";
            this.ContourPlateButton.UseVisualStyleBackColor = true;
            this.ContourPlateButton.Click += new System.EventHandler(this.ContourPlateButton_Click);
            // 
            // ModifyObjectButton
            // 
            this.ModifyObjectButton.Location = new System.Drawing.Point(12, 70);
            this.ModifyObjectButton.Name = "ModifyObjectButton";
            this.ModifyObjectButton.Size = new System.Drawing.Size(220, 23);
            this.ModifyObjectButton.TabIndex = 2;
            this.ModifyObjectButton.Text = "ModifyObjectApplication";
            this.ModifyObjectButton.UseVisualStyleBackColor = true;
            this.ModifyObjectButton.Click += new System.EventHandler(this.ModifyObjectButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 270);
            this.Controls.Add(this.ModifyObjectButton);
            this.Controls.Add(this.ContourPlateButton);
            this.Controls.Add(this.BeamApplicationButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BeamApplicationButton;
        private System.Windows.Forms.Button ContourPlateButton;
        private System.Windows.Forms.Button ModifyObjectButton;
    }
}