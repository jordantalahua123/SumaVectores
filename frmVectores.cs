using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad1
{
    public partial class frmVectores : Form
    {
        Vector ve1 = new Vector(0,0);
        Vector ve2 = new Vector(0,0);
        Vector ve3 = new Vector(0, 0);
        public frmVectores()
        {
            InitializeComponent();
        }

        private void btnDrawAxis_Click(object sender, EventArgs e)
        {
            ve1.DrawAxis(picCanvas);
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmVectores_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void btnSuma_Click(object sender, EventArgs e)
        {
            //ve3 = ve3.SumaVector(ve1, ve2);
            ve3 = ve1.SumaVector(ve2);
            ve3.imprimirDatos(txtX3, txtY3);
            ve3.DrawVector(picCanvas, txtMagnitud, lblSentido);
            
        }

        private void btnCalcularV2_Click(object sender, EventArgs e)
        {
            ve2.ReadData(txtX2, txtY2);
            ve2.DrawVector(picCanvas, txtMagnitud, lblSentido);
        }

        private void btnDibujarV1_Click(object sender, EventArgs e)
        {
            ve1.ReadData(txtX, txtY);
            ve1.DrawVector(picCanvas, txtMagnitud, lblSentido);
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
