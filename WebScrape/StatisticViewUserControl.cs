using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrape.Buisness;

namespace WebScrape
{
    public partial class StatisticViewUserControl : UserControl
    {
        private HashSet<Url> uniqueLinks;

        public StatisticViewUserControl(HashSet<Url> uniqueLinks)
        {
            this.uniqueLinks = uniqueLinks;
            InitializeComponent();
        }

        private void ShowStatisticsButton_Click(object sender, EventArgs e)
        {
            var links = uniqueLinks.ToList();
            var bindingList = new BindingList<Url>(links);
            var source = new BindingSource(bindingList, null);
            statisticDataGridView.DataSource = source;
        }
    
    }
}
