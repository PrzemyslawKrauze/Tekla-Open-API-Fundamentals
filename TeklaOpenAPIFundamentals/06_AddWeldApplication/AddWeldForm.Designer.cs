namespace TeklaOpenAPIFundamentals
{
    partial class AddWeldForm
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
            this.AddWeldButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddWeldButton
            // 
            this.AddWeldButton.Location = new System.Drawing.Point(50, 48);
            this.AddWeldButton.Name = "AddWeldButton";
            this.AddWeldButton.Size = new System.Drawing.Size(100, 23);
            this.AddWeldButton.TabIndex = 0;
            this.AddWeldButton.Text = "AddWeld";
            this.AddWeldButton.UseVisualStyleBackColor = true;
            this.AddWeldButton.Click += new System.EventHandler(this.AddWeldButton_Click);
            // 
            // AddWeldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 144);
            this.Controls.Add(this.AddWeldButton);
            this.Name = "AddWeldForm";
            this.Text = "AddWeldForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWeldButton;
    }
}