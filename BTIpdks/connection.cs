using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BTIpdks
{
    public class connection
    {
        // Properties
        public string ConnectionString { get; set; } = @"Data Source=DESKTOP-KCMOCA6;Initial Catalog=BTI_PDKS;Integrated Security=True";
        public SqlConnection Connection { get; set; }

        //todo Dapper ve Ado.Net Kullanımı ???

        public connection()
        {
            Connection = new SqlConnection(ConnectionString);
        }


        public bool Login(string userName, string password)
        {
            var result = false;
            try
            {
                Connection.Open();
                string sql = @"SELECT * FROM login WHERE userName=@name AND userPassword=@password";
                SqlParameter user = new SqlParameter("name", userName);
                SqlParameter pass = new SqlParameter("password", password);
                SqlCommand command = new SqlCommand(sql, Connection);
                command.Parameters.Add(user);
                command.Parameters.Add(pass);
                DataTable dt = new DataTable();
                SqlDataAdapter dtAdap = new SqlDataAdapter(command);
                dtAdap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantıda Hata ! " + ex.Message);
                result = false;
            }
            Connection.Close();
            return result;

        }
        public bool Guncelle(int PRSREF, string PRSCODE, string PRSNAME, string PRSSURNAME, string PRSTC, string PRSTEL, string PRSMAIL, DateTime PRSISGIRIS, DateTime PRSISCIKIS, int GRPREF)
        {
            cmd = new SqlCommand("update personInformation set PRSCODE=@PRSCODE,PRSNAME=@PRSNAME,PRSSURNAME=@PRSSURNAME," +
                        "PRSTCNO=@PRSTCNO,PRSTELNO=@PRSTELNO,PRSMAİL=@PRSMAİL,PRSISGIRIS=@PRSISGIRIS,PRSISCIKIS=@PRSISCIKIS,GRUPREF=@GRUPREF where PRSREF=@PRSREF"
                  , Connection);
            Connection.Open();
            cmd.Parameters.AddWithValue("@PRSREF", PRSREF);
            cmd.Parameters.AddWithValue("@PRSCODE", PRSCODE);
            cmd.Parameters.AddWithValue("@PRSNAME", PRSNAME);
            cmd.Parameters.AddWithValue("@PRSSURNAME", PRSSURNAME);
            cmd.Parameters.AddWithValue("@PRSTCNO", PRSTC);
            cmd.Parameters.AddWithValue("@PRSTELNO", PRSTEL);
            cmd.Parameters.AddWithValue("@PRSMAİL", PRSMAIL);
            cmd.Parameters.AddWithValue("@PRSISGIRIS", PRSISGIRIS);
            cmd.Parameters.AddWithValue("@PRSISCIKIS", PRSISCIKIS);
            cmd.Parameters.AddWithValue("@GRUPREF", GRPREF);
            //ImageConverter ımageConverter = new ImageConverter();
            //var bytImage = (byte[])ımageConverter.ConvertTo(PRSRESIM, typeof(byte[]));
            //cmd.Parameters.AddWithValue("@PRSRESIM", bytImage);
            cmd.ExecuteNonQuery();
            Connection.Close();
            return true;
        }
        public bool GrupUpdate(int GRPREF, string GRPCODE, string GRPNAME)
        {
            var result = false;
            try
            {
                cmd = new SqlCommand("update personJobs set GRUPCODE=@GRUPCODE,GRUPNAME=@GRUPNAME where GRUPREF=@GRUPREF", Connection);
                Connection.Open();
                cmd.Parameters.AddWithValue("@GRUPREF", GRPREF);
                cmd.Parameters.AddWithValue("@GRUPCODE", GRPCODE);
                cmd.Parameters.AddWithValue("@GRUPNAME", GRPNAME);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATALI İŞLEM ! " + ex.Message);
                result = false;
                
            }
            Connection.Close();
            return true;
        }
        public bool GrupInsert(string GRPCODE, string GRPNAME)
        {
            var result = false;
            try
            {
                cmd = new SqlCommand("insert into personJobs(GRUPCODE,GRUPNAME) values(@GRUPCODE,@GRUPNAME)", Connection);
                Connection.Open();
                cmd.Parameters.AddWithValue("@GRUPCODE", GRPCODE);
                cmd.Parameters.AddWithValue("@GRUPNAME", GRPNAME);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {


                MessageBox.Show("HATALI İŞLEM ! " + ex.Message);
                result = false;

            }
            Connection.Close();
            return result;




        }





        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
    }
}
