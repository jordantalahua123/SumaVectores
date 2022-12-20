using System;
using System.Collections.Generic;
using System.Drawing; // manejo de enternos de dibujo 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //manejo de los formularios
using System.Drawing.Drawing2D; //manejo de entornos 2D
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace actividad1
{
    internal class Vector
    {
        //atributos 

        private float mX,mY;
        private float mcX,mcY;

        //maximo de la pantalla
        private float mWidth, mHeight;

        //definir una constate
        const int Escala = 10;

        //control de setter y getters 
        public float X { get => mX; set => mX = value;}
        public float Y { get => mY; set => mY = value; }


        //controles de graficos 
        private Graphics mGraph;
        //definir un lapiz
        Pen mPen;

        //constructor
        public Vector(float mX, float mY)
        {
            this.mX = mX;
            this.mY = mY;
        }
        public Vector()
        {
            this.mX = 0;
            this.mY = 0;
        }


        //metodos
        
        public void DrawAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen (Color.Black, 2);
            mWidth = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidth / 2;
            mcY = mHeight / 2;
            //linea horizontal
            mGraph.DrawLine(mPen, 0, mcY, mWidth, mcY);
            //vertical
            mGraph.DrawLine(mPen, mcX, 0, mcX, mHeight);
        }


        public void ReadData(TextBox txtX, TextBox txtY)
        {
            //Convertir 
            mX = float.Parse(txtX.Text);
            mY = float.Parse(txtY.Text);
        }
        public void DrawVector(PictureBox picCanvas, TextBox txtMagnitud, Label lblSentido)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkRed, 4);
            //Configuracion del lapiz
            mPen.StartCap = LineCap.RoundAnchor;
            mPen.EndCap = LineCap.ArrowAnchor;
            mWidth = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidth / 2;
            mcY = mHeight / 2;
            float mFx = (mcX + mX * Escala) ;
            float mFy = (mcY - mY * Escala);
            //dibujar vector

            mGraph.DrawLine(mPen, mcX, mcY, mFx, mFy );

            //1. mostrar la magnitud con caja de texto
            float mag = CalMagnitud(mX, mY);
            //MessageBox.Show(mag.ToString(), "Magnitud");
            //2. mostrar la magnitud en un textbox
            txtMagnitud.Text = mag.ToString();
            //3. mostrar directamente en el Picture
            Font txtFondo = new Font("Arial", 12);
            SolidBrush txtBrush = new SolidBrush(Color.Red);
            mGraph.DrawString(mag.ToString(), txtFondo, txtBrush,mFx, mFy);
            //Mostrar sentido del vector 
            int sentido;
            sentido =  CalcularSentido(mX, mY);
            lblSentido.Text = "Cuadrante " + sentido.ToString();
            lblSentido.Visible = true;  


            float dir = CalDireccion(mY, mag);

        }
        public float CalMagnitud (float mFx, float mFy)
        {
            double mag = Math.Sqrt(Math.Pow(mFx,2) + Math.Pow(mFy,2));
            return (float) mag;
        }
        public int CalcularSentido(float mFx, float mFy)
        {
            if ((mFx > 0) && (mFy > 0))
            {
                return 1;
            }
            else if ((mFx < 0) && (mFy > 0))
            {
                return 2;
            }
            else if ((mFx < 0) && (mFy < 0))
            {
                return 3;
            }
            else return 4;
        }
        public float CalDireccion(float mCOpues, float mHipote)
        {
            double valDir = (mCOpues / mHipote);
            //transformar a radianes 
            double angulo = Math.Asin(valDir) * (180 / Math.PI);
            MessageBox.Show("Angulo es : " + angulo.ToString());
            return (float)angulo;

        }

        /*public Vector SumaVector(Vector vecA , Vector vecB)
        {
            Vector vecC = new Vector();

            vecC.mX = vecA.mX + vecB.mX;
            vecC.mY = vecA.mY + vecB.mY;
            return vecC;
        }*/

        /*public Vector SumaVector(Vector vecB)
        {
            Vector vecC = new Vector();
            vecC.mX = mX + vecB.X;
            vecC.mY = mY + vecB.Y;
            return vecC;
        }*/

        public Vector SumaVector(Vector vecB)
        {
            return (new Vector(mX + vecB.mX, mY + vecB.mY));
        }

        public void imprimirDatos(TextBox txtX3, TextBox txtY3)
        {
            txtX3.Text = mX.ToString();
            txtY3.Text = mY.ToString();     
        }

    }
}
