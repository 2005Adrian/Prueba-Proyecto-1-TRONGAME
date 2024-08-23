using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_1_TRONGAME
{
    public partial class Form2 : Form
    {
        private TableroDeJuego tablero;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Crear un tablero de juego de 10x10 celdas
            tablero = new TableroDeJuego(10, 10);

            // Dibujar la cuadrícula del tablero en el formulario
            Invalidate(); // Llama al evento OnPaint para dibujar
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (tablero == null) return;

            Pen pen = new Pen(Color.Black, 2);
            foreach (var nodo in tablero.Matriz)
            {
                // Dibuja cada celda del tablero
                e.Graphics.DrawRectangle(pen, nodo.X * 40, nodo.Y * 40, 40, 40);
            }
        }
    }
}
