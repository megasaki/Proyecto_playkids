using System;

namespace playkidsPresentacion
{
    partial class Logros
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
            this.btnCargarLogros = new System.Windows.Forms.Button();
            this.dataGridViewLogros = new System.Windows.Forms.DataGridView();
            this.pictureBoxArbol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarLogros
            // 
            this.btnCargarLogros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCargarLogros.Location = new System.Drawing.Point(58, 10);
            this.btnCargarLogros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarLogros.Name = "btnCargarLogros";
            this.btnCargarLogros.Size = new System.Drawing.Size(297, 48);
            this.btnCargarLogros.TabIndex = 0;
            this.btnCargarLogros.Text = "Cargar Árbol de Logros";
            this.btnCargarLogros.UseVisualStyleBackColor = true;
            this.btnCargarLogros.Click += new System.EventHandler(this.btnCargarLogros_Click);
            // 
            // dataGridViewLogros
            // 
            this.dataGridViewLogros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogros.Location = new System.Drawing.Point(11, 62);
            this.dataGridViewLogros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLogros.Name = "dataGridViewLogros";
            this.dataGridViewLogros.RowHeadersWidth = 62;
            this.dataGridViewLogros.RowTemplate.Height = 28;
            this.dataGridViewLogros.Size = new System.Drawing.Size(440, 475);
            this.dataGridViewLogros.TabIndex = 1;
            // 
            // pictureBoxArbol
            // 
            this.pictureBoxArbol.Location = new System.Drawing.Point(465, 10);
            this.pictureBoxArbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxArbol.Name = "pictureBoxArbol";
            this.pictureBoxArbol.Size = new System.Drawing.Size(608, 528);
            this.pictureBoxArbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArbol.TabIndex = 2;
            this.pictureBoxArbol.TabStop = false;
            this.pictureBoxArbol.Click += new System.EventHandler(this.pictureBoxArbol_Click);
            // 
            // Logros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 547);
            this.Controls.Add(this.pictureBoxArbol);
            this.Controls.Add(this.dataGridViewLogros);
            this.Controls.Add(this.btnCargarLogros);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Logros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logros";
            this.Load += new System.EventHandler(this.FrmLogros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarLogros;
        private System.Windows.Forms.DataGridView dataGridViewLogros;
        private System.Windows.Forms.PictureBox pictureBoxArbol;

        private void pictureBoxArbol_Click(object sender, EventArgs e)
        {
            // Método requerido por el Diseñador de Visual Studio para el PictureBox
        }

    }
}