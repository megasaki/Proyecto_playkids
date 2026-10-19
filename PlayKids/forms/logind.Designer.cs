namespace PlayKids
{
    partial class logind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logind));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butIniciar = new System.Windows.Forms.Button();
            this.textContra = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PlayKids.Properties.Resources.Imagen_de_WhatsApp_2025_09_25_a_las_20_40_13_ed6083fd;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(155, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido a ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(189, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Playkids";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butIniciar);
            this.groupBox1.Controls.Add(this.textContra);
            this.groupBox1.Controls.Add(this.textCorreo);
            this.groupBox1.Location = new System.Drawing.Point(48, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 346);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar sesion";
            // 
            // butIniciar
            // 
            this.butIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butIniciar.Location = new System.Drawing.Point(114, 273);
            this.butIniciar.Name = "butIniciar";
            this.butIniciar.Size = new System.Drawing.Size(119, 49);
            this.butIniciar.TabIndex = 2;
            this.butIniciar.Text = "iniciar";
            this.butIniciar.UseVisualStyleBackColor = true;
            this.butIniciar.Click += new System.EventHandler(this.butIniciar_Click);
            // 
            // textContra
            // 
            this.textContra.Location = new System.Drawing.Point(75, 187);
            this.textContra.Multiline = true;
            this.textContra.Name = "textContra";
            this.textContra.PasswordChar = '*';
            this.textContra.Size = new System.Drawing.Size(227, 56);
            this.textContra.TabIndex = 1;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(75, 70);
            this.textCorreo.Multiline = true;
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(227, 62);
            this.textCorreo.TabIndex = 0;
            this.textCorreo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // logind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 684);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logind";
            this.Load += new System.EventHandler(this.logind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butIniciar;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.TextBox textCorreo;
    }
}