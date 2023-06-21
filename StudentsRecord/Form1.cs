using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentsRecord
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source = TAM1M\DESHERP; Initial Catalog = dbStudentRecord; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            string query = "INSERT INTO tbl_studinfo (stu_roll, stu_name, stu_gender, stu_dob, stu_email)" +
                              "values('" + txtRoll.Text + "','" + txtName.Text + "','" + cmbGender.Text + "','" + dtpBirthday.Text + "','" + txtEmail.Text + "')";

            SqlCommand sqlCmd = new SqlCommand(query, sqlConn);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
            clear_fields();
            display_data();
            MessageBox.Show("Data saved successfully.");
        }

        public void display_data()
        {
            sqlConn.Open();
            string query = "SELECT stu_roll, stu_name, stu_email FROM tbl_studinfo";
            SqlCommand sqlCmd = new SqlCommand(query, sqlConn);
            sqlCmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
            adapter.Fill(dt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            sqlConn.Close();

        }

        public void clear_fields()
        {
            txtRoll.Clear();
            txtName.Clear();
            cmbGender.SelectedIndex = -1;
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.CustomFormat = "dd-MMM-yyyy";
            txtEmail.Clear();
            txtSearch.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            display_data();
            clear_fields();

            DataTable data = GetDataFromDatabase();

            using (StreamWriter writer = new StreamWriter("E:\\Projects\\Student-records\\ExportedData.csv"))
            {
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    writer.Write(data.Columns[i].ColumnName);
                    if (i < data.Columns.Count - 1)
                        writer.Write(",");
                }
                writer.WriteLine();

                foreach (DataRow row in data.Rows)
                {
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        writer.Write(row[i].ToString());
                        if (i < data.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();
                }
            }
            MessageBox.Show("Data exported to local storage.");
        }

        private DataTable GetDataFromDatabase()
        {
            DataTable dataTable = new DataTable();

            sqlConn.Open();
            string query = "SELECT * FROM tbl_studinfo";

            using (SqlCommand sqlCmd = new SqlCommand(query, sqlConn))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            sqlConn.Close();
            return dataTable;
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to delete this data?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sqlConn.Open();
                string query = "DELETE from tbl_studinfo WHERE stu_roll = '" + txtRoll.Text + "' ";
                SqlCommand sqlCmd = new SqlCommand(query, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                clear_fields();
                display_data();
            }
            else
            {
                MessageBox.Show("Data deletion cancelled.");
                clear_fields();
                display_data();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            string query = "UPDATE tbl_studinfo SET stu_roll= '" + txtRoll.Text + "', stu_name= '" + txtName.Text + "', stu_gender= '" + cmbGender.Text + "', stu_dob= '" + dtpBirthday.Text + "', stu_email= '" + txtEmail.Text + "' " +
                               "WHERE stu_roll = '" + txtRoll.Text + "'";

            SqlCommand sqlCmd = new SqlCommand(query, sqlConn);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
            clear_fields();
            display_data();
            MessageBox.Show("Data has been updated successfully.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            sqlConn.Open();
            string query = "SELECT stu_roll, stu_name, stu_email FROM tbl_studinfo WHERE  stu_roll LIKE @SearchTerm " +
                           "OR stu_name LIKE @SearchTerm OR stu_email LIKE @SearchTerm";

            SqlCommand sqlCmd = new SqlCommand(query, sqlConn);
            sqlCmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

            SqlDataReader reader = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            sqlConn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtRoll.Text = selectedRow.Cells["clmRoll"].Value.ToString();
                txtName.Text = selectedRow.Cells["clmName"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["clmEmail"].Value.ToString();
            }
        }

    }
}
