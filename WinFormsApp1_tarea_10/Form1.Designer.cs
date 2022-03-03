
namespace WinFormsApp1_tarea_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_entrada = new System.Windows.Forms.TextBox();
            this.bttn_generar_matriz_id_nxn = new System.Windows.Forms.Button();
            this.txtBx_salida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese tamaño de la matriz";
            // 
            // txtBx_entrada
            // 
            this.txtBx_entrada.Location = new System.Drawing.Point(72, 61);
            this.txtBx_entrada.Name = "txtBx_entrada";
            this.txtBx_entrada.Size = new System.Drawing.Size(252, 27);
            this.txtBx_entrada.TabIndex = 1;
            this.txtBx_entrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_entrada_KeyPress);
            // 
            // bttn_generar_matriz_id_nxn
            // 
            this.bttn_generar_matriz_id_nxn.Location = new System.Drawing.Point(330, 38);
            this.bttn_generar_matriz_id_nxn.Name = "bttn_generar_matriz_id_nxn";
            this.bttn_generar_matriz_id_nxn.Size = new System.Drawing.Size(182, 51);
            this.bttn_generar_matriz_id_nxn.TabIndex = 2;
            this.bttn_generar_matriz_id_nxn.Text = "Generar matriz identidad nxn";
            this.bttn_generar_matriz_id_nxn.UseVisualStyleBackColor = true;
            this.bttn_generar_matriz_id_nxn.Click += new System.EventHandler(this.bttn_generar_matriz_id_nxn_Click);
            // 
            // txtBx_salida
            // 
            this.txtBx_salida.Location = new System.Drawing.Point(72, 94);
            this.txtBx_salida.Multiline = true;
            this.txtBx_salida.Name = "txtBx_salida";
            this.txtBx_salida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBx_salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_salida.Size = new System.Drawing.Size(440, 256);
            this.txtBx_salida.TabIndex = 3;
            this.txtBx_salida.WordWrap = false;
            this.txtBx_salida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_salida_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBx_salida);
            this.Controls.Add(this.bttn_generar_matriz_id_nxn);
            this.Controls.Add(this.txtBx_entrada);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_entrada;
        private System.Windows.Forms.Button bttn_generar_matriz_id_nxn;
        private System.Windows.Forms.TextBox txtBx_salida;
    }
}

