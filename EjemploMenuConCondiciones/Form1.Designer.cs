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
            this.btn_salirprograma = new System.Windows.Forms.Button();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).BeginInit();
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
            // btn_salirprograma
            // 
            this.btn_salirprograma.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salirprograma.Location = new System.Drawing.Point(630, 333);
            this.btn_salirprograma.Name = "btn_salirprograma";
            this.btn_salirprograma.Size = new System.Drawing.Size(112, 53);
            this.btn_salirprograma.TabIndex = 4;
            this.btn_salirprograma.Text = "Salir";
            this.btn_salirprograma.UseVisualStyleBackColor = true;
            this.btn_salirprograma.Click += new System.EventHandler(this.btn_salirprograma_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identificar si un numero es positivo o negativo";
            // 
            // pb_2
            // 
            this.pb_2.Image = global::EjemploMenuConCondiciones.Properties.Resources.numb2;
            this.pb_2.Location = new System.Drawing.Point(23, 250);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(119, 104);
            this.pb_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_2.TabIndex = 7;
            this.pb_2.TabStop = false;
            this.pb_2.Click += new System.EventHandler(this.pb_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pb_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_salirprograma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salirprograma;
        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_2;
    }
}

