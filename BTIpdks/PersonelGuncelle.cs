using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTIpdks
{
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KCMOCA6;Initial Catalog=BTI_PDKS;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        connection connec = new connection();
        private void cmboxDoldur()
        {
            SqlCommand comboboxKomut = new SqlCommand("SELECT * FROM personJobs ", con);
            SqlDataReader dr;
            con.Open();
            DataTable data = new DataTable();
            data.Load(comboboxKomut.ExecuteReader());
            con.Close();
            cmbUnvan.DataSource = data;
            cmbUnvan.DisplayMember = "GRUPCODE";
            cmbUnvan.ValueMember = "GRUPREF";
            cmbUnvan.SelectedIndex = -1;
        }
        private void DgridDoldur()
        {
            try
            {
                dgListe.Columns.Clear();
                da = new SqlDataAdapter("SELECT * FROM personInformation", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "personInformation");
                ds.Tables["personInformation"].Columns[11].DefaultValue = new byte[0];
                dgListe.DataSource = ds.Tables["personInformation"];

                dgListe.Columns[0].Visible = false;
                dgListe.Columns[1].HeaderText = "Personel Kodu";
                dgListe.Columns[2].HeaderText = "Personel Adı";
                dgListe.Columns[3].HeaderText = "Personel Soyadı";
                dgListe.Columns[4].HeaderText = "Personel TC";
                dgListe.Columns[5].HeaderText = "Personel Tel";
                dgListe.Columns[6].HeaderText = "Personel Mail";
                dgListe.Columns[7].HeaderText = "Personel İş Giriş Tarihi";
                dgListe.Columns[8].HeaderText = "Personel İş Çıkış Tarihi";
                dgListe.Columns[9].HeaderText = "Personel Meslek No";
                dgListe.Columns[10].HeaderText = "Personel Durum";
                dgListe.Columns[11].HeaderText = "Personel Resmi";
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Datagrid Doldurulamadı !!", "@Data Hata !");
            }


        }


        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblRef.Text = dgListe.CurrentRow.Cells[0].Value.ToString();
            txtPersonelKodu.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
            txtPersonelAdi.Text = dgListe.CurrentRow.Cells[2].Value.ToString();
            txtPersonelSoyadi.Text = dgListe.CurrentRow.Cells[3].Value.ToString();
            maskTxtTc.Text = dgListe.CurrentRow.Cells[4].Value.ToString();
            maskTxtTel.Text = dgListe.CurrentRow.Cells[5].Value.ToString();
            txtMail.Text = dgListe.CurrentRow.Cells[6].Value.ToString();
            dtIsGiris.Text = dgListe.CurrentRow.Cells[7].Value.ToString();
            dtIscikis.Text = dgListe.CurrentRow.Cells[8].Value.ToString();
            cmbUnvan.SelectedValue = dgListe.CurrentRow.Cells[9].Value.ToString();
            lblDurum.Text = dgListe.CurrentRow.Cells[10].Value.ToString();




            if (dgListe.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgListe.SelectedRows[0];
                if (row.Cells["PRSIMAGE"].Value != null && row.Cells["PRSIMAGE"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["PRSIMAGE"].Value;
                    MemoryStream ms = new MemoryStream(imageBytes);
                    pcboxPersonelResim.Image = Image.FromStream(ms);
                }
                else
                {
                    pcboxPersonelResim.Image = null;
                }
            }
        }

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            cmboxDoldur();
            DgridDoldur();
            txtPersonelKodu.Enabled = false;


        }
        #region Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE personInformation set PRSCODE=@PRSCODE,PRSNAME=@PRSNAME,PRSSURNAME=@PRSSURNAME," +
                "PRSTCNO=@PRSTCNO,PRSTELNO=@PRSTELNO,PRSMAİL=@PRSMAİL,PRSJOBSTART=@PRSJOBSTART,PRSJOBSEXIT=@PRSJOBSEXIT,GRUPREF=@GRUPREF,PRSACTIVE=@PRSACTIVE,PRSIMAGE=@PRSIMAGE WHERE PRSREF=@PRSREF", con);
                con.Open();
                cmd.Parameters.AddWithValue("@PRSREF", lblRef.Text.ToString());
                cmd.Parameters.AddWithValue("@PRSCODE", txtPersonelKodu.Text.ToString());
                cmd.Parameters.AddWithValue("@PRSNAME", txtPersonelAdi.Text);
                cmd.Parameters.AddWithValue("@PRSSURNAME", txtPersonelSoyadi.Text);
                cmd.Parameters.AddWithValue("@PRSTCNO", maskTxtTc.Text);
                cmd.Parameters.AddWithValue("@PRSTELNO", maskTxtTc.Text);
                cmd.Parameters.AddWithValue("@PRSMAİL", txtMail.Text);
                cmd.Parameters.AddWithValue("@PRSJOBSTART", dtIsGiris.Value);

                cmd.Parameters.AddWithValue("@PRSJOBSEXIT", dtIscikis.Text);


                cmd.Parameters.AddWithValue("@GRUPREF", cmbUnvan.SelectedValue);
                cmd.Parameters.AddWithValue("@PRSACTIVE", radioBtnAktif.Checked);

                if (pcboxPersonelResim.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pcboxPersonelResim.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] imageBytes = ms.ToArray();
                    SqlParameter paramResim = new SqlParameter("@PRSIMAGE", SqlDbType.VarBinary);
                    paramResim.Value = imageBytes;
                    cmd.Parameters.Add(paramResim);
                }
                // Eğer PictureBox kontrolünde resim yoksa, null değerini parametreye ekle
                else
                {
                    SqlParameter paramResim = new SqlParameter("@PRSIMAGE", SqlDbType.VarBinary);
                    paramResim.Value = DBNull.Value;
                    cmd.Parameters.Add(paramResim);
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Kaydedilmiştir ! ");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Güncellenirken Bir Hata Oluştu", ex.Message);
            }
            finally
            {
                con.Close();
                DgridDoldur();

            }



        }
        #endregion

        private void radioBtnAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnAktif.Checked)
            {
                dtIscikis.Enabled = false;

            }
            else
            {
                dtIscikis.Enabled = true;
            }


            if (radioBtnAktif.Checked == true)
            {
                lblDurum.Text = "True";
            }
        }

        private void radioBtnPasif_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPasif.Checked == true)
            {
                lblDurum.Text = "False";

            }
        }

        private void lblDurum_TextChanged(object sender, EventArgs e)
        {
            if (lblDurum.Text == "True")
            {
                radioBtnAktif.Checked = true;
            }
            if (lblDurum.Text == "False")
            {
                radioBtnPasif.Checked = true;
            }
        }

        private void pcboxPersonelResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog personelFotograf = new OpenFileDialog();
            personelFotograf.Title = "Fotoğrafı Seç";
            personelFotograf.Filter = "Fotoğraf Dosyaları(*.JPG;*.PNG)|*.JPG;*.PNG";
            if (personelFotograf.ShowDialog() == DialogResult.OK)
            {
                pcboxPersonelResim.Image = Image.FromFile(personelFotograf.FileName);

            }



        }
    }
}
