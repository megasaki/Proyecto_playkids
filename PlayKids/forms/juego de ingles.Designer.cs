using System;

namespace PlayKids
{
    partial class juego_de_ingles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(juego_de_ingles));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPalabraEspañol = new System.Windows.Forms.Label();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion3 = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.butregresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPalabraEspañol
            // 
            this.lblPalabraEspañol.AutoSize = true;
            this.lblPalabraEspañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPalabraEspañol.Location = new System.Drawing.Point(51, 154);
            this.lblPalabraEspañol.Name = "lblPalabraEspañol";
            this.lblPalabraEspañol.Size = new System.Drawing.Size(95, 36);
            this.lblPalabraEspañol.TabIndex = 3;
            this.lblPalabraEspañol.Text = "label1";
            this.lblPalabraEspañol.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.Location = new System.Drawing.Point(57, 267);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(100, 46);
            this.btnOpcion1.TabIndex = 4;
            this.btnOpcion1.Text = "button1";
            this.btnOpcion1.UseVisualStyleBackColor = true;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblResultado.Location = new System.Drawing.Point(34, 341);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(95, 36);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label2";
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.Location = new System.Drawing.Point(188, 267);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(105, 46);
            this.btnOpcion2.TabIndex = 6;
            this.btnOpcion2.Text = "button2";
            this.btnOpcion2.UseVisualStyleBackColor = true;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.Location = new System.Drawing.Point(333, 267);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(94, 46);
            this.btnOpcion3.TabIndex = 7;
            this.btnOpcion3.Text = "button3";
            this.btnOpcion3.UseVisualStyleBackColor = true;
            this.btnOpcion3.Click += new System.EventHandler(this.btnOpcion3_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(178, 429);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(106, 47);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPuntaje.Location = new System.Drawing.Point(189, 507);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(95, 36);
            this.lblPuntaje.TabIndex = 9;
            this.lblPuntaje.Text = "label3";
            // 
            // butregresar
            // 
            this.butregresar.Location = new System.Drawing.Point(12, 12);
            this.butregresar.Name = "butregresar";
            this.butregresar.Size = new System.Drawing.Size(85, 35);
            this.butregresar.TabIndex = 10;
            this.butregresar.Text = "regresar";
            this.butregresar.UseVisualStyleBackColor = true;
            this.butregresar.Click += new System.EventHandler(this.butregresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "PlayKidsEdu Company";
            // 
            // juego_de_ingles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 684);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butregresar);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnOpcion3);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.lblPalabraEspañol);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "juego_de_ingles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "juego_de_ingles";
            this.Load += new System.EventHandler(this.juego_de_ingles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void juego_de_ingles_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Juego_de_ingles_Load(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPalabraEspañol;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion3;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Button butregresar;
        private System.Windows.Forms.Label label4;
    }
}