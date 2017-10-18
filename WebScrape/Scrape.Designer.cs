namespace WebScrape
{
    partial class Scrape
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
            this.resaultLabel = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resaultLabel
            // 
            this.resaultLabel.AutoSize = true;
            this.resaultLabel.Location = new System.Drawing.Point(28, 79);
            this.resaultLabel.Name = "resaultLabel";
            this.resaultLabel.Size = new System.Drawing.Size(41, 13);
            this.resaultLabel.TabIndex = 0;
            this.resaultLabel.Text = "[label1]";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(31, 23);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(483, 20);
            this.UrlTextBox.TabIndex = 1;
            this.UrlTextBox.TextChanged += new System.EventHandler(this.UrlTextBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(31, 49);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Scrape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.resaultLabel);
            this.Name = "Scrape";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resaultLabel;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}

