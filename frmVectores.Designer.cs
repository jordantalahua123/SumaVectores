namespace actividad1
{
    partial class frmVectores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDrawAxis = new System.Windows.Forms.Button();
            this.Graficos = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSentido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDibujarV1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcularV2 = new System.Windows.Forms.Button();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtY3 = new System.Windows.Forms.TextBox();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.Graficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDrawAxis
            // 
            this.btnDrawAxis.Location = new System.Drawing.Point(45, 27);
            this.btnDrawAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDrawAxis.Name = "btnDrawAxis";
            this.btnDrawAxis.Size = new System.Drawing.Size(119, 23);
            this.btnDrawAxis.TabIndex = 0;
            this.btnDrawAxis.Text = "Dibujar Ejes";
            this.btnDrawAxis.UseVisualStyleBackColor = true;
            this.btnDrawAxis.Click += new System.EventHandler(this.btnDrawAxis_Click);
            // 
            // Graficos
            // 
            this.Graficos.Controls.Add(this.picCanvas);
            this.Graficos.Location = new System.Drawing.Point(507, 174);
            this.Graficos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Graficos.Name = "Graficos";
            this.Graficos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Graficos.Size = new System.Drawing.Size(531, 530);
            this.Graficos.TabIndex = 1;
            this.Graficos.TabStop = false;
            this.Graficos.Text = "Graficos";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(5, 14);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(520, 512);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.lblSentido);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMagnitud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDibujarV1);
            this.groupBox1.Location = new System.Drawing.Point(45, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(240, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VECTOR 1";
            this.groupBox1.UseWaitCursor = true;
            // 
            // lblSentido
            // 
            this.lblSentido.AutoSize = true;
            this.lblSentido.Location = new System.Drawing.Point(87, 119);
            this.lblSentido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSentido.Name = "lblSentido";
            this.lblSentido.Size = new System.Drawing.Size(0, 16);
            this.lblSentido.TabIndex = 11;
            this.lblSentido.UseWaitCursor = true;
            this.lblSentido.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sentido :";
            this.label4.UseWaitCursor = true;
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.Enabled = false;
            this.txtMagnitud.Location = new System.Drawing.Point(91, 84);
            this.txtMagnitud.Margin = new System.Windows.Forms.Padding(4);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.Size = new System.Drawing.Size(132, 22);
            this.txtMagnitud.TabIndex = 3;
            this.txtMagnitud.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Magnitud: ";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(60, 52);
            this.txtY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 8;
            this.txtY.Text = "4";
            this.txtY.UseWaitCursor = true;
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(60, 22);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 7;
            this.txtX.Text = "3";
            this.txtX.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y: ";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "X :";
            this.label1.UseWaitCursor = true;
            // 
            // btnDibujarV1
            // 
            this.btnDibujarV1.Location = new System.Drawing.Point(11, 190);
            this.btnDibujarV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDibujarV1.Name = "btnDibujarV1";
            this.btnDibujarV1.Size = new System.Drawing.Size(75, 23);
            this.btnDibujarV1.TabIndex = 4;
            this.btnDibujarV1.Text = "Calcular";
            this.btnDibujarV1.UseVisualStyleBackColor = true;
            this.btnDibujarV1.UseWaitCursor = true;
            this.btnDibujarV1.Click += new System.EventHandler(this.btnDibujarV1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox2.Controls.Add(this.btnCalcularV2);
            this.groupBox2.Controls.Add(this.txtY2);
            this.groupBox2.Controls.Add(this.txtX2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(45, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 218);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VECTOR 2";
            // 
            // btnCalcularV2
            // 
            this.btnCalcularV2.Location = new System.Drawing.Point(14, 170);
            this.btnCalcularV2.Name = "btnCalcularV2";
            this.btnCalcularV2.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularV2.TabIndex = 4;
            this.btnCalcularV2.Text = "Calcular";
            this.btnCalcularV2.UseVisualStyleBackColor = true;
            this.btnCalcularV2.Click += new System.EventHandler(this.btnCalcularV2_Click);
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(43, 54);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 22);
            this.txtY2.TabIndex = 3;
            this.txtY2.Text = "5";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(42, 22);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 22);
            this.txtX2.TabIndex = 2;
            this.txtX2.Text = "-2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "X:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox3.Controls.Add(this.btnSuma);
            this.groupBox3.Controls.Add(this.txtY3);
            this.groupBox3.Controls.Add(this.txtX3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(45, 592);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 218);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VECTOR 3";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(14, 170);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtY3
            // 
            this.txtY3.Location = new System.Drawing.Point(43, 54);
            this.txtY3.Name = "txtY3";
            this.txtY3.Size = new System.Drawing.Size(100, 22);
            this.txtY3.TabIndex = 3;
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(42, 22);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(100, 22);
            this.txtX3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 722);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Pos X: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 722);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Pos Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(563, 722);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 16);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "0";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(734, 722);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 16);
            this.lblY.TabIndex = 9;
            this.lblY.Text = "0";
            // 
            // frmVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1277, 891);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Graficos);
            this.Controls.Add(this.btnDrawAxis);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVectores";
            this.Text = "Manejo de Vectores";
            this.Load += new System.EventHandler(this.frmVectores_Load);
            this.Graficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrawAxis;
        private System.Windows.Forms.GroupBox Graficos;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDibujarV1;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMagnitud;
        private System.Windows.Forms.Label lblSentido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcularV2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtY3;
        private System.Windows.Forms.TextBox txtX3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
    }
}

