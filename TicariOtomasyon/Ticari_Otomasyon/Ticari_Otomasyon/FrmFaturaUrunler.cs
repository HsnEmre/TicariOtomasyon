using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmFaturaUrunler : Form
    {
        public FrmFaturaUrunler()
        {
            InitializeComponent();
        }
        public string id;

        private void FrmFaturaUrunler_Load(object sender, EventArgs e)
        {
            label1.Text = id;
        }
    }
}
