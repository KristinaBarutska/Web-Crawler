namespace WebScrape
{
    partial class StatisticViewUserControl
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
        private void InitializeComponent()
        {
            this.ShowStatisticsButton = new System.Windows.Forms.Button();
            this.statisticDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowStatisticsButton
            // 
            this.ShowStatisticsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowStatisticsButton.Location = new System.Drawing.Point(264, 64);
            this.ShowStatisticsButton.Name = "ShowStatisticsButton";
            this.ShowStatisticsButton.Size = new System.Drawing.Size(119, 23);
            this.ShowStatisticsButton.TabIndex = 12;
            this.ShowStatisticsButton.Text = "Statistics";
            this.ShowStatisticsButton.UseVisualStyleBackColor = true;
            this.ShowStatisticsButton.Click += new System.EventHandler(this.ShowStatisticsButton_Click);
            // 
            // statisticDataGridView
            // 
            this.statisticDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticDataGridView.Location = new System.Drawing.Point(55, 103);
            this.statisticDataGridView.MinimumSize = new System.Drawing.Size(100, 100);
            this.statisticDataGridView.Name = "statisticDataGridView";
            this.statisticDataGridView.Size = new System.Drawing.Size(526, 529);
            this.statisticDataGridView.TabIndex = 11;
            // 
            // StatisticViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowStatisticsButton);
            this.Controls.Add(this.statisticDataGridView);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "StatisticViewUserControl";
            this.Size = new System.Drawing.Size(636, 696);
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ShowStatisticsButton;
        public System.Windows.Forms.DataGridView statisticDataGridView;
    }
}
