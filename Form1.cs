using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrirCSV
{
    public partial class AbreCSV : Form
    {
        public AbreCSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string[] Linha = System.IO.File.ReadAllLines(@"C:\Teste\teste.csv");

            for (Int32 i = 0; i < Linha.Length; i++)
            {
                string[] campos = Linha[i].Split(Convert.ToChar(";"));

                if (i == 0)
                {
                    for (Int32 i2 = 0; i2 < campos.Length; i2++)
                    {
                        DataColumn col = new DataColumn();
                        dt.Columns.Add(col);
                    }
                }
                dt.Rows.Add(campos);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
