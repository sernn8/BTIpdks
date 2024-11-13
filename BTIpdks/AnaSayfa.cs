using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTIpdks
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            PanelMenuAyarlari();
        }
        private void PanelMenuAyarlari()
        {
            panelPersonel.Visible = false;
            panelDepartman.Visible = false;
        }
        private void MenuAyari()
        {
            if (panelPersonel.Visible == true)
                panelPersonel.Visible = false;
            if (panelDepartman.Visible == true)
                panelDepartman.Visible = false;
        }
        private void MenuKontrol(Panel menu)
        {
            if (menu.Visible == false)
            {
                MenuAyari();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            MenuKontrol(panelPersonel);

        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            MenuAyari();
            PanelKontrolleri();
            PersonelEkle personel = new PersonelEkle();
            personel.AutoScroll = false;
            personel.TopLevel = false;
            personel.Dock = DockStyle.Fill;
            personel.FormBorderStyle = FormBorderStyle.None;
            panelAna.Controls.Add(personel);
            personel.Show();
            Text = "Personel Ekle";
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            MenuAyari();
            PanelKontrolleri();
            PersonelGuncelle guncelle = new PersonelGuncelle();
            guncelle.AutoScroll = false;
            guncelle.TopLevel = false;
            guncelle.Dock = DockStyle.Fill;
            guncelle.FormBorderStyle = FormBorderStyle.None;
            panelAna.Controls.Add(guncelle);
            guncelle.Show();
            Text = "Personel Güncelle";

        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            MenuAyari();
            PanelKontrolleri();
            PersonelSil silme = new PersonelSil();
            silme.AutoScroll = false;   
            silme.TopLevel = false; 
            silme.Dock = DockStyle.Fill;
            silme.FormBorderStyle = FormBorderStyle.None;
            panelAna.Controls.Add(silme);
            silme.Show();
            Text = "Personel Sil";
        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            MenuAyari();

            PanelKontrolleri();
            DepartmanEkle meslekGrubu = new DepartmanEkle();
            meslekGrubu.AutoScroll = false;
            meslekGrubu.TopLevel = false;
            meslekGrubu.Dock = DockStyle.Fill;
            meslekGrubu.FormBorderStyle = FormBorderStyle.None;
            panelAna.Controls.Add(meslekGrubu);
            meslekGrubu.Show();
            Text = "Departman Ekle";

        }

        private void btnDepartmanGuncelle_Click(object sender, EventArgs e)
        {
            MenuAyari();
            PanelKontrolleri();
            DepartmanGuncelle departmanGuncelle = new DepartmanGuncelle();
            departmanGuncelle.AutoScroll = false;
            departmanGuncelle.TopLevel = false;
            departmanGuncelle.Dock = DockStyle.Fill;
            departmanGuncelle.FormBorderStyle = FormBorderStyle.None;
            panelAna.Controls.Add(departmanGuncelle);
            departmanGuncelle.Show();
            Text = "Departman Güncelle";

        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            MenuKontrol(panelDepartman);
        }
        private void PanelKontrolleri()
        {
            panelAna.BorderStyle = BorderStyle.FixedSingle;
            panelAna.Controls.Clear();
            panelAna.AutoScroll = true;
        }

        private void btnPersonelDetay_Click(object sender, EventArgs e)
        {
            PanelKontrolleri();
            PersonelDetaylari PersonelDetay = new PersonelDetaylari();
            PersonelDetay.AutoScroll = false;
            PersonelDetay.TopLevel = false;
            PersonelDetay.Dock = DockStyle.Fill;
            PersonelDetay.FormBorderStyle = FormBorderStyle.None;
            panelAna.Controls.Add(PersonelDetay);
            PersonelDetay.Show();
            Text = "Personel Detayları";

        }
    }
}
