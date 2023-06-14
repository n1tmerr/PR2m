using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2m
{
    partial class dbstuds : Form
    {
        private DataGridView dataGridView1;
        Form1 f1;
        public dbstuds(List<stud> studs, Form1 f)
        {

            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            f1 = f;
            dataGridView1.Columns.Add("Column1", "Имя");
            dataGridView1.Columns.Add("Column2", "Родитель");
            dataGridView1.Columns.Add("Column3", "Возраст");
            try
            {
                foreach (var i in studs)
                {
                    dataGridView1.Rows.Add(i.Name, i.Parent, i.Age);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void dbstuds_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();

        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbstuds
            // 
            this.ClientSize = new System.Drawing.Size(576, 325);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dbstuds";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
