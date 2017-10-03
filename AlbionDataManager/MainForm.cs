using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionDataManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var db = new albiondataEntities())
            {
                marketstatsBindingSource.DataSource = db.market_stats.ToList();
                //marketordersBindingSource.DataSource = db.market_orders.Take(100).ToList();
            }
        }
    }
}
