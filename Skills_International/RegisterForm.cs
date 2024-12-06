using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Skills_International
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }



        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-FL3506PV\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True"))
                {
                    con.Open();
                    string insertQuery = @"
                        INSERT INTO registration 
                        (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) 
                        VALUES 
                        (@firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@firstName", tb_firstName.Text);
                        cmd.Parameters.AddWithValue("@lastName", tb_lastName.Text);
                        cmd.Parameters.AddWithValue("@dateOfBirth", dob.Value);
                        cmd.Parameters.AddWithValue("@gender", GetRadioValue());
                        cmd.Parameters.AddWithValue("@address", address.Text);
                        cmd.Parameters.AddWithValue("@email", tb_email.Text);
                        cmd.Parameters.AddWithValue("@mobilePhone", tb_mobile.Text);
                        cmd.Parameters.AddWithValue("@homePhone", tb_home.Text);
                        cmd.Parameters.AddWithValue("@parentName", tb_parentName.Text);
                        cmd.Parameters.AddWithValue("@nic", tb_nic.Text);
                        cmd.Parameters.AddWithValue("@contactNo", tb_contactNo.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object GetRadioValue()
        {
            if (rb_male.Checked)
            {
                return "male";
            }
            else if (rb_female.Checked)
            {
                return "female";
            }
            throw new Exception("Please select a gender.");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection details
                string connectString = "Data Source=LAPTOP-FL3506PV\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";
                // Get the selected registration number
                string selectedRegNo = selectRegno.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedRegNo))
                {
                    MessageBox.Show("Please select a valid registration number to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                string updateQuery = @"UPDATE registration 
                                       SET 
                                           FirstName = @FirstName,
                                           LastName = @LastName,
                                           DateOfBirth = @DateOfBirth,
                                           Gender = @Gender,
                                           Address = @Address,
                                           Email = @Email,
                                           MobilePhone = @MobilePhone,
                                           HomePhone = @HomePhone,
                                           ParentName = @ParentName,
                                           NIC = @NIC,
                                           ContactNo = @ContactNo
                                       WHERE 
                                           regNo = @regNo";

                using (SqlConnection con = new SqlConnection(connectString))
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@regNo", selectedRegNo);
                    cmd.Parameters.AddWithValue("@FirstName", tb_firstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", tb_lastName.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob.Value);
                    cmd.Parameters.AddWithValue("@Gender", GetSelectedGender());
                    cmd.Parameters.AddWithValue("@Address", address.Text);
                    cmd.Parameters.AddWithValue("@Email", tb_email.Text);
                    cmd.Parameters.AddWithValue("@MobilePhone", tb_mobile.Text);
                    cmd.Parameters.AddWithValue("@HomePhone", tb_home.Text);
                    cmd.Parameters.AddWithValue("@ParentName", tb_parentName.Text);
                    cmd.Parameters.AddWithValue("@NIC", tb_nic.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", tb_contactNo.Text);

                    con.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Record Updated Succesfully","Update Student",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records updated. Please check the registration number.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object GetSelectedGender()
        {
            if (rb_male.Checked)
            {
                return "male";
            }
            else if (rb_female.Checked)
            {
                return "female";
            }
            return null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_firstName.Text = String.Empty;
            tb_lastName.Text = String.Empty;
            dob.Text = DateAndTime.Now.ToString();
            rb_female.Checked = false;
            rb_male.Checked = false;
            address.Text = String.Empty;
            tb_email.Text = String.Empty;
            tb_mobile.Text = String.Empty;
            tb_home.Text = String.Empty;
            tb_parentName.Text = String.Empty;
            tb_nic.Text = String.Empty;
            tb_contactNo.Text = String.Empty;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection details
                string connectionString = "Data Source=LAPTOP-FL3506PV\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";

                // Get the selected registration number from the ComboBox
                string selectedRegNo = selectRegno.SelectedItem?.ToString();

                // Validate the selected registration number
                if (string.IsNullOrEmpty(selectedRegNo))
                {
                    MessageBox.Show("Please select a valid registration number to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure regNo is numeric (assuming regNo is an integer)
                if (!int.TryParse(selectedRegNo, out int regNo))
                {
                    MessageBox.Show("Registration number must be a valid number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Prompt the user for confirmation before deletion
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete this student?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    // SQL query to delete the record
                    string deleteQuery = "DELETE FROM registration WHERE regNo = @regNo";

                    // Execute the delete command within a using block to ensure resources are disposed
                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        // Add the regNo parameter to the SQL command
                        cmd.Parameters.AddWithValue("@regNo", regNo);

                        // Open the connection
                        con.Open();

                        // Execute the command and get the number of rows affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the deletion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally, remove the deleted regNo from the ComboBox
                            selectRegno.Items.Remove(selectedRegNo);

                            // Optionally, clear the form fields after deletion
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("No record found to delete. Please check the registration number.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // User chose not to delete
                    MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear form fields
        private void ClearFormFields()
        {
            tb_firstName.Clear();
            tb_lastName.Clear();
            dob.Value = DateTime.Now;
            address.Clear();
            tb_email.Clear();
            tb_mobile.Clear();
            tb_home.Clear();
            tb_parentName.Clear();
            tb_nic.Clear();
            tb_contactNo.Clear();

            // Uncheck gender radio buttons
            rb_male.Checked = false;
            rb_female.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Connection details
                string connectionString = "Data Source=LAPTOP-FL3506PV\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";

                // Get the selected registration number
                string selectedRegNo = selectRegno.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedRegNo))
                {
                    MessageBox.Show("Please select a valid registration number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure regNo is numeric
                int regNo;
                if (!int.TryParse(selectedRegNo, out regNo))
                {
                    MessageBox.Show("Registration number must be a valid number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // SQL query to fetch details
                string query = "SELECT * FROM registration WHERE regNo = @regNo";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@regNo", SqlDbType.Int).Value = regNo;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Fill form fields with data
                            tb_firstName.Text = reader["FirstName"]?.ToString();
                            tb_lastName.Text = reader["LastName"]?.ToString();
                            dob.Value = reader["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(reader["DateOfBirth"]) : DateTime.Now;
                            address.Text = reader["Address"]?.ToString();
                            tb_email.Text = reader["Email"]?.ToString();
                            tb_mobile.Text = reader["MobilePhone"]?.ToString();
                            tb_home.Text = reader["HomePhone"]?.ToString();
                            tb_parentName.Text = reader["ParentName"]?.ToString();
                            tb_nic.Text = reader["NIC"]?.ToString();
                            tb_contactNo.Text = reader["ContactNo"]?.ToString();

                            // Set the gender radio button based on the value in the database
                            string gender = reader["Gender"]?.ToString();
                            if (gender == "male")
                            {
                                rb_male.Checked = true;
                            }
                            else if (gender == "female")
                            {
                                rb_female.Checked = true;
                            }
                            else
                            {
                                rb_male.Checked = false;
                                rb_female.Checked = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No record found for the selected registration number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Show any errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-FL3506PV\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            // SQL query to fetch details
            string query = "SELECT regNo FROM registration";

            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                selectRegno.Items.Add(dr["RegNo"]);
            }
            con.Close();

        }
    }
}
