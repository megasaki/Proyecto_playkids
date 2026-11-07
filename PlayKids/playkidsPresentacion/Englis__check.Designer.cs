using System;

namespace playkidsPresentacion
{
    partial class Englis__check
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
            this.butiniciar = new System.Windows.Forms.Button();
            this.butcorrecto = new System.Windows.Forms.Button();
            this.butincorrecto = new System.Windows.Forms.Button();
            this.butregresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butiniciar
            // 
            this.butiniciar.Location = new System.Drawing.Point(166, 415);
            this.butiniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butiniciar.Name = "butiniciar";
            this.butiniciar.Size = new System.Drawing.Size(96, 38);
            this.butiniciar.TabIndex = 0;
            this.butiniciar.Text = "button1";
            this.butiniciar.UseVisualStyleBackColor = true;
            this.butiniciar.Click += new System.EventHandler(this.butiniciar_Click_1);
            // 
            // butcorrecto
            // 
            this.butcorrecto.Location = new System.Drawing.Point(31, 199);
            this.butcorrecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butcorrecto.Name = "butcorrecto";
            this.butcorrecto.Size = new System.Drawing.Size(86, 38);
            this.butcorrecto.TabIndex = 1;
            this.butcorrecto.Text = "correcto";
            this.butcorrecto.UseVisualStyleBackColor = true;
            this.butcorrecto.Click += new System.EventHandler(this.butcorrecto_Click_1);
            // 
            // butincorrecto
            // 
            this.butincorrecto.Location = new System.Drawing.Point(156, 199);
            this.butincorrecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butincorrecto.Name = "butincorrecto";
            this.butincorrecto.Size = new System.Drawing.Size(99, 38);
            this.butincorrecto.TabIndex = 2;
            this.butincorrecto.Text = "incorrecto";
            this.butincorrecto.UseVisualStyleBackColor = true;
            this.butincorrecto.Click += new System.EventHandler(this.butincorrecto_Click_1);
            // 
            // butregresar
            // 
            this.butregresar.Location = new System.Drawing.Point(11, 10);
            this.butregresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butregresar.Name = "butregresar";
            this.butregresar.Size = new System.Drawing.Size(83, 30);
            this.butregresar.TabIndex = 3;
            this.butregresar.Text = "regresar";
            this.butregresar.UseVisualStyleBackColor = true;
            this.butregresar.Click += new System.EventHandler(this.butregresar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(26, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butincorrecto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butcorrecto);
            this.groupBox1.Location = new System.Drawing.Point(87, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(274, 252);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Englis__check";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.Location = new System.Drawing.Point(48, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 7;
            // 
            // Englis__check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butregresar);
            this.Controls.Add(this.butiniciar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Englis__check";
            this.Text = "Englis__check";
            this.Load += new System.EventHandler(this.Englis__check_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Englis__check_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button butiniciar;
        private System.Windows.Forms.Button butcorrecto;
        private System.Windows.Forms.Button butincorrecto;
        private System.Windows.Forms.Button butregresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}