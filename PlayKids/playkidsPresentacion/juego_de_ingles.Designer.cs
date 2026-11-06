namespace playkidsPresentacion
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion3 = new System.Windows.Forms.Button();
            this.butregresar = new System.Windows.Forms.Button();
            this.lblPalabraEspañol = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(179, 445);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(106, 36);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.Location = new System.Drawing.Point(98, 245);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(89, 34);
            this.btnOpcion1.TabIndex = 1;
            this.btnOpcion1.Text = "button2";
            this.btnOpcion1.UseVisualStyleBackColor = true;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.Location = new System.Drawing.Point(238, 245);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(75, 34);
            this.btnOpcion2.TabIndex = 2;
            this.btnOpcion2.Text = "button3";
            this.btnOpcion2.UseVisualStyleBackColor = true;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.Location = new System.Drawing.Point(367, 245);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(83, 34);
            this.btnOpcion3.TabIndex = 3;
            this.btnOpcion3.Text = "button4";
            this.btnOpcion3.UseVisualStyleBackColor = true;
            this.btnOpcion3.Click += new System.EventHandler(this.btnOpcion3_Click);
            // 
            // butregresar
            // 
            this.butregresar.Location = new System.Drawing.Point(12, 12);
            this.butregresar.Name = "butregresar";
            this.butregresar.Size = new System.Drawing.Size(94, 39);
            this.butregresar.TabIndex = 4;
            this.butregresar.Text = "button5";
            this.butregresar.UseVisualStyleBackColor = true;
            this.butregresar.Click += new System.EventHandler(this.butregresar_Click);
            // 
            // lblPalabraEspañol
            // 
            this.lblPalabraEspañol.AutoSize = true;
            this.lblPalabraEspañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPalabraEspañol.Location = new System.Drawing.Point(111, 143);
            this.lblPalabraEspañol.Name = "lblPalabraEspañol";
            this.lblPalabraEspañol.Size = new System.Drawing.Size(95, 36);
            this.lblPalabraEspañol.TabIndex = 5;
            this.lblPalabraEspañol.Text = "label1";
            this.lblPalabraEspañol.Click += new System.EventHandler(this.lblPalabraEspañol_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPuntaje.Location = new System.Drawing.Point(111, 329);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(95, 36);
            this.lblPuntaje.TabIndex = 6;
            this.lblPuntaje.Text = "label2";
            this.lblPuntaje.Click += new System.EventHandler(this.lblPuntaje_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new System.Drawing.Point(206, 514);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(79, 29);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "label3";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // juego_de_ingles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 684);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblPalabraEspañol);
            this.Controls.Add(this.butregresar);
            this.Controls.Add(this.btnOpcion3);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "juego_de_ingles";
            this.Text = "juego_de_ingles";
            this.Load += new System.EventHandler(this.juego_de_ingles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion3;
        private System.Windows.Forms.Button butregresar;
        private System.Windows.Forms.Label lblPalabraEspañol;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblResultado;
    }
}