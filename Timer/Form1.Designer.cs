﻿namespace Timer
{
    partial class frmCronometro
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "00 : 00 : 00";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(28, 151);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(147, 28);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(181, 151);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(147, 28);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(334, 151);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(147, 28);
            this.btnInicializar.TabIndex = 3;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // frmCronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 211);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.label1);
            this.Name = "frmCronometro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnInicializar;
    }
}

