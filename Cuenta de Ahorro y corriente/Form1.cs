using Cuenta_de_Ahorro_y_corriente.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta_de_Ahorro_y_corriente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        csAhorro ahorro;
        csCorriente corriente;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAhorro_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            ahorro = new csAhorro(Int32.Parse(txtAho.Text));
            if (Int32.Parse(txtAho.Text) < 150)
            {
                MessageBox.Show("Minimo de $150 apara la apertura");
            }
            else
            {
                btnAhorro.Enabled = false;
                fila.CreateCells(dataGridView1);
                fila.Cells[0].Value = "Cta.Ahorro";
                fila.Cells[1].Value = "Apertura";
                fila.Cells[2].Value = txtAho.Text;
                fila.Cells[3].Value = ahorro.difeA(Int32.Parse(txtAho.Text));
                dataGridView1.Rows.Add(fila);
            }

        }

        private void btnCorriente_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            corriente = new csCorriente(Int32.Parse(txtCorr.Text));
            if (Int32.Parse(txtCorr.Text) < 150)
            {
                MessageBox.Show("Minimo de $150 apara la apertura");
            }
            else
            {
                btnCorriente.Enabled = false;
                fila.CreateCells(dataGridView1);
                fila.Cells[0].Value = "Cta.Corriente";
                fila.Cells[1].Value = "Apertura";
                fila.Cells[2].Value = txtCorr.Text;
                fila.Cells[3].Value = corriente.difeCo(Int32.Parse(txtCorr.Text));

                dataGridView1.Rows.Add(fila);
            }

        }

        private void btnDepAhorro_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Cta.Ahorro";
            fila.Cells[1].Value = "Deposito";
            fila.Cells[2].Value = txtDAho.Text;
            int re = ahorro.realizarDepositoA(Int32.Parse(txtDAho.Text));
            fila.Cells[3].Value = ahorro.difeA(re); ;
            dataGridView1.Rows.Add(fila);
            txtDAho.Text = "";
        }

        private void btnDepCorriente_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            btnCorriente.Enabled = false;
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Cta.Corriente";
            fila.Cells[1].Value = "Deposito";
            fila.Cells[2].Value = txtDCorr.Text;
            int re = corriente.realizarDepositoC(Int32.Parse(txtDCorr.Text));
            fila.Cells[3].Value = corriente.difeCo(re);

            dataGridView1.Rows.Add(fila);
            txtDCorr.Text = "";
        }

        private void btnReAhorro_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            //csAhorro ahorro = new csAhorro(Int32.Parse(txtAho.Text));

            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Cta.Ahorro";
            fila.Cells[1].Value = "Retiro";
            fila.Cells[2].Value = txtRAh.Text;
            int re = ahorro.realizarRetiroA(Int32.Parse(txtRAh.Text));
            fila.Cells[3].Value = ahorro.difeA(re);
            dataGridView1.Rows.Add(fila);
            txtRAh.Text = "";
        }

        private void btnReCorriente_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            btnCorriente.Enabled = false;
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Cta.Corriente";
            fila.Cells[1].Value = "Retiro";
            fila.Cells[2].Value = txtRCo.Text;
            int re = corriente.realizarRetiroC(Int32.Parse(txtRCo.Text));
            fila.Cells[3].Value = corriente.difeCo(re);

            dataGridView1.Rows.Add(fila);
            txtRCo.Text = "";
        }
    }
}
