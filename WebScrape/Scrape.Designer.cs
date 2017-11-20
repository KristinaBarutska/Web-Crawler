using System.Collections.Generic;
using WebScrape.Buisness;

namespace WebScrape
{
    partial class Scrape
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public static HashSet<Url> uniqueLinks = new HashSet<Url>();

        private TreeViewUserControl treeViewUserControl = new TreeViewUserControl(uniqueLinks);
        private StatisticViewUserControl statisticViewUserControl = new StatisticViewUserControl(uniqueLinks);
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
        public void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
           
            this.splitContainer1.Size = new System.Drawing.Size(1133, 751);
            this.splitContainer1.SplitterDistance = 646;
            this.splitContainer1.TabIndex = 0;
            splitContainer1.Panel1.Controls.Add(treeViewUserControl);
            splitContainer1.Panel2.Controls.Add(statisticViewUserControl);
            treeViewUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            statisticViewUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // 
            // Scrape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 751);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Scrape";
            this.Text = "WebScrape";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer splitContainer1;
    }
}

