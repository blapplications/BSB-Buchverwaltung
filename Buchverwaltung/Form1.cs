using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchverwaltung
{
    public partial class Form1 : Form
    {

        private MySqlConnection con = new MySqlConnection(Database.GlobalMySQLCon);
        private String defaultQuery = "select * from autor;";

        public Form1()
        {
            InitializeComponent();
        }

        private void sendRequest_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            if (request.Text == "")
            {
                cmd = new MySqlCommand(defaultQuery, con);
            }
            else
            {
                cmd = new MySqlCommand(request.Text, con);
            }
            ExecuteCommand(cmd);
            fillDataGrid(cmd.CommandText);
        }

        private void clearRequestText_Click(object sender, EventArgs e)
        {
            request.Clear();
        }

        private void createAutor_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into autor(autorName) values (@autorName);", con);
            MySqlParameter autorNameParam = new MySqlParameter("@autorName", autorName.Text);
            cmd.Parameters.Add(autorNameParam);
            ExecuteCommand(cmd);
        }

        private MySqlDataReader ExecuteCommand(MySqlCommand cmd)
        {
            try
            {
                con.Open();
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        private void createVerlag_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into verlag(verlagName) values (@verlagName);", con);
            MySqlParameter verlagNameParam = new MySqlParameter("@verlagName", verlagName.Text);
            cmd.Parameters.Add(verlagNameParam);
            ExecuteCommand(cmd);
        }

        private void createBuch_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into buch(buchName, autor, verlag) values (@buchName, @autor, @verlag);", con);
            MySqlParameter buchNameParam = new MySqlParameter("@buchName", buchName.Text);
            MySqlParameter autorParam = new MySqlParameter("@autor", getAutorID(autorSelect.Text));
            MySqlParameter verlagParam = new MySqlParameter("@verlag", getVerlagID(verlagSelect.Text));
            cmd.Parameters.Add(buchNameParam);
            cmd.Parameters.Add(autorParam);
            cmd.Parameters.Add(verlagParam);
            ExecuteCommand(cmd);
        }

        private int getAutorID(String name)
        {
            MySqlCommand cmd = new MySqlCommand("select autorID from autor where autorName = @autorName;", con);
            MySqlParameter autorNameParam = new MySqlParameter("@autorName", name);
            cmd.Parameters.Add(autorNameParam);

            con.Open();
            string id = cmd.ExecuteScalar().ToString();
            con.Close();

            return Convert.ToInt32(id);
        }

        private int getVerlagID(String name)
        {
            MySqlCommand cmd = new MySqlCommand("select verlagID from verlag where verlagName = @verlagName;", con);
            MySqlParameter verlagNameParam = new MySqlParameter("@verlagName", name);
            cmd.Parameters.Add(verlagNameParam);

            con.Open();
            string id = cmd.ExecuteScalar().ToString();
            con.Close();

            return Convert.ToInt32(id);
        }

        private void fillDataGrid(String cmd)
        {
            MySqlDataAdapter da;
            DataSet ds = new DataSet();
            con.Open();
            try
            {
                da = new MySqlDataAdapter(cmd, con);
                da.Fill(ds);
                con.Close();
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            // store the data of the dataGridView to the database
            MySqlCommand cmd = new MySqlCommand(defaultQuery, con);
            BindGrid(cmd);
        }

        private void BindGrid(MySqlCommand cmd)
        {
            cmd.CommandType = CommandType.Text;
            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
            {
                using (DataTable dt = new DataTable())
                {
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
