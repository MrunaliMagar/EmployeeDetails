using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;
using System.Drawing.Text;
using System.IO;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EmployeeDetails
{
    public partial class EmployeeForm : Form
    {
       
        public EmployeeForm()
        {
            InitializeComponent();
        }
        //Connection string used for the connecting to the database
        string ConnString = "Data Source=DESKTOP-8PJ9QIA\\SQLEXPRESS;Initial Catalog=EmployeeDB;User ID=sa;Password= sa123;";
        //Email id textbox should follow this pattern
        string email_pattern = "^[\\w-\\.]+@([\\w]+\\.)+[\\w-]{2,3}$";
        //Phone number textbox should follow this pattern
        string phone_pattern = "^[0-9]{10}$";
        //Address textbox should follow this pattern
        string addr_pattern = "^[a-zA-Z0-9]+[a-zA-Z0-9\\.\\s\\-\\,\\.]{5,20}$";
        //Salary textbox should follow this pattern
        string salary_pattern = "^(1000|[0-9]{4,7})$";

        private void sendEmail()
        {
            try
            {
                // Create a new MailMessage with sender and recipient addresses
                MailMessage mail = new MailMessage("mrunalipmagar@gmail.com", email_text.Text);
                // Set the subject and body of the email
                mail.Subject = "Employee Details";
                mail.Body = generateEmailBodyOfEmployee(name_text.Text, phone_text.Text, email_text.Text, address_text.Text, salary_text.Text);

                // Use SmtpClient to send the email
                SmtpClient smtp = new SmtpClient();

                // Set SMTP server port and specify not to use default credentials
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;

                // Provide credentials for authenticating with the SMTP server where first arg is from & second arg is password
                NetworkCredential credential = new NetworkCredential("mrunalipmagar@gmail.com", "dgpdiqfiqdtmvich");
                smtp.Credentials = credential;
                smtp.EnableSsl = true;
                smtp.Send(mail);
                //Display success message
                MessageBox.Show("Done. Please check your email.");
            }              
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        // Generates the body of an email with employee details.
        private string generateEmailBodyOfEmployee(string name, string phone, string email, string address, string salary)
        {
            //Format of displaying body of email 
            return $"Hello {name_text.Text},\n\n" +
                            $"Welcome to Amazatic!!!..Hope you are enjoying working with  Amazatic\n" +
                            $"Your Employee details will be as follows:\n" +
                            $"Name: {name_text.Text}\n" +
                            $"Phone No: {phone_text.Text}\n" +
                            $"Email: {email_text.Text}\n" +
                            $"Address: {address_text.Text}\n" +
                            $"Salary: {salary_text.Text}";
        }

        // Event handler triggered when the focus leaves the name_text TextBox.
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The KeyPressEventArgs containing the key that was pressed.</param>
        private void name_text_Leave(object sender, EventArgs e)
        {
            // Check if the name is empty or null
            if (String.IsNullOrEmpty(name_text.Text))
            {
                // Set focus back to the name_text TextBox
                name_text.Focus();
                // Display an error message using the error provider
                name_errorProvider.SetError(this.name_text,"Please fill the name textfield");
            }
            else
            {
                name_errorProvider.Clear();
            }
        }

        /// <summary>
        /// Event handler triggered when a key is pressed in the name_text TextBox.
        /// Allows only letters, backspace, and space characters.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The KeyPressEventArgs containing the key that was pressed.</param>
        private void name_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8 || ch == 32)
            {

                e.Handled = false;
            }
            else
            {
                e.Handled= true;
            }
        }

        // Event handler triggered when the focus leaves the phone_text TextBox.
        private void phone_text_Leave(object sender, EventArgs e)
        {
            // Check if the entered phone number matches the specified pattern
            if (Regex.IsMatch(phone_text.Text, phone_pattern) == false)
            {
                // Set focus back to the phone_text TextBox
                phone_text.Focus();
                // Display an error message using the error provider
                phone_errorProvider.SetError(this.phone_text, "Please enter the valid mobile number ");
            }
            else
            {
                // Clear the error message if the phone number is valid
                phone_errorProvider.Clear();
            }
        }

        // Event handler triggered when a key is pressed in the phone_text TextBox.
        // Allows only digit characters and backspace.
        private void phone_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            
            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }
            
            else if(ch == 8 )
            {
                
                e.Handled=false;
            }
            
            else
            {
                e.Handled= true; 
            }
        }

        // Event handler triggered when the focus leaves the email_text TextBox.
        private void email_text_Leave(object sender, EventArgs e)
        {
            // Check if the entered email address matches the specified pattern
            if (Regex.IsMatch(email_text.Text, email_pattern)== false)
            {
                email_text.Focus();
                email_errorProvider.SetError(this.email_text, "Invalid Email");
            }
            
            else
            {
                email_errorProvider.Clear();
            }
        }

       

        // Event handler triggered when the focus leaves the address_text TextBox.
        private void address_text_Leave(object sender, EventArgs e)
        {
            // Check if the entered address matches the specified pattern
            if (Regex.IsMatch(address_text.Text, addr_pattern) == false)
            {
                address_text.Focus();
                address_errorProvider.SetError(this.address_text, "Please enter the valid address ");
            }
            else
            {
                address_errorProvider.Clear();
            }

        }

        // Event handler triggered when the focus leaves the salary_text TextBox.
        private void salary_text_Leave(object sender, EventArgs e)
        {
            // Check if the entered salary matches the specified pattern
            if (Regex.IsMatch(salary_text.Text, salary_pattern) == false)
            {
                salary_text.Focus();
                salary_errorProvider.SetError(this.salary_text, "Please enter the salary within range ");
            }

            else
            {
                salary_errorProvider.Clear();
            }

        }

        // Event handler triggered when a key is pressed in the salary_text TextBox.
        // Allows only digit and backspace
        private void salary_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }
          
            else if (ch == 8)
            {

                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        // Event handler triggered when the submit button is clicked.
        // Validates input fields and inserts employee details into the database.
        private void submit_Send_EmployeeDetails_Click(object sender, EventArgs e)
        {
            // Validate the name field
            if (String.IsNullOrEmpty(name_text.Text))
            {
                name_text.Focus();
                name_errorProvider.SetError(this.name_text, "Please fill the name textfield");
            }
            // Validate the phone number field
            if (Regex.IsMatch(phone_text.Text, phone_pattern) == false)
            {
                phone_text.Focus();
                phone_errorProvider.SetError(this.phone_text, "Please enter the valid mobile number ");
            }
            // Validate the email address field
            if (Regex.IsMatch(email_text.Text, email_pattern) == false)
            {
                email_text.Focus();
                email_errorProvider.SetError(this.email_text, "Invalid Email");
            }
            // Validate the address field
            if (Regex.IsMatch(address_text.Text, addr_pattern) == false)
            {
                address_text.Focus();
                address_errorProvider.SetError(this.address_text, "Please enter the valid address ");
            }
            // Validate the salary field
            if (Regex.IsMatch(salary_text.Text, salary_pattern) == false)
            {
                salary_text.Focus();
                salary_errorProvider.SetError(this.salary_text, "Please enter the salary within range ");
            }

            else
            {
                // If all validations pass, proceed with database insertion
                SqlConnection conn = new SqlConnection(ConnString);
                if (IsEmailExists(email_text.Text, conn))
                {
                    MessageBox.Show("This employee's details are already stored into the database by the name: "+name_text.Text );
                }
                else if (IsPhoneNoExists(phone_text.Text, conn))
                {
                    MessageBox.Show("This employee's details are already stored into the database by the name: " + name_text.Text);
                }

                else
                {
                    string employee_name = name_text.Text;
                    string employee_phone = phone_text.Text;
                    string employee_email = email_text.Text;
                    string employee_address = address_text.Text;
                    string employee_salary = salary_text.Text;
                    // SQL query to insert employee details into the database
                    string query = "INSERT INTO EmpDetails (e_name, e_phone, e_email, e_address, e_salary, e_photo) " +
                                   "VALUES (@e_name, @e_phone, @e_email, @e_address, @e_salary, @e_photo)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@e_name", employee_name);
                    cmd.Parameters.AddWithValue("@e_phone", employee_phone);
                    cmd.Parameters.AddWithValue("@e_email", employee_email);
                    cmd.Parameters.AddWithValue("@e_address", employee_address);
                    cmd.Parameters.AddWithValue("@e_salary", employee_salary);
                    cmd.Parameters.AddWithValue("@e_photo", SaveEmployeePhoto());
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();

                    // Check the result of the database insertion
                    if (a > 0)
                    {
                        MessageBox.Show("Successfully added into database");
                    }
                    else
                    {
                        MessageBox.Show("Data not added into database");
                    }
                    conn.Close();
                    // Send email with employee details
                    sendEmail();
                }
                
            }
        }

        // Converts the image in the photo_pictureBox control to a byte array.
        // <returns>A byte array representing the image.</returns>
        private byte[] SaveEmployeePhoto()
        {
            // Create a MemoryStream to store the image as a byte array
            MemoryStream ms = new MemoryStream();
            // Save the image in the photo_pictureBox control to the MemoryStream
            photo_pictureBox.Image.Save(ms, photo_pictureBox.Image.RawFormat);
            // Return the byte array representation of the image
            return ms.GetBuffer();
        }

        // Event handler triggered when the focus enters the address_text TextBox.
        // Clears the default text and changes the text color if it matches the default placeholder text.
        private void address_text_Enter(object sender, EventArgs e)
        {
            // Check if the current text in the address_text TextBox is the default placeholder text
            if (address_text.Text == "Address should be between 5 to 50 letters")
            {
                // Clear the text and change the text color to black
                address_text.Text = "";
                address_text.ForeColor= Color.Black;
            }
        }

        // Event handler triggered when a key is pressed in the address_text TextBox.
        //Allows letters, digits, certain special characters, backspace, and space; blocks other characters.
        private void address_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get the pressed character
            char addressCharacter = e.KeyChar;

            if (Char.IsLetterOrDigit(addressCharacter) )
            {
                e.Handled = false;

            }
            // Allow certain special characters (',', '.', '/', '-')
            else if (addressCharacter >= 44 && addressCharacter <= 47)
            {

                e.Handled = false;
            }
            // Allow backspace
            else if (addressCharacter == 8)
            {

                e.Handled = false;
            }
            // Allow backspace
            else if (addressCharacter == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // Event handler triggered when the EmployeeImage_button is clicked.
        // Opens a file dialog to allow the user to select an image file and displays it in the photo_pictureBox control.
        private void EmployeeImage_button_Click(object sender, EventArgs e)
        {
            // Create a new OpenFileDialog instance
            OpenFileDialog fileDialog = new OpenFileDialog();
            // Set the dialog title
            fileDialog.Title = "Select Image";
            // Set the file filter to allow only specific image file types
            fileDialog.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif;*jpeg) | *.png;*.jpg;*.bmp;*.gif;*jpeg";
            // Display the file dialog and check if the user selected a file
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                photo_pictureBox.Image = new Bitmap(fileDialog.FileName);

            }
        }

        private void add_EmployeeDetails_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name_text.Text))
            {
                name_text.Focus();
                name_errorProvider.SetError(this.name_text, "Please fill the name textfield");
            }
            if (Regex.IsMatch(phone_text.Text, phone_pattern) == false)
            {
                phone_text.Focus();
                phone_errorProvider.SetError(this.phone_text, "Please enter the valid mobile number ");
            }
            if (Regex.IsMatch(email_text.Text, email_pattern) == false)
            {
                email_text.Focus();
                email_errorProvider.SetError(this.email_text, "Invalid Email");
            }
            
            if (Regex.IsMatch(address_text.Text, addr_pattern) == false)
            {
                address_text.Focus();
                address_errorProvider.SetError(this.address_text, "Please enter the valid address ");
            }
            if (Regex.IsMatch(salary_text.Text, salary_pattern) == false)
            {
                salary_text.Focus();
                salary_errorProvider.SetError(this.salary_text, "Please enter the salary within range ");
            }
            else
            {
                //Create connection
                SqlConnection conn = new SqlConnection(ConnString);
                if (IsEmailExists(email_text.Text, conn))
                {
                    MessageBox.Show("Email already exists in the database. Please use a different email.");
                }
                if (IsPhoneNoExists(phone_text.Text, conn))
                {
                    MessageBox.Show("Phone number already exists in the database. Please use a different phone no.");
                }
              
                
                else
                {
                    string emp_gender = GetSelectedGender();
                    
                    string emp_id = e_id.Text;
                    string emp_name = name_text.Text;
                    string emp_phone = phone_text.Text;
                    string emp_email = email_text.Text;
                    string emp_address = address_text.Text;
                    string emp_salary = salary_text.Text;
                    byte[] emp_photo = SaveEmployeePhoto();
                    // Execute the query and get the number of affected rows
                    string query = "INSERT INTO EmpDetails (e_name, e_phone, e_email, e_address, e_salary, e_photo, e_gender) " +
                                   "VALUES (@e_name, @e_phone, @e_email, @e_address, @e_salary, @e_photo, @e_gender)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@e_name", emp_name);
                    cmd.Parameters.AddWithValue("@e_phone", emp_phone);
                    cmd.Parameters.AddWithValue("@e_email", emp_email);
                    cmd.Parameters.AddWithValue("@e_address", emp_address);
                    cmd.Parameters.AddWithValue("@e_salary", emp_salary);
                    cmd.Parameters.AddWithValue("@e_photo", emp_photo);
                    cmd.Parameters.AddWithValue("@e_gender", emp_gender);
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();


                    if (a > 0)
                    {
                        MessageBox.Show("Successfully added into database");
                        male_radioButton.Checked = false;
                        female_radioButton.Checked = false;
                        // record_added(emp_id, emp_name, conn);
                        // Update the GridView with the latest data
                        BindGridView();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Data not added into database");
                    }
                    conn.Close();
                }
                
            }

        }
        private string GetSelectedGender()
        {
            if (male_radioButton.Checked)
            {
                return male_radioButton.Text;
            }
            else if (female_radioButton.Checked)
            {
                return female_radioButton.Text;
            }
            else if (other_radioButton.Checked)
            {
                return other_radioButton.Text;
            }
            else
            {
                return "No gender selected";
            }
        }
        //Blank alll the text boxes
        private void ClearTextBoxes()
        {
            name_text.Text = "";
            phone_text.Text = "";
            email_text.Text = "";
            address_text.Text = "";
            salary_text.Text = "";
        }

        /*private string record_added(string id, string name, SqlConnection connection)
        {
            string query = "Select e_id, e_name from EmpDetails where e_id = @e_id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@e_id", id);
            cmd.Parameters.AddWithValue("@e_name", name);
            connection.Open();
            showRecord_label.Text = query;
            connection.Close();
            return showRecord_label.Text;
        }*/


        //Check that email is already exist or not
        private bool IsEmailExists(string email, SqlConnection connection)
        {
            string query = "Select count(*) from EmpDetails where e_email = @e_email";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@e_email", email);
            connection.Open();
            int count = 0;
            count = (int)cmd.ExecuteScalar();

            connection.Close();

            return (count > 0);
        }

        //Check that phone no. exists or not
        private bool IsPhoneNoExists(string phone, SqlConnection connection)
        {
            string query = "Select Count(*) from EmpDetails where e_phone = @e_phone";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@e_phone", phone);
            connection.Open();
            int count = 0;
            count = (int)cmd.ExecuteScalar();

            connection.Close();

            return (count > 0);
        }
 
        private void BindGridView()
        {
            SqlConnection con = new SqlConnection(ConnString);
            string query = "select * from EmpDetails ";
            // Create a new SqlDataAdapter with the query and SqlConnection
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            // Create a new DataTable to store the retrieved data
            DataTable data = new DataTable();
            // Fill the DataTable with data from the SqlDataAdapter
            sda.Fill(data);
            // Set the DataGridView's data source to the DataTable
            dataGridView.DataSource = data;
            // Create a new DataGridViewImageColumn to handle images
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            // Set the DataGridViewImageColumn to the 6th column in the DataGridView
            dgv = (DataGridViewImageColumn)dataGridView.Columns[6];
            // Set the image layout to stretch within the cell
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // Set the DataGridView to automatically adjust column widths to fill the control
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Set the height of each row in the DataGridView
            dataGridView.RowTemplate.Height = 50;
           
        }

        /// <summary>
        /// Event handler for the DataGridView's MouseDoubleClick event.
        /// Populates form controls with data from the selected row in the DataGridView.
        /// </summary>
        
        
        
        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Retrieve the employee ID from the selected row and display it in the appropriate TextBox
            e_id.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            name_text.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            phone_text.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            email_text.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            address_text.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            salary_text.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            photo_pictureBox.Image = GetPhoto((byte[])dataGridView.SelectedRows[0].Cells[6].Value);
           
        }

        // Converts a byte array representing an image into an Image object.
        private Image GetPhoto(byte[] photo)
        {
            // Create a MemoryStream to store the image data from the byte array
            MemoryStream ms = new MemoryStream(photo);
            // Create and return an Image object from the MemoryStream
            return Image.FromStream(ms);
        }

        //Handles the event when the user clicks the "Edit Employee Details" button.
        /// Asks for user confirmation before updating the employee record in the database.
        private void edit_EmployeeDetails_btn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to update record?", "User Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                SqlConnection conn = new SqlConnection(ConnString);
                    string emp_id = e_id.Text;
                    string emp_name = name_text.Text;
                    string emp_phone = phone_text.Text;
                    string emp_email = email_text.Text;
                    string emp_address = address_text.Text;
                    string emp_salary = salary_text.Text;
                    byte[] emp_photo = SaveEmployeePhoto();
                    string beforeupdate_query = "select * from EmpDetails where e_id = @e_id";
                    // SQL query to update employee details in the database
                    string query = "UPDATE EmpDetails SET e_name = @e_name, e_phone = @e_phone, e_email = @e_email, e_address = @e_address, e_salary = @e_salary, e_photo = @e_photo WHERE e_id = @e_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@e_id", emp_id);
                    cmd.Parameters.AddWithValue("@e_name", emp_name);
                    cmd.Parameters.AddWithValue("@e_phone", emp_phone);
                    cmd.Parameters.AddWithValue("@e_email", emp_email);
                    cmd.Parameters.AddWithValue("@e_address", emp_address);
                    cmd.Parameters.AddWithValue("@e_salary", emp_salary);
                    cmd.Parameters.AddWithValue("@e_photo", emp_photo);
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();


                    if (a > 0)
                    {
                        MessageBox.Show("Successfully edited into database");
                        BindGridView();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Data not edited into database");
                    }
                    conn.Close();
                
            }
            else
            {
                MessageBox.Show("You chose not to proceed.");
            }
        }

        // Handles the event when the user clicks the "Delete" button to delete an employee record.
        // Asks the user for confirmation before deleting the record from the database.
        private void delete_EmployeeDetails_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete record?", "User Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(ConnString);

                string emp_id = e_id.Text;
                string emp_name = name_text.Text;
                string emp_phone = phone_text.Text;
                string emp_email = email_text.Text;
                string emp_address = address_text.Text;
                string emp_salary = salary_text.Text;
                byte[] emp_photo = SaveEmployeePhoto();
                // SQL query to delete employee details in the database
                string query = "DELETE from EmpDetails where e_id = @e_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@e_id", emp_id);
                cmd.Parameters.AddWithValue("@e_name", emp_name);
                cmd.Parameters.AddWithValue("@e_phone", emp_phone);
                cmd.Parameters.AddWithValue("@e_email", emp_email);
                cmd.Parameters.AddWithValue("@e_address", emp_address);
                cmd.Parameters.AddWithValue("@e_salary", emp_salary);
                cmd.Parameters.AddWithValue("@e_photo", emp_photo);
                conn.Open();
                int a = cmd.ExecuteNonQuery();


                if (a > 0)
                {
                    male_radioButton.Checked = false;
                    female_radioButton.Checked = false;
                    MessageBox.Show("Successfully deleted into database");
                    BindGridView();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Data not deleted into database");
                }
                conn.Close();


            }
            else
            {
                MessageBox.Show("You chose not to proceed.");
            }
            
        }
        
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void male_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(male_radioButton.Checked == true)
            {
               
            }
        }
    }
}
