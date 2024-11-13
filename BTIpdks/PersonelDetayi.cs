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
    public partial class personelDetay : Form
    {
        public personelDetay()
        {
            InitializeComponent();
        }

        // todo SQL işlemleri bir sınıf üzerinden yürütülecek..
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KCMOCA6;Initial Catalog=BTI_PDKS;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public string secilenPersonId;
        private void gridPersonDetail_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT personInformation.PRSCODE,personInformation.PRSNAME,personInformation.PRSSURNAME,personInformation.PRSTCNO,personInformation.PRSTELNO,personInformation.PRSMAİL,personInformation.PRSJOBSTART," +
                    "personInformation.PRSJOBSEXIT,personInformation.PRSIMAGE,personJobs.GRUPCODE," +
                    "personJobs.GRUPNAME FROM personInformation INNER JOIN personJobs ON personInformation.GRUPREF = personJobs.GRUPREF where PRSREF=@PRSREF", con);
            SqlParameterCollection param = cmd.Parameters;
            param.AddWithValue("PRSREF", secilenPersonId);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            lblPersonelKodu.Text = dr.GetString(0);
            lblPersonelAdi.Text = dr.GetString(1);
            lblPersonelSoyad.Text = dr.GetString(2);
            lblPersonelTc.Text = dr.GetString(3);
            lblPersonelTel.Text = dr.GetString(4);
            lblPersonelMail.Text = dr.GetString(5);
            lblPersonelIseGiris.Text = dr.GetDateTime(6).ToString("dd-MM-yyyy");
            if (!dr.IsDBNull(7))
            {
                lblPersonelIscikis.Text = dr.GetDateTime(7).ToString("dd-MM-yyyy");

            }
            else 
            {
                lblPersonelIscikis.Text = "Çalışmaya Devam Ediyor";
            }


            if ((dr.GetValue(8) as byte[])?.Count() > 0)
            {
                // Bir class içerisinde metot çağırılarak çevirme işlemi yapılacak..
                MemoryStream ms = new MemoryStream((byte[])dr.GetValue(8));
                pbResim.Image = new Bitmap(ms);
            }
            

            lblMeslekUnvani.Text = dr.GetString(9);
            lblJobDepartmanAdi.Text = dr.GetString(10);

            con.Close();
        }
    }
}
