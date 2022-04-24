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
            this.button1 = new System.Windows.Forms.Button();
            this.CutAndFittingButtton = new System.Windows.Forms.Button();
            this.AddWeldButton = new System.Windows.Forms.Button();
            this.EnumerateButton = new System.Windows.Forms.Button();
            this.UDAButton = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "BoltArrayApplication";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BoltArrayButtton_Click);
            // 
            // CutAndFittingButtton
            // 
            this.CutAndFittingButtton.Location = new System.Drawing.Point(12, 128);
            this.CutAndFittingButtton.Name = "CutAndFittingButtton";
            this.CutAndFittingButtton.Size = new System.Drawing.Size(220, 23);
            this.CutAndFittingButtton.TabIndex = 4;
            this.CutAndFittingButtton.Text = "CutAndFittingApplication";
            this.CutAndFittingButtton.UseVisualStyleBackColor = true;
            this.CutAndFittingButtton.Click += new System.EventHandler(this.CutAndFittingButtton_Click);
            // 
            // AddWeldButton
            // 
            this.AddWeldButton.Location = new System.Drawing.Point(12, 157);
            this.AddWeldButton.Name = "AddWeldButton";
            this.AddWeldButton.Size = new System.Drawing.Size(220, 23);
            this.AddWeldButton.TabIndex = 5;
            this.AddWeldButton.Text = "AddWeldApplication";
            this.AddWeldButton.UseVisualStyleBackColor = true;
            this.AddWeldButton.Click += new System.EventHandler(this.AddWeldButton_Click);
            // 
            // EnumerateButton
            // 
            this.EnumerateButton.Location = new System.Drawing.Point(12, 186);
            this.EnumerateButton.Name = "EnumerateButton";
            this.EnumerateButton.Size = new System.Drawing.Size(220, 23);
            this.EnumerateButton.TabIndex = 6;
            this.EnumerateButton.Text = "EnumerateApplication";
            this.EnumerateButton.UseVisualStyleBackColor = true;
            this.EnumerateButton.Click += new System.EventHandler(this.EnumerateButton_Click);
            // 
            // UDAButton
            // 
            this.UDAButton.Location = new System.Drawing.Point(12, 215);
            this.UDAButton.Name = "UDAButton";
            this.UDAButton.Size = new System.Drawing.Size(220, 23);
            this.UDAButton.TabIndex = 7;
            this.UDAButton.Text = "UDAApplication";
            this.UDAButton.UseVisualStyleBackColor = true;
            this.UDAButton.Click += new System.EventHandler(this.UDAButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 270);
            this.Controls.Add(this.UDAButton);
            this.Controls.Add(this.EnumerateButton);
            this.Controls.Add(this.AddWeldButton);
            this.Controls.Add(this.CutAndFittingButtton);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CutAndFittingButtton;
        private System.Windows.Forms.Button AddWeldButton;
        private System.Windows.Forms.Button EnumerateButton;
        private System.Windows.Forms.Button UDAButton;
    }
}