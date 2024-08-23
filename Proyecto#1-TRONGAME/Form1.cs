using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1_TRONGAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            // Crear instancia de Form2
            Form2 form2 = new Form2();

            // Configurar el evento FormClosed de Form2 para reabrir Form1 cuando se cierre Form2
            form2.FormClosed += (s, args) => this.Show();

            // Mostrar Form2 y esconder Form1
            form2.Show();
            this.Hide();
        }
    }
}
