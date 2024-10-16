using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityGreen
{
    public partial class Form_VerInsumo : Form
    {
        private string Id_Insumo;

        public Form_VerInsumo(string Id_Insumo)
        {
            this.Id_Insumo = Id_Insumo;
            InitializeComponent();
        }

        private void Form_VerInsumo_Load(object sender, EventArgs e)
        {

        }
    }
}
