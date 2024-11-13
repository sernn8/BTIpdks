using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTIpdks
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        connection connection = new connection();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var conect = connection.Login(txtKullaniciAdi.Text, txtSifre.Text);
                if (conect)
                {
                    this.Hide();
                    AnaSayfa form2 = new AnaSayfa();
                    form2.Show();                    
                }
                else
                {
                    MessageBox.Show("HATALI GİRİŞ ! " + txtKullaniciAdi.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GİRİŞ SİSTEMİNDE PROBLEM BULUNMAKTADIR ! " + ex.Message);
            }
        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtSifre;
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnGiris.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }
    }
}
