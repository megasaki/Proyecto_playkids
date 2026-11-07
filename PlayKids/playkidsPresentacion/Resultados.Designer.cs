namespace playkidsPresentacion
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
            this.lblAciertos = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAciertos
            // 
            this.lblAciertos.AutoSize = true;
            this.lblAciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblAciertos.Location = new System.Drawing.Point(31, 51);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(93, 33);
            this.lblAciertos.TabIndex = 0;
            this.lblAciertos.Text = "label1";
            this.lblAciertos.Click += new System.EventHandler(this.lblAciertos_Click);
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblErrores.Location = new System.Drawing.Point(31, 104);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(93, 33);
            this.lblErrores.TabIndex = 1;
            this.lblErrores.Text = "label2";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblPuntaje.Location = new System.Drawing.Point(31, 153);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(93, 33);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "label3";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblMensaje.Location = new System.Drawing.Point(31, 206);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(93, 33);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrores);
            this.groupBox1.Controls.Add(this.lblPuntaje);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.btnMenu);
            this.groupBox1.Controls.Add(this.lblAciertos);
            this.groupBox1.Location = new System.Drawing.Point(21, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(396, 352);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "resultados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(110, 283);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(158, 48);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Regresar al menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 547);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenu;
    }
}