namespace EjemploMenuConCondiciones
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.btn_salirprograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu de Opciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identificar el numero mayor  de 2 numeros";
            // 
            // pb_1
            // 
            this.pb_1.Image = global::EjemploMenuConCondiciones.Properties.Resources.Captura;
            this.pb_1.Location = new System.Drawing.Point(23, 101);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(119, 117);
            this.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_1.TabIndex = 2;
            this.pb_1.TabStop = false;
            this.pb_1.Click += new System.EventHandler(this.pb_1_Click);
            // 
            // btn_salirprograma
            // 
            this.btn_salirprograma.Location = new System.Drawing.Point(362, 270);
            this.btn_salirprograma.Name = "btn_salirprograma";
            this.btn_salirprograma.Size = new System.Drawing.Size(94, 36);
            this.btn_salirprograma.TabIndex = 4;
            this.btn_salirprograma.Text = "Salir";
            this.btn_salirprograma.UseVisualStyleBackColor = true;
            this.btn_salirprograma.Click += new System.EventHandler(this.btn_salirprograma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salirprograma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salirprograma;
    }
}

