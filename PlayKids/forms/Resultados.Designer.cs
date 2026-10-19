using System;
using System.Windows.Forms;

namespace PlayKids.Clases
{
    partial class Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAciertos = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAciertos
            // 
            this.lblAciertos.AutoSize = true;
            this.lblAciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblAciertos.Location = new System.Drawing.Point(87, 301);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(175, 39);
            this.lblAciertos.TabIndex = 2;
            this.lblAciertos.Text = "lblAciertos";
            this.lblAciertos.Click += new System.EventHandler(this.lblAciertos_Click);
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblErrores.Location = new System.Drawing.Point(87, 242);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(163, 39);
            this.lblErrores.TabIndex = 3;
            this.lblErrores.Text = "lblErrores";
            this.lblErrores.Click += new System.EventHandler(this.lblErrores_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblPuntaje.Location = new System.Drawing.Point(87, 178);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(168, 39);
            this.lblPuntaje.TabIndex = 4;
            this.lblPuntaje.Text = "lblPuntaje";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblMensaje.Location = new System.Drawing.Point(87, 365);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(181, 39);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "lblMensaje";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(154, 484);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(136, 58);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Regresar al Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "PlayKidsEdu Company";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 684);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lblAciertos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblErrores_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (menu != null)
                menu.Show();
            else
                MessageBox.Show("menu es NULL 💀");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnMenu;
        private Label label4;
    }
}