using System;
using System.Windows.Forms;

namespace playkidsPresentacion
{
    partial class AdminReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnProgreso = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(70, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de Control y Reportes Administrativos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBitacora.Location = new System.Drawing.Point(11, 56);
            this.btnBitacora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(256, 75);
            this.btnBitacora.TabIndex = 1;
            this.btnBitacora.Text = "Ver Bitácora de Auditoría";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEstudiantes.Location = new System.Drawing.Point(313, 56);
            this.btnEstudiantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(231, 75);
            this.btnEstudiantes.TabIndex = 2;
            this.btnEstudiantes.Text = "Reporte de Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnProgreso
            // 
            this.btnProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnProgreso.Location = new System.Drawing.Point(573, 56);
            this.btnProgreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProgreso.Name = "btnProgreso";
            this.btnProgreso.Size = new System.Drawing.Size(273, 75);
            this.btnProgreso.TabIndex = 3;
            this.btnProgreso.Text = "Reporte de Progreso Académico";
            this.btnProgreso.UseVisualStyleBackColor = true;
            this.btnProgreso.Click += new System.EventHandler(this.btnProgreso_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsalir.Location = new System.Drawing.Point(772, 356);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(87, 30);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // AdminReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 395);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnProgreso);
            this.Controls.Add(this.btnEstudiantes);
            this.Controls.Add(this.btnBitacora);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
         "¿Estás seguro de que deseas salir?",
         "Confirmar salida",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnProgreso;
        private System.Windows.Forms.Button btnsalir;
    }
}