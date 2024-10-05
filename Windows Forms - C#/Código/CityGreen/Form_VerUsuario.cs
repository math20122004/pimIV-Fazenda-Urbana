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
    public partial class Form_VerUsuario : Form
    {
        private string idUsuario;

        public Form_VerUsuario(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Form_VerUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
