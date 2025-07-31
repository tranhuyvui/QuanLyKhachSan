using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            LoadFormToPanel(new ThongTinHeThong());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //QLPhong qlp = new QLPhong();
            //qlp.Show();
            LoadFormToPanel(new QLPhong());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //QLNV qlnv = new QLNV();
            //qlnv.Show();
            LoadFormToPanel(new QLNV());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //QLTK qLTK = new QLTK();
            //qLTK.Show();
            LoadFormToPanel(new QLTK());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //QLDV qldv = new QLDV();
            //qldv.Show();
            LoadFormToPanel(new QLDV());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //ThongTinHeThong thongTinHeThong = new ThongTinHeThong();
            //thongTinHeThong.Show();
            LoadFormToPanel(new ThongTinHeThong());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadFormToPanel(Form frm)
        {
            panelContent.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            this.Opacity = 1.0; // 1.0 là 100%

            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            LoadFormToPanel(new ThongTinHeThong());
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new QLPhong());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new QLNV());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new QLTK());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new QLDV());
        }
    }

    
}
