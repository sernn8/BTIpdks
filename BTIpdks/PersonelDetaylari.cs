using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTIpdks
{
    public partial class PersonelDetaylari : Form
    {
        public PersonelDetaylari()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KCMOCA6;Initial Catalog=BTI_PDKS;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void gridDoldur()
        {
            da = new SqlDataAdapter("SELECT personInformation.PRSCODE,personInformation.PRSNAME,personInformation.PRSSURNAME,personInformation.PRSTCNO,personInformation.PRSTELNO,personInformation.PRSMAİL,personInformation.PRSJOBSTART," +
                "personInformation.PRSJOBSEXIT,personInformation.PRSIMAGE,personJobs.GRUPCODE," +
                "personJobs.GRUPNAME FROM personInformation INNER JOIN personJobs ON personInformation.GRUPREF = personJobs.GRUPREF;", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personJobs");
            dataGridView1.DataSource = ds.Tables["personJobs"];
            dataGridView1.Columns[0].HeaderText = "Personel Kodu";
            dataGridView1.Columns[1].HeaderText = "Personel Adı";
            dataGridView1.Columns[2].HeaderText = "Personel Soyadı";
            dataGridView1.Columns[3].HeaderText = "Personel TCNo";
            dataGridView1.Columns[4].HeaderText = "Personel Tel";
            dataGridView1.Columns[5].HeaderText = "Personel Mail";
            dataGridView1.Columns[6].HeaderText = "Personel İşe Giriş Tarihi";
            dataGridView1.Columns[7].HeaderText = "Personel İş Çıkış Tarihi";
            dataGridView1.Columns[8].HeaderText = "Personel Resim";
            dataGridView1.Columns[9].HeaderText = "Personel Meslek Unvanı";
            dataGridView1.Columns[10].HeaderText = "Personel Kayıtlı Departman";



        }


        private void PersonDetails_Load(object sender, EventArgs e)
        {
            gridDoldur();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn ımageColumn = new DataGridViewImageColumn();


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblPersonCode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblPersonName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblPersonSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblPersonTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblPersonTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lblPersonMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lblPersonStartDate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            lblPersonExitDate.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            lblJobName.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            lblJobDepartment.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                if (row.Cells["PRSIMAGE"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["PRSIMAGE"].Value;
                    MemoryStream ms = new MemoryStream(imageBytes);
                    pcBoxResim.Image = Image.FromStream(ms);
                }
                else
                {
                    pcBoxResim.Image = null;
                }

            }
        }
    }
}
