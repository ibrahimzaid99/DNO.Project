using DNO.model;
using System.Data;
using System.Data.SqlClient;

namespace DNO
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            string connectionStr = "server=DESKTOP-J7C2TA3;Database=iti;Trusted_Connection=true;TrustServerCertificate=true";
            // define connection
            connection = new SqlConnection(connectionStr);
            button1_add.Visible = true;
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }
        void GetTopicsManual()
        {
            SqlCommand cmd = new SqlCommand("select * from Topic", connection);

            List<topics> topicsList = new List<topics>();
            try
            {
                // Open connection
                connection.Open();

                // Execute command
                SqlDataReader reader = cmd.ExecuteReader();

                // Retrieve data
                while (reader.Read())
                {
                    topics Topic = new topics()
                    {
                        Topic_Id = (int)reader["Top_Id"],
                        Topic_Name = reader["Top_Name"].ToString()
                    };
                    topicsList.Add(Topic);
                }

                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
            finally
            {
                // Close connection
                connection.Close();
            }

            // Display data
            dgv.DataSource = topicsList;
        }

        void GetAllCourses()
        {
            // define command
            SqlCommand cmd = new SqlCommand("Select [Crs_Id],[Crs_Name],[Crs_Duration],[Top_Id] from Course;", connection);

            DataTable dt = new DataTable();
            try
            {
                // open connection
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                connection.Close();
            }

            dgv.DataSource = dt;
        }
        void GetTopics()
        {
            SqlCommand cmd = new SqlCommand("Select [Top_Id],[Top_Name] From Topic", connection);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                connection.Close();

            }
            cm.DataSource = dt;
            cm.DisplayMember = "Top_Name";
            cm.ValueMember = "Top_Id";
        }
        void ClearInputs()
        {
           text_name.Text = "";
            num__duration.Value = 0;
            cm.SelectedValue = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllCourses();
            GetTopics();

        }
        int id;
        private readonly object btn_add;

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            text_name.Text = row.Cells[1].Value.ToString();
            num__duration.Value = (int)row.Cells[2].Value;
            cm.SelectedValue = (int)row.Cells[3].Value;
           
            btn_delete.Visible = true;
            btn_edit.Visible = true;
        }
        private void button1_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into Course(Crs_Name, Crs_Duration, Top_Id) values('{text_name.Text}',{num__duration.Value},{cm.SelectedValue})", connection);
            int rowsEffected = 0;
            try
            {
                connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record wasn't added");
            }
            finally
            {
                connection.Close();
            }

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data added.");
                GetAllCourses();
            }
            ClearInputs();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"UPDATE Course SET [Crs_Name] = '{text_name.Text}', [Crs_Duration] = {num__duration.Value}, [Top_Id] = {cm.SelectedValue} WHERE [Crs_Id] = {id}", connection); int rowsEffected = 0;
            try
            {
                connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            if (rowsEffected > 0)
            {
                MessageBox.Show("Edit was done");
                GetAllCourses();
            }
            ClearInputs();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"delete from Course where Crs_Id={id};", connection);
            int rowsEffected = 0;
            try
            {
                connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data deleted" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            if (rowsEffected > 0)
            {
                MessageBox.Show("Data deleted");
                GetAllCourses();
            }
            ClearInputs();

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            GetTopicsManual();
            button1_add.Visible = false;
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }
    }
}
