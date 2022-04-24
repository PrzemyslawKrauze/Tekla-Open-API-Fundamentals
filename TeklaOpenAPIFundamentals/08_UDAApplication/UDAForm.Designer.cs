namespace TeklaOpenAPIFundamentals
{
    partial class UDAForm
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
            this.CreateUDAButton = new System.Windows.Forms.Button();
            this.UserCommentTextBox = new System.Windows.Forms.TextBox();
            this.PriorityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoundUDAButton = new System.Windows.Forms.Button();
            this.RoundToNearestTextBox = new System.Windows.Forms.TextBox();
            this.FractionalDigitsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateUDAButton
            // 
            this.CreateUDAButton.Location = new System.Drawing.Point(111, 68);
            this.CreateUDAButton.Name = "CreateUDAButton";
            this.CreateUDAButton.Size = new System.Drawing.Size(100, 23);
            this.CreateUDAButton.TabIndex = 0;
            this.CreateUDAButton.Text = "CreateUDA";
            this.CreateUDAButton.UseVisualStyleBackColor = true;
            this.CreateUDAButton.Click += new System.EventHandler(this.CreateUDAButton_Click);
            // 
            // UserCommentTextBox
            // 
            this.UserCommentTextBox.Location = new System.Drawing.Point(111, 6);
            this.UserCommentTextBox.Name = "UserCommentTextBox";
            this.UserCommentTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserCommentTextBox.TabIndex = 1;
            // 
            // PriorityTextBox
            // 
            this.PriorityTextBox.Location = new System.Drawing.Point(111, 32);
            this.PriorityTextBox.Name = "PriorityTextBox";
            this.PriorityTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriorityTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserComment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Priority";
            // 
            // RoundUDAButton
            // 
            this.RoundUDAButton.Location = new System.Drawing.Point(111, 123);
            this.RoundUDAButton.Name = "RoundUDAButton";
            this.RoundUDAButton.Size = new System.Drawing.Size(100, 23);
            this.RoundUDAButton.TabIndex = 5;
            this.RoundUDAButton.Text = "RoundUDA";
            this.RoundUDAButton.UseVisualStyleBackColor = true;
            this.RoundUDAButton.Click += new System.EventHandler(this.RoundUDAButton_Click);
            // 
            // RoundToNearestTextBox
            // 
            this.RoundToNearestTextBox.Location = new System.Drawing.Point(111, 97);
            this.RoundToNearestTextBox.Name = "RoundToNearestTextBox";
            this.RoundToNearestTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoundToNearestTextBox.TabIndex = 6;
            // 
            // FractionalDigitsLabel
            // 
            this.FractionalDigitsLabel.AutoSize = true;
            this.FractionalDigitsLabel.Location = new System.Drawing.Point(12, 100);
            this.FractionalDigitsLabel.Name = "FractionalDigitsLabel";
            this.FractionalDigitsLabel.Size = new System.Drawing.Size(89, 13);
            this.FractionalDigitsLabel.TabIndex = 7;
            this.FractionalDigitsLabel.Text = "RoundToNearest";
            // 
            // UDAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 244);
            this.Controls.Add(this.FractionalDigitsLabel);
            this.Controls.Add(this.RoundToNearestTextBox);
            this.Controls.Add(this.RoundUDAButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriorityTextBox);
            this.Controls.Add(this.UserCommentTextBox);
            this.Controls.Add(this.CreateUDAButton);
            this.Name = "UDAForm";
            this.Text = "UDAForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateUDAButton;
        private System.Windows.Forms.TextBox UserCommentTextBox;
        private System.Windows.Forms.TextBox PriorityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RoundUDAButton;
        private System.Windows.Forms.TextBox RoundToNearestTextBox;
        private System.Windows.Forms.Label FractionalDigitsLabel;
    }
}