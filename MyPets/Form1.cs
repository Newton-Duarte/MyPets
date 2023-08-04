using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPets
{
    public partial class MyPets : Form
    {
        public MyPets()
        {
            InitializeComponent();
        }

        private void buscarPetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var buscarPets = new BuscarPets();
            buscarPets.Show();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var meusFavoritos = new MeusFavoritos();
            meusFavoritos.Show();
        }
    }
}
