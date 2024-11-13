using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTIpdks
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KCMOCA6;Initial Catalog=BTI_PDKS;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        connection connec = new connection();
        void buton()
        {
            DataGridViewButtonColumn dtyBtn = new DataGridViewButtonColumn();
            dtyBtn.Text = "Detay";
            dtyBtn.Name = "Detay";
            dtyBtn.UseColumnTextForButtonValue = true;
            dtyBtn.Width = 100;
            dgListe.Columns.Add(dtyBtn);
        }
        private void DgvDoldur()
        {
            try
            {
                dgListe.Columns.Clear();
                da = new SqlDataAdapter("SELECT * FROM personInformation", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "personInformation");
                dgListe.DataSource = ds.Tables["personInformation"];
                buton();

                dgListe.Columns[0].Visible = false;
                dgListe.Columns[1].HeaderText = "Personel Kodu";
                dgListe.Columns[2].HeaderText = "Personel Adı";
                dgListe.Columns[3].HeaderText = "Personel Soyadı";
                dgListe.Columns[4].HeaderText = "Personel TC";
                dgListe.Columns[5].HeaderText = "Personel Tel";
                dgListe.Columns[6].HeaderText = "Personel Mail";
                dgListe.Columns[7].HeaderText = "Personel İş Giriş Tarihi";
                dgListe.Columns[8].Visible = false;
                dgListe.Columns[9].HeaderText = "Personel Meslek No";
                dgListe.Columns[10].HeaderText = "Personel Durum";
                dgListe.Columns[11].HeaderText = "Personel Resmi";
                dgListe.Columns[12].HeaderText = "Detay";





            }
            catch (Exception)
            {
                MessageBox.Show("Datagrid Doldurulamadı !!", "@Data Hata !");
            }
            finally
            {
                con.Close();
            }
        }

        private void personelEkle_Load(object sender, EventArgs e)
        {
            DgvDoldur();
            cmboxDoldur();
            dgListe.AllowUserToAddRows = false;
            dgListe.AllowUserToDeleteRows = false;
            dgListe.ReadOnly = true;
            dtIsGiris.Format = DateTimePickerFormat.Custom;
            txtPersonelKodu.Focus();
            maskTxtTc.SelectionStart = 0;
            maskTxtTel.SelectionStart = 1;
        }
        public int TcKontrol(string pTc)
        {
            int result;
            con.Open();
            string query = "select count(*)PRSTCNO from personInformation where PRSTCNO='" + pTc + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            result = Convert.ToInt32(sqlCommand.ExecuteScalar());

            con.Close();
            return result;

        }
        public int PkodKontrol(string pCode)
        {
            int result;
            con.Open();
            string query = "select count(*)PRSCODE from personInformation where PRSCODE='" + pCode + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            result = Convert.ToInt32(sqlCommand.ExecuteScalar());

            con.Close();
            return result;

        }
        public int PmailKontrol(string pMail)
        {
            int result;
            con.Open();
            string query = "select count(*)PRSMAİL from personInformation where PRSMAİL='" + pMail + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            result = Convert.ToInt32(sqlCommand.ExecuteScalar());

            con.Close();
            return result;

        }
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

        #region Personel Kayıt 
        private void btnKaydet_Click(object sender, EventArgs e)
                            {
            if (PmailKontrol(txtMail.Text) != 0)
            {
                MessageBox.Show("Daha önce bu Mail Kullanılmış !!", "@PRSMAİL ");
            }
            else
            {


                if (PkodKontrol(txtPersonelKodu.Text) != 0)
                {
                    MessageBox.Show("Daha önce bu Personel Kodu Kullanılmış !!", "@PRSCODE ");
                }

                else
                {
                    if (TcKontrol(maskTxtTc.Text) != 0)
                    {
                        MessageBox.Show("Daha önce bu TC Kimlik ile Kayıt Yapılmış !!", "@PRSTC");
                    }
                    else
                    {
                        try
                        {
                            {

                                cmd = new SqlCommand("insert into personInformation(PRSCODE,PRSNAME,PRSSURNAME,PRSTCNO,PRSTELNO,PRSMAİL,PRSJOBSTART,GRUPREF,PRSACTIVE,PRSIMAGE) " +
                                "values(@PRSCODE,@PRSNAME,@PRSSURNAME,@PRSTCNO,@PRSTELNO,@PRSMAİL,@PRSJOBSTART,@GRUPREF,@PRSACTIVE,@PRSIMAGE)", con);

                                con.Open();
                                if (txtPersonelKodu.Text != String.Empty)
                                {
                                    cmd.Parameters.AddWithValue("@PRSCODE", txtPersonelKodu.Text.ToString().Trim());
                                }
                                else
                                {
                                    errorProvider1.SetError(txtPersonelKodu, "Bu Alan Boş Bırakılamaz!");
                                }
                                if (txtPersonelAdi.Text != String.Empty)
                                {
                                    cmd.Parameters.AddWithValue("@PRSNAME", txtPersonelAdi.Text.ToString().Trim());
                                }
                                else
                                {
                                    errorProvider1.SetError(txtPersonelAdi, "Bu Alan Boş Bırakılamaz!");
                                }
                                if (txtPersonelSoyadi.Text != String.Empty)
                                {
                                    cmd.Parameters.AddWithValue("@PRSSURNAME", txtPersonelSoyadi.Text.ToString().Trim());
                                }
                                else
                                {
                                    errorProvider1.SetError(txtPersonelSoyadi, "Bu Alan Boş Bırakılamaz!");
                                }

                                if (maskTxtTc.Text != String.Empty)
                                {
                                    cmd.Parameters.AddWithValue("@PRSTCNO", maskTxtTc.Text.ToString().Trim());
                                }
                                else
                                {
                                    errorProvider1.SetError(maskTxtTc, "Bu Alan Boş Bırakılamaz!");
                                }
                                if (maskTxtTel.Text != String.Empty)
                                {
                                    cmd.Parameters.AddWithValue("@PRSTELNO", maskTxtTel.Text.ToString().Trim());
                                }
                                else
                                {
                                    errorProvider1.SetError(maskTxtTel, "Bu Alan Boş Bırakılamaz!");
                                }
                                if (txtMail.Text != String.Empty)
                                {
                                    cmd.Parameters.AddWithValue("@PRSMAİL", txtMail.Text.ToString().Trim());
                                }
                                else
                                {
                                    errorProvider1.SetError(txtMail, "Bu Alan Boş Bırakılamaz!");
                                }
                                if (dtIsGiris.Text != String.Empty)
                                {
                                    cmd.Parameters.AddWithValue("@PRSJOBSTART", dtIsGiris.Value);
                                }
                                else
                                {
                                    errorProvider1.SetError(dtIsGiris, "Bu Alan Boş Bırakılamaz!");
                                }
                                if (cmbUnvan.SelectedValue != string.Empty)
                                {
                                    cmd.Parameters.AddWithValue("@GRUPREF", cmbUnvan.SelectedValue);
                                }
                                else
                                {
                                    errorProvider1.SetError(cmbUnvan, "Bu Alan Boş Bırakılamaz!");
                                }
                                cmd.Parameters.AddWithValue("@PRSACTIVE", radioBtnAktif.Checked);
                                //if (pcboxPersonelResim.Image != null)
                                //{
                                //    MemoryStream ms = new MemoryStream();
                                //    pcboxPersonelResim.Image.Save(ms, pcboxPersonelResim.Image.RawFormat);
                                //    byte[] imageBytes = ms.ToArray();
                                //    cmd.Parameters.AddWithValue("@PRSRESIM", imageBytes);
                                //}
                                //else
                                //{
                                //    cmd.Parameters.AddWithValue("@PRSRESIM", DBNull.Value);
                                //}
                                   

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

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Kaydetme İşlemi Başarısız !!" + ex.Message);

                        }
                        finally
                        {
                            con.Close();
                            DgvDoldur();
                            
                        }
                    }

                }
            }
        }
        #endregion



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

        private void dgListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            personelDetay personDetails = new personelDetay();
            if (dgListe.SelectedCells.Count > 0)
            {
                int selectIndex = dgListe.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgListe.Rows[selectIndex];
                personDetails.secilenPersonId = Convert.ToString(selectedRow.Cells[1].Value);
                personDetails.ShowDialog();
            }
        }

        private void dgListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListe.Columns[e.ColumnIndex].Name == "Detay" && e.RowIndex >= 0)
            {
                personelDetay personDetails = new personelDetay();
                if (dgListe.SelectedCells.Count > 0)
                {
                    int selectIndex = dgListe.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgListe.Rows[selectIndex];
                    personDetails.secilenPersonId = Convert.ToString(selectedRow.Cells["PRSREF"].Value);
                    personDetails.ShowDialog();
                }
            }
        }

        private void dgListe_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgListe.ClearSelection();
            // reflection
            //object obj = new { Id = 1, Name = "" };
            //foreach(var property in obj.GetType().GetProperties())
            //{
            //    string name = property.Name;
            //    object value = property.GetValue(obj, null);
            //}
        }

     
    }
}
