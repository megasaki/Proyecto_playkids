using System;
using System.Windows.Forms;

namespace playkidsPresentacion
{
    partial class Menu
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
            this.btnJuegoVF = new System.Windows.Forms.Button();
            this.btnJuegoOpciones = new System.Windows.Forms.Button();
            this.btnTrofeos = new System.Windows.Forms.Button();
            this.butregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJuegoVF
            // 
            this.btnJuegoVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnJuegoVF.Location = new System.Drawing.Point(152, 189);
            this.btnJuegoVF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJuegoVF.Name = "btnJuegoVF";
            this.btnJuegoVF.Size = new System.Drawing.Size(142, 41);
            this.btnJuegoVF.TabIndex = 1;
            this.btnJuegoVF.Text = "Englis__check";
            this.btnJuegoVF.UseVisualStyleBackColor = true;
            this.btnJuegoVF.Click += new System.EventHandler(this.btnJuegoVF_Click_1);
            // 
            // btnJuegoOpciones
            // 
            this.btnJuegoOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnJuegoOpciones.Location = new System.Drawing.Point(152, 270);
            this.btnJuegoOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJuegoOpciones.Name = "btnJuegoOpciones";
            this.btnJuegoOpciones.Size = new System.Drawing.Size(142, 41);
            this.btnJuegoOpciones.TabIndex = 2;
            this.btnJuegoOpciones.Text = "juego_de_ingles";
            this.btnJuegoOpciones.UseVisualStyleBackColor = true;
            this.btnJuegoOpciones.Click += new System.EventHandler(this.btnJuegoOpciones_Click_1);
            // 
            // btnTrofeos
            // 
            this.btnTrofeos.Location = new System.Drawing.Point(152, 346);
            this.btnTrofeos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrofeos.Name = "btnTrofeos";
            this.btnTrofeos.Size = new System.Drawing.Size(142, 42);
            this.btnTrofeos.TabIndex = 3;
            this.btnTrofeos.Text = "button1";
            this.btnTrofeos.UseVisualStyleBackColor = true;
            this.btnTrofeos.Click += new System.EventHandler(this.btnTrofeos_Click_1);
            // 
            // butregresar
            // 
            this.butregresar.Location = new System.Drawing.Point(11, 10);
            this.butregresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butregresar.Name = "butregresar";
            this.butregresar.Size = new System.Drawing.Size(87, 31);
            this.butregresar.TabIndex = 4;
            this.butregresar.Text = "Exit";
            this.butregresar.UseVisualStyleBackColor = true;
            this.butregresar.Click += new System.EventHandler(this.butregresar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 547);
            this.Controls.Add(this.butregresar);
            this.Controls.Add(this.btnTrofeos);
            this.Controls.Add(this.btnJuegoOpciones);
            this.Controls.Add(this.btnJuegoVF);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

      
        #endregion
        private System.Windows.Forms.Button btnJuegoVF;
        private System.Windows.Forms.Button btnJuegoOpciones;
        private System.Windows.Forms.Button btnTrofeos;
        private EventHandler butSalir_Click;
        private Button butregresar;
    }
}