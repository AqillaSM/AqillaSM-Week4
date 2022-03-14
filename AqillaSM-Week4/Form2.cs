using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqillaSM_Week4
{
    public partial class Form2 : Form
    {
        DataTable DataTableku = new DataTable();
        int Status = 0;
        public Form2(DataTable table)
        {
            InitializeComponent();
            DataTableku = table;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TextBoxAlamat2.Enabled = false;
            TextBoxTelp2.Enabled = false;
            TextBoxNama2.Enabled = false;

            if (DataTableku.Rows[0][0].ToString() == "" && DataTableku.Rows[0][1].ToString() == "" && DataTableku.Rows[0][2].ToString() == "")
            {
                TextBoxNama2.Text = "<data kosong>";
                TextBoxTelp2.Text = "<data kosong>";
                TextBoxAlamat2.Text = "<data kosong>";
            }
            else
            {
                TextBoxNama2.Text = DataTableku.Rows[0][0].ToString();
                TextBoxAlamat2.Text = DataTableku.Rows[0][1].ToString();
                TextBoxTelp2.Text = DataTableku.Rows[0][2].ToString();
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            Status = Status + 1;
            if (Status == 11)
            {
                MessageBox.Show("Data Sudah Data Terakhir");
                Status = Status - 1;
            }
            else if(Status == DataTableku.Rows.Count)
            {
                MessageBox.Show("Data Sudah Data Terakhir");
                Status = Status - 1;
            }
            else 
            {
                TextBoxNama2.Text = DataTableku.Rows[Status][0].ToString();
                TextBoxAlamat2.Text = DataTableku.Rows[Status][1].ToString();
                TextBoxTelp2.Text = DataTableku.Rows[Status][2].ToString();
            }
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            Status = Status - 1;
            if (Status < 0)
            {
                MessageBox.Show("Data Sudah Data Pertama");
                Status++;
            }
            else
            {   
                TextBoxNama2.Text = DataTableku.Rows[Status][0].ToString();
                TextBoxAlamat2.Text = DataTableku.Rows[Status][1].ToString();
                TextBoxTelp2.Text = DataTableku.Rows[Status][2].ToString();
            }
        }

        private void ButtonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
