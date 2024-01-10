namespace EmployeeDetails
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.title = new System.Windows.Forms.Label();
            this.e_name = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.e_email = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.e_address = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.e_gender = new System.Windows.Forms.Label();
            this.e_salary = new System.Windows.Forms.Label();
            this.salary_text = new System.Windows.Forms.TextBox();
            this.name_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phone_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.email_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.address_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gender_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.salary_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.other_radioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.address_errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.image_button = new System.Windows.Forms.Button();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.photo_pictureBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.Label();
            this.e_id = new System.Windows.Forms.TextBox();
            this.showRecord_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.name_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.address_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.address_errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(289, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(236, 32);
            this.title.TabIndex = 0;
            this.title.Text = "Employee Details";
            // 
            // e_name
            // 
            this.e_name.AutoSize = true;
            this.e_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_name.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.e_name.Location = new System.Drawing.Point(23, 91);
            this.e_name.Name = "e_name";
            this.e_name.Size = new System.Drawing.Size(80, 24);
            this.e_name.TabIndex = 1;
            this.e_name.Text = "Name :";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(147, 91);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(289, 21);
            this.name_text.TabIndex = 2;
            this.name_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_text_KeyPress);
            this.name_text.Leave += new System.EventHandler(this.name_text_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone No :";
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(147, 134);
            this.phone_text.MaxLength = 10;
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(289, 21);
            this.phone_text.TabIndex = 4;
            this.phone_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_text_KeyPress);
            this.phone_text.Leave += new System.EventHandler(this.phone_text_Leave);
            // 
            // e_email
            // 
            this.e_email.AutoSize = true;
            this.e_email.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.e_email.ForeColor = System.Drawing.Color.Black;
            this.e_email.Location = new System.Drawing.Point(23, 177);
            this.e_email.Name = "e_email";
            this.e_email.Size = new System.Drawing.Size(78, 24);
            this.e_email.TabIndex = 5;
            this.e_email.Text = "Emali :";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(147, 177);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(289, 21);
            this.email_text.TabIndex = 6;
            this.email_text.Leave += new System.EventHandler(this.email_text_Leave);
            // 
            // e_address
            // 
            this.e_address.AutoSize = true;
            this.e_address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.e_address.ForeColor = System.Drawing.Color.Black;
            this.e_address.Location = new System.Drawing.Point(21, 223);
            this.e_address.Name = "e_address";
            this.e_address.Size = new System.Drawing.Size(108, 24);
            this.e_address.TabIndex = 7;
            this.e_address.Text = "Address :";
            // 
            // address_text
            // 
            this.address_text.ForeColor = System.Drawing.Color.Silver;
            this.address_text.Location = new System.Drawing.Point(147, 223);
            this.address_text.Multiline = true;
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(289, 82);
            this.address_text.TabIndex = 8;
            this.address_text.Text = "Address should be between 5 to 50 letters";
            this.address_text.Enter += new System.EventHandler(this.address_text_Enter);
            this.address_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.address_text_KeyPress);
            this.address_text.Leave += new System.EventHandler(this.address_text_Leave);
            // 
            // e_gender
            // 
            this.e_gender.AutoSize = true;
            this.e_gender.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.e_gender.ForeColor = System.Drawing.Color.Black;
            this.e_gender.Location = new System.Drawing.Point(23, 321);
            this.e_gender.Name = "e_gender";
            this.e_gender.Size = new System.Drawing.Size(97, 24);
            this.e_gender.TabIndex = 9;
            this.e_gender.Text = "Gender :";
            // 
            // e_salary
            // 
            this.e_salary.AutoSize = true;
            this.e_salary.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.e_salary.ForeColor = System.Drawing.Color.Black;
            this.e_salary.Location = new System.Drawing.Point(23, 373);
            this.e_salary.Name = "e_salary";
            this.e_salary.Size = new System.Drawing.Size(85, 24);
            this.e_salary.TabIndex = 11;
            this.e_salary.Text = "Salary :";
            // 
            // salary_text
            // 
            this.salary_text.Location = new System.Drawing.Point(147, 373);
            this.salary_text.MaxLength = 7;
            this.salary_text.Name = "salary_text";
            this.salary_text.Size = new System.Drawing.Size(289, 21);
            this.salary_text.TabIndex = 12;
            this.salary_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_text_KeyPress);
            this.salary_text.Leave += new System.EventHandler(this.salary_text_Leave);
            // 
            // name_errorProvider
            // 
            this.name_errorProvider.ContainerControl = this;
            // 
            // phone_errorProvider
            // 
            this.phone_errorProvider.ContainerControl = this;
            // 
            // email_errorProvider
            // 
            this.email_errorProvider.ContainerControl = this;
            // 
            // address_errorProvider
            // 
            this.address_errorProvider.ContainerControl = this;
            // 
            // gender_errorProvider
            // 
            this.gender_errorProvider.ContainerControl = this;
            // 
            // salary_errorProvider
            // 
            this.salary_errorProvider.ContainerControl = this;
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.female_radioButton.ForeColor = System.Drawing.Color.DimGray;
            this.female_radioButton.Location = new System.Drawing.Point(231, 324);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(77, 22);
            this.female_radioButton.TabIndex = 14;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Female";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // other_radioButton
            // 
            this.other_radioButton.AutoSize = true;
            this.other_radioButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.other_radioButton.ForeColor = System.Drawing.Color.DimGray;
            this.other_radioButton.Location = new System.Drawing.Point(323, 324);
            this.other_radioButton.Name = "other_radioButton";
            this.other_radioButton.Size = new System.Drawing.Size(67, 22);
            this.other_radioButton.TabIndex = 15;
            this.other_radioButton.TabStop = true;
            this.other_radioButton.Text = "Other";
            this.other_radioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(348, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.submit_Send_EmployeeDetails_Click);
            // 
            // address_errorProvider1
            // 
            this.address_errorProvider1.ContainerControl = this;
            // 
            // image_button
            // 
            this.image_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.address_errorProvider1.SetIconAlignment(this.image_button, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.image_button.Location = new System.Drawing.Point(541, 319);
            this.image_button.Name = "image_button";
            this.image_button.Size = new System.Drawing.Size(83, 26);
            this.image_button.TabIndex = 19;
            this.image_button.Text = "Add Here";
            this.image_button.UseVisualStyleBackColor = true;
            this.image_button.Click += new System.EventHandler(this.EmployeeImage_button_Click);
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.male_radioButton.ForeColor = System.Drawing.Color.DimGray;
            this.male_radioButton.Location = new System.Drawing.Point(147, 324);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(60, 22);
            this.male_radioButton.TabIndex = 17;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            this.male_radioButton.CheckedChanged += new System.EventHandler(this.male_radioButton_CheckedChanged);
            // 
            // photo_pictureBox
            // 
            this.photo_pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.photo_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("photo_pictureBox.Image")));
            this.photo_pictureBox.Location = new System.Drawing.Point(518, 161);
            this.photo_pictureBox.Name = "photo_pictureBox";
            this.photo_pictureBox.Size = new System.Drawing.Size(129, 144);
            this.photo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo_pictureBox.TabIndex = 18;
            this.photo_pictureBox.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.add_button.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(742, 134);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(102, 41);
            this.add_button.TabIndex = 21;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_EmployeeDetails_btn_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.edit_button.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.edit_button.Location = new System.Drawing.Point(742, 209);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(102, 38);
            this.edit_button.TabIndex = 22;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_EmployeeDetails_btn_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.delete_button.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(742, 285);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(102, 37);
            this.delete_button.TabIndex = 23;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_EmployeeDetails_btn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(65, 504);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(763, 201);
            this.dataGridView.TabIndex = 24;
            this.dataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDoubleClick);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(526, 127);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(37, 29);
            this.id.TabIndex = 26;
            this.id.Text = "ID";
            // 
            // e_id
            // 
            this.e_id.Location = new System.Drawing.Point(569, 130);
            this.e_id.Name = "e_id";
            this.e_id.ReadOnly = true;
            this.e_id.Size = new System.Drawing.Size(61, 21);
            this.e_id.TabIndex = 27;
            // 
            // showRecord_label
            // 
            this.showRecord_label.AutoSize = true;
            this.showRecord_label.Location = new System.Drawing.Point(308, 467);
            this.showRecord_label.Name = "showRecord_label";
            this.showRecord_label.Size = new System.Drawing.Size(0, 15);
            this.showRecord_label.TabIndex = 28;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 755);
            this.Controls.Add(this.showRecord_label);
            this.Controls.Add(this.e_id);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.image_button);
            this.Controls.Add(this.photo_pictureBox);
            this.Controls.Add(this.male_radioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.other_radioButton);
            this.Controls.Add(this.female_radioButton);
            this.Controls.Add(this.salary_text);
            this.Controls.Add(this.e_salary);
            this.Controls.Add(this.e_gender);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.e_address);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.e_email);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.e_name);
            this.Controls.Add(this.title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "EmployeeDetails";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.name_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.address_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.address_errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label e_name;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.Label e_email;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label e_address;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label e_gender;
        private System.Windows.Forms.Label e_salary;
        private System.Windows.Forms.TextBox salary_text;
        private System.Windows.Forms.ErrorProvider name_errorProvider;
        private System.Windows.Forms.ErrorProvider phone_errorProvider;
        private System.Windows.Forms.ErrorProvider email_errorProvider;
        private System.Windows.Forms.ErrorProvider address_errorProvider;
        private System.Windows.Forms.ErrorProvider gender_errorProvider;
        private System.Windows.Forms.ErrorProvider salary_errorProvider;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.RadioButton other_radioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider address_errorProvider1;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.Button image_button;
        private System.Windows.Forms.PictureBox photo_pictureBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox e_id;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label showRecord_label;
    }
}

