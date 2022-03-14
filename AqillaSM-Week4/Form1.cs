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
    public partial class Form1 : Form
    {
        public DataTable DataTableku = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }


        void AddColumn()
        {
            DataTableku.Columns.Add("Nama");
            DataTableku.Columns.Add("Alamat");
            DataTableku.Columns.Add("Telp");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddColumn();
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            DataTableku.Rows.Add(TextBoxNama.Text, TextBoxAlamat.Text, TextBoxTelp.Text);
            if (DataTableku.Rows.Count >= 11)
            {
                MessageBox.Show("DATA PENUH");
            }
            TextBoxNama.Clear();
            TextBoxAlamat.Clear();
            TextBoxTelp.Clear();
        }

        private void TextBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLihatData_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(DataTableku);
            form2.ShowDialog();
            this.Show();
        }

        private void TextBoxTelp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
