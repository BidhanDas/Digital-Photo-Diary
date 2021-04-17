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

namespace Digital_Photo_Diary.Presentation_Layer
{
    public partial class User3 : Form
    {
        public User3()
        {
            InitializeComponent();
        }

        private void User3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            this.Hide();
            l1.Show();
        }

        private void browseButtonPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox1.Text = dlg.FileName;
        }

        private void browseButtonAlbum_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox2.Text = dlg.FileName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFile(textBox1.Text, textBox2.Text);
            MessageBox.Show("Saved");
        }

        private void SaveFile(string filePath, string filePath2)
        {
            Stream stream = File.OpenRead(filePath);
            Stream stream2 = File.OpenRead(filePath2);

            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);

            byte[] buffer2 = new byte[stream.Length];
            stream2.Read(buffer2, 0, buffer2.Length);

            var fi = new FileInfo(filePath);
            string extn = fi.Extension;
            string name = fi.Name;

            var fi2 = new FileInfo(filePath2);
            string extn2 = fi2.Extension;
            string name2 = fi2.Name;

            string query = "INSERT INTO User3(Data,Extension,FileName,Data2,Extension2,FileName2) VALUES(@data,@extn,@name,@data2,@extn2,@name2)";

            using (SqlConnection cn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

                cmd.Parameters.Add("@data2", SqlDbType.VarBinary).Value = buffer2;
                cmd.Parameters.Add("@extn2", SqlDbType.Char).Value = extn2;
                cmd.Parameters.Add("@name2", SqlDbType.VarChar).Value = name2;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(local);Initial Catalog=DigitalPhotoDiaryDb;Integrated Security=True");
        }

        private void User3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT ID,Extension,FileName,Extension2,FileName2 FROM User3";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgv1.DataSource = dt;
                textBox1.Text = textBox2.Text = string.Empty;
            }
        }

        private void photoOpenButton_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv1.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }

        private void OpenFile(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT Data,Extension,FileName FROM User3 WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss"));
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                }
            }
        }

        private void textOpenButton_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv1.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile2(id);
            }
        }

        private void OpenFile2(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT Data2,Extension2,FileName2 FROM User3 WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName2"].ToString();
                    var data = (byte[])reader["Data2"];
                    var extn = reader["Extension2"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss"));
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv1.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                DeleteFile(id);
            }
        }

        private void DeleteFile(int id)
        {
            string sql = "DELETE FROM User3 WHERE ID=" + id;
            SqlConnection cn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Row is deleted.");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
