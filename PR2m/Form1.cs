using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR2m
{
    public partial class Form1 : Form
    {
        db data = new db();
        int indexDelRow;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("Column1", "Группа");
            dataGridView1.Columns.Add("Column2", "Город");
            dataGridView1.Columns.Add("Column3", "Студенты");

            fillData();
            comboBox1.Items.Add("Абакан");
            
        }
        private void fillData()
        {

            foreach (var i in data.gruppa)
            {
                dataGridView1.Rows.Add(i.Name, i.city, i.CountStuds);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || data.gruppa.Count <= index) return;
            List<stud> studs = data.gruppa[index].studs.ToList();

            dbstuds studs1 = new dbstuds (studs, this);
            studs1.Show();
            this.Hide();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                var newData = data.gruppa.Where(u => u.Name.ToLower().Contains(textBox1.Text.ToLower())).ToList();
                dataGridView1.Rows.Clear();
                foreach (var i in newData)
                {

                    dataGridView1.Rows.Add(i.Name, i.city, i.CountStuds);
                }


            }
            else
            {
                dataGridView1.Rows.Clear();
                foreach (var i in data.gruppa)
                {
                    dataGridView1.Rows.Add(i.Name, i.city, i.CountStuds);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newData = data.gruppa.OrderByDescending(u => u.CountStuds).ToList();
            dataGridView1.Rows.Clear();
            foreach (var i in newData)
            {
                dataGridView1.Rows.Add(i.Name, i.city, i.CountStuds);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.Rows.Clear();
            foreach (var i in data.gruppa)
            {
                dataGridView1.Rows.Add(i.Name, i.city, i.CountStuds);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    var newData = data.gruppa.Where(u => u.city.Contains("Абакан")).ToList();
                    dataGridView1.Rows.Clear();
                    foreach (var i in newData)
                    {

                        dataGridView1.Rows.Add(i.Name, i.city, i.CountStuds);
                    }
                    break;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int indexRows = dataGridView1.CurrentCell.RowIndex;
            int indexColumn = dataGridView1.CurrentCell.ColumnIndex;
            if (indexRows == -1 || data.gruppa.Count <= indexRows) return;


            switch (indexColumn)
            {
                case 0:
                    data.gruppa[indexRows].Name = dataGridView1.Rows[indexRows].Cells[indexColumn].Value.ToString();
                    break;
            }



        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            indexDelRow = e.Row.Index;
            if (indexDelRow == -1) return;
            data.gruppa.RemoveAt(indexDelRow);
        }



        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("", "");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            List<stud> studs = new List<stud>();
            string name = textBox2.Text;
            string city = textBox3.Text;
            data.gruppa.Add(new group(studs, new city(city), name));
            button2_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}

