using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAEd1
{
    public partial class pedidoErrado : Form
    {

        public pedidoErrado()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
