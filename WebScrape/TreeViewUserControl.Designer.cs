namespace WebScrape
{
    public partial class TreeViewUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.errorLabel = new System.Windows.Forms.Label();
            this.levelsTextBox = new System.Windows.Forms.TextBox();
            this.LevelsLabel = new System.Windows.Forms.Label();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.UrlTreeView = new System.Windows.Forms.TreeView();
            this.submitButton = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Coral;
            this.errorLabel.Location = new System.Drawing.Point(68, 15);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
            // 
            // levelsTextBox
            // 
            this.levelsTextBox.Location = new System.Drawing.Point(21, 107);
            this.levelsTextBox.Name = "levelsTextBox";
            this.levelsTextBox.Size = new System.Drawing.Size(32, 20);
            this.levelsTextBox.TabIndex = 13;
            // 
            // LevelsLabel
            // 
            this.LevelsLabel.AutoSize = true;
            this.LevelsLabel.Location = new System.Drawing.Point(18, 77);
            this.LevelsLabel.Name = "LevelsLabel";
            this.LevelsLabel.Size = new System.Drawing.Size(130, 13);
            this.LevelsLabel.TabIndex = 12;
            this.LevelsLabel.Text = "Levels (between 1 and 3):";
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(18, 15);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(32, 13);
            this.UrlLabel.TabIndex = 11;
            this.UrlLabel.Text = "URL:";
            // 
            // UrlTreeView
            // 
            this.UrlTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTreeView.CausesValidation = false;
            this.UrlTreeView.Location = new System.Drawing.Point(21, 146);
            this.UrlTreeView.MinimumSize = new System.Drawing.Size(100, 100);
            this.UrlTreeView.Name = "UrlTreeView";
            this.UrlTreeView.Size = new System.Drawing.Size(560, 475);
            this.UrlTreeView.TabIndex = 10;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(454, 104);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(127, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTextBox.Location = new System.Drawing.Point(21, 39);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(560, 20);
            this.UrlTextBox.TabIndex = 8;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBar.Location = new System.Drawing.Point(21, 647);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(560, 23);
            this.ProgressBar.TabIndex = 15;
            // 
            // TreeViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.levelsTextBox);
            this.Controls.Add(this.LevelsLabel);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.UrlTreeView);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.UrlTextBox);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "TreeViewUserControl";
            this.Size = new System.Drawing.Size(608, 702);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label errorLabel;
        public System.Windows.Forms.TextBox levelsTextBox;
        public System.Windows.Forms.Label LevelsLabel;
        public System.Windows.Forms.Label UrlLabel;
        public System.Windows.Forms.TreeView UrlTreeView;
        public System.Windows.Forms.Button submitButton;
        public System.Windows.Forms.TextBox UrlTextBox;
        public System.Windows.Forms.ProgressBar ProgressBar;
    }
}
