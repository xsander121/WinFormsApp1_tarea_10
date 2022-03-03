using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_tarea_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_generar_matriz_id_nxn_Click(object sender, EventArgs e)
        {
            if (bttn_generar_matriz_id_nxn.Text.Equals("Generar matriz identidad nxn"))
            {
                if (!txtBx_entrada.Text.Equals(""))
                {
                    txtBx_entrada.Enabled = false;
                    bttn_generar_matriz_id_nxn.Text = "Generando..";
                    bttn_generar_matriz_id_nxn.Enabled = false;

                    int tamaño = int.Parse(txtBx_entrada.Text);
                    generar(tamaño);

                    bttn_generar_matriz_id_nxn.Enabled = true;
                    bttn_generar_matriz_id_nxn.Text = "Clear";
                }
            }
            else {
                txtBx_entrada.Enabled = true;
                txtBx_entrada.Text = "";
                txtBx_salida.Text = "";

                bttn_generar_matriz_id_nxn.Enabled = true;
                bttn_generar_matriz_id_nxn.Text = "Generar matriz identidad nxn";
            }
        }

        private void generar(int tamaño) {
            for (int fila = 0; fila < tamaño; fila++) {
                generar_fila(fila, tamaño);
            }
        }

        private void generar_fila(int fila, int tamaño) {
            for (int columna = 0; columna < tamaño; columna++)
            {
                if (columna == fila)
                    txtBx_salida.AppendText("1 ");
                else
                    txtBx_salida.AppendText("0 ");
            }
            if (fila < tamaño-1)
                txtBx_salida.AppendText("\r\n");
        }

        private void txtBx_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de entrada solo puede recibir numeros.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtBx_salida_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de salida no puede recibir valores.
            if (e.KeyChar >= 0 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
    }
}
