using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cad_map_dotnet
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLoadLines_Click(object sender, EventArgs e)
        {
            DBLoadUtil dbload = new DBLoadUtil();
            string result = dbload.LoadLines();
            lblInfo.Text = result;
        }

        private void btnLoadMText_Click(object sender, EventArgs e)
        {
            DBLoadUtil dbload = new DBLoadUtil();
            string result = dbload.LoadMTexts();
            lblInfo.Text = result;
        }

        private void btnLoadPlines_Click(object sender, EventArgs e)
        {
            DBLoadUtil dbload = new DBLoadUtil();
            string result = dbload.LoadPolylines();
            lblInfo.Text = result;
        }

        private void btnLoadBlocksWithAttributes_Click(object sender, EventArgs e)
        {
            DBLoadUtil dbload = new DBLoadUtil();
            string result = dbload.LoadBlocksWithAttributes();
            lblInfo.Text = result;
        }

        private void btnLoadBlocksWithoutAttributes_Click(object sender, EventArgs e)
        {
            DBLoadUtil dbload = new DBLoadUtil();
            string result = dbload.LoadBlocksWithoutAttributes();
            lblInfo.Text = result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
