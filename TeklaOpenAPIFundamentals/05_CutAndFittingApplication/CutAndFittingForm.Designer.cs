namespace TeklaOpenAPIFundamentals
{
    partial class CutAndFittingForm
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
            this.CreateCutButton = new System.Windows.Forms.Button();
            this.CreateFittingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateCutButton
            // 
            this.CreateCutButton.Location = new System.Drawing.Point(108, 92);
            this.CreateCutButton.Name = "CreateCutButton";
            this.CreateCutButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCutButton.TabIndex = 0;
            this.CreateCutButton.Text = "CreateCut";
            this.CreateCutButton.UseVisualStyleBackColor = true;
            this.CreateCutButton.Click += new System.EventHandler(this.CreateCutButton_Click);
            // 
            // CreateFittingButton
            // 
            this.CreateFittingButton.Location = new System.Drawing.Point(108, 63);
            this.CreateFittingButton.Name = "CreateFittingButton";
            this.CreateFittingButton.Size = new System.Drawing.Size(75, 23);
            this.CreateFittingButton.TabIndex = 1;
            this.CreateFittingButton.Text = "CreateFitting";
            this.CreateFittingButton.UseVisualStyleBackColor = true;
            this.CreateFittingButton.Click += new System.EventHandler(this.CreateFittingButton_Click);
            // 
            // CutAndFittingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 249);
            this.Controls.Add(this.CreateFittingButton);
            this.Controls.Add(this.CreateCutButton);
            this.Name = "CutAndFittingApp";
            this.Text = "CutAndFittingApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCutButton;
        private System.Windows.Forms.Button CreateFittingButton;
    }
}