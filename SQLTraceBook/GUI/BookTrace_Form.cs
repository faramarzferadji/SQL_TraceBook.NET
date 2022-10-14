using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLTraceBook.Business;
using SQLTraceBook.DataAccesses;
using System.Data.SqlClient;



namespace SQLTraceBook.GUI
{
    public partial class BookTrace_Form : Form
    {
        public BookTrace_Form()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxBlock.Text = "";
            textBoxSTname.Text = "";
            comboBoxTitel.Text = "";
            comboBoxIDBOOK.Text = "";
            textBoxtotal.Text = "";
            dateTimePickerDateOut.Text = string.Empty;
            dateTimePickerDateDue.Text = string.Empty;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure to Exit?", "Exit Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonInsertindb_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBforTRACEBOOK.sql;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Insert into TraceBookTable(block,stname,bookname,bookid,dateout,datedue) values(@block,@stname,@bookname,@bookid,@dateout,@datedue)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@block", comboBoxBlock.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@stname", textBoxSTname.Text);
                cmd.Parameters.AddWithValue("@bookname", comboBoxTitel.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@bookid", comboBoxIDBOOK.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@dateout", Convert.ToDateTime(dateTimePickerDateOut.Value));
                cmd.Parameters.AddWithValue("@datedue", Convert.ToDateTime(dateTimePickerDateDue.Value));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("All Data has been stored correctly");
            }

        }

        private void buttonDeleteDB_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBforTRACEBOOK.sql;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Delete TraceBookTable where stname='" + textBoxSTname.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data successfully deleted from DataBase");

            }

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBforTRACEBOOK.sql;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                listView1.Items.Clear();
                con.Open();
                string query = "Select * from TraceBookTable";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach(DataRow dataRow in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(dataRow["block"].ToString());
                    item.SubItems.Add(dataRow["stname"].ToString());
                    item.SubItems.Add(dataRow["bookname"].ToString());
                    item.SubItems.Add(dataRow["bookid"].ToString());
                    item.SubItems.Add(dataRow["dateout"].ToString());
                    item.SubItems.Add(dataRow["datedue"].ToString());
                    listView1.Items.Add(item);
                    //MessageBox.Show(dataRow["stname"].ToString());


                }
                //MessageBox.Show("data correctement enter in listview");
                


            }

        }

        private void comboBoxBlock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttontotal_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBforTRACEBOOK.sql;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "select count(block) as totala from TraceBookTable";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    textBoxtotal.Text = sqlDataReader["totala"].ToString();
                }
                con.Close();

            }

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBforTRACEBOOK.sql;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                listView1.Items.Clear();
                con.Open();
                string query = "Select * from TraceBookTable where stname='" + textBoxSTname.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(dataRow["block"].ToString());
                    item.SubItems.Add(dataRow["stname"].ToString());
                    item.SubItems.Add(dataRow["bookname"].ToString());
                    item.SubItems.Add(dataRow["bookid"].ToString());
                    item.SubItems.Add(dataRow["dateout"].ToString());
                    item.SubItems.Add(dataRow["datedue"].ToString());
                    listView1.Items.Add(item);
                    //MessageBox.Show(dataRow["stname"].ToString());


                }

            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBforTRACEBOOK.sql;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                listView1.Items.Clear();
                con.Open();
                string query = "update TraceBookTable set block='"+Convert.ToInt32(comboBoxBlock.SelectedItem.ToString())+"',bookname='"+comboBoxTitel.SelectedItem.ToString()+ "',bookid='" + Convert.ToInt32(comboBoxIDBOOK.SelectedItem.ToString()) + "',dateout='"+ Convert.ToDateTime(dateTimePickerDateOut.Value)+"',datedue='"+ Convert.ToDateTime(dateTimePickerDateDue.Value)+"'  where stname='" + textBoxSTname.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(dataRow["block"].ToString());
                    item.SubItems.Add(dataRow["stname"].ToString());
                    item.SubItems.Add(dataRow["bookname"].ToString());
                    item.SubItems.Add(dataRow["bookid"].ToString());
                    item.SubItems.Add(dataRow["dateout"].ToString());
                    item.SubItems.Add(dataRow["datedue"].ToString());
                    listView1.Items.Add(item);
                    //MessageBox.Show(dataRow["stname"].ToString());


                }
                MessageBox.Show("UpDating successfully done!");

            }

        }

        private void buttonsum_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBforTRACEBOOK.sql;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "select sum(block) as sumto from TraceBookTable";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    textBoxsun.Text = sqlDataReader["sumto"].ToString();
                }
                con.Close();

            }

        }
    }
}
 