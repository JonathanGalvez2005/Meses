using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configurar la tabla
            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].Name = "MES";
            dataGridView1.Columns[1].Name = "ACUMULADO";

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // Solo se escribe en el número de meses
            textBox1.ReadOnly = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int meses;

            if (!int.TryParse(textBox1.Text, out meses))
            {
                MessageBox.Show("Ingrese un número válido de meses.");
                textBox1.Focus();
                return;
            }

            if (meses <= 0)
            {
                MessageBox.Show("Ingrese un número mayor que 0.");
                textBox1.Focus();
                return;
            }

            // Limpiar tabla antes de generar
            dataGridView1.Rows.Clear();

            int acumulado = 0;

            // Crear tabla de meses acumulados
            for (int mes = 1; mes <= meses; mes++)
            {
                acumulado = acumulado + mes;

                dataGridView1.Rows.Add(mes, acumulado);
            }
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        // BOTÓN CALCULAR
        private void button1_Click_1(object sender, EventArgs e)
        {
            int meses;

            if (!int.TryParse(textBox1.Text, out meses))
            {
                MessageBox.Show("Ingrese un número válido de meses.");
                textBox1.Focus();
                return;
            }

            if (meses <= 0)
            {
                MessageBox.Show("Ingrese un número mayor que 0.");
                textBox1.Focus();
                return;
            }

            // Limpiar tabla antes de generar
            dataGridView1.Rows.Clear();

            int acumulado = 0;

            // Crear tabla de meses acumulados
            for (int mes = 1; mes <= meses; mes++)
            {
                acumulado = acumulado + mes;

                dataGridView1.Rows.Add(mes, acumulado);
            }
        }

        // BOTÓN LIMPIAR
        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.Rows.Clear();

            textBox1.Focus();
        }

        // BOTÓN SALIR
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.Rows.Clear();

            textBox1.Focus();
            
        }
    }
}
