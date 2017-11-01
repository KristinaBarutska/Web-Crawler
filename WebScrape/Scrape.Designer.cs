﻿namespace WebScrape
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
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.UrlTreeView = new System.Windows.Forms.TreeView();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.LevelsLabel = new System.Windows.Forms.Label();
            this.levelsTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.statisticDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowStatisticsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(12, 23);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(525, 20);
            this.UrlTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(217, 114);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(127, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // UrlTreeView
            // 
            this.UrlTreeView.Location = new System.Drawing.Point(12, 153);
            this.UrlTreeView.Name = "UrlTreeView";
            this.UrlTreeView.Size = new System.Drawing.Size(560, 529);
            this.UrlTreeView.TabIndex = 3;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(12, 7);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(32, 13);
            this.UrlLabel.TabIndex = 4;
            this.UrlLabel.Text = "URL:";
            // 
            // LevelsLabel
            // 
            this.LevelsLabel.AutoSize = true;
            this.LevelsLabel.Location = new System.Drawing.Point(9, 59);
            this.LevelsLabel.Name = "LevelsLabel";
            this.LevelsLabel.Size = new System.Drawing.Size(130, 13);
            this.LevelsLabel.TabIndex = 5;
            this.LevelsLabel.Text = "Levels (between 1 and 3):";
            // 
            // levelsTextBox
            // 
            this.levelsTextBox.Location = new System.Drawing.Point(12, 78);
            this.levelsTextBox.Name = "levelsTextBox";
            this.levelsTextBox.Size = new System.Drawing.Size(32, 20);
            this.levelsTextBox.TabIndex = 6;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Coral;
            this.errorLabel.Location = new System.Drawing.Point(589, 26);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(59, 13);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "[error label]";
            // 
            // statisticDataGridView
            // 
            this.statisticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticDataGridView.Location = new System.Drawing.Point(592, 153);
            this.statisticDataGridView.Name = "statisticDataGridView";
            this.statisticDataGridView.Size = new System.Drawing.Size(526, 529);
            this.statisticDataGridView.TabIndex = 9;
            // 
            // ShowStatisticsButton
            // 
            this.ShowStatisticsButton.Location = new System.Drawing.Point(801, 114);
            this.ShowStatisticsButton.Name = "ShowStatisticsButton";
            this.ShowStatisticsButton.Size = new System.Drawing.Size(119, 23);
            this.ShowStatisticsButton.TabIndex = 10;
            this.ShowStatisticsButton.Text = "Statistics";
            this.ShowStatisticsButton.UseVisualStyleBackColor = true;
            this.ShowStatisticsButton.Click += new System.EventHandler(this.ShowStatisticsButton_Click);
            // 
            // Scrape
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 751);
            this.Controls.Add(this.ShowStatisticsButton);
            this.Controls.Add(this.statisticDataGridView);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.levelsTextBox);
            this.Controls.Add(this.LevelsLabel);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.UrlTreeView);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.UrlTextBox);
            this.Name = "Scrape";
            this.Text = "WebScrape";
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TreeView UrlTreeView;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.Label LevelsLabel;
        private System.Windows.Forms.TextBox levelsTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView statisticDataGridView;
        private System.Windows.Forms.Button ShowStatisticsButton;
    }
}

