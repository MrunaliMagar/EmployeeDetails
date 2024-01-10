namespace EmployeeDetails
{
    partial class EmployeeDetail
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
            this.sender = new System.Windows.Forms.Label();
            this.sender_textBox = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.Label();
            this.body_textBox = new System.Windows.Forms.TextBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.receiver = new System.Windows.Forms.Label();
            this.receiver_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sender
            // 
            this.sender.AutoSize = true;
            this.sender.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sender.Location = new System.Drawing.Point(89, 84);
            this.sender.Name = "sender";
            this.sender.Size = new System.Drawing.Size(94, 29);
            this.sender.TabIndex = 0;
            this.sender.Text = "Sender";
            // 
            // sender_textBox
            // 
            this.sender_textBox.Location = new System.Drawing.Point(309, 93);
            this.sender_textBox.Name = "sender_textBox";
            this.sender_textBox.Size = new System.Drawing.Size(335, 20);
            this.sender_textBox.TabIndex = 1;
            this.sender_textBox.Text = "mrunalipmagar@gmail.com";
            this.sender_textBox.TextChanged += new System.EventHandler(this.sender_textBox_TextChanged);
            // 
            // body
            // 
            this.body.AutoSize = true;
            this.body.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.Location = new System.Drawing.Point(89, 199);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(73, 29);
            this.body.TabIndex = 2;
            this.body.Text = "Body";
            this.body.Click += new System.EventHandler(this.body_Click);
            // 
            // body_textBox
            // 
            this.body_textBox.Location = new System.Drawing.Point(309, 183);
            this.body_textBox.Multiline = true;
            this.body_textBox.Name = "body_textBox";
            this.body_textBox.Size = new System.Drawing.Size(335, 123);
            this.body_textBox.TabIndex = 3;
            this.body_textBox.TextChanged += new System.EventHandler(this.body_textBox_TextChanged);
            // 
            // confirm_button
            // 
            this.confirm_button.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_button.Location = new System.Drawing.Point(389, 346);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(143, 53);
            this.confirm_button.TabIndex = 4;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // receiver
            // 
            this.receiver.AutoSize = true;
            this.receiver.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiver.Location = new System.Drawing.Point(89, 138);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(111, 29);
            this.receiver.TabIndex = 5;
            this.receiver.Text = "Receiver";
            this.receiver.Click += new System.EventHandler(this.receiver_Click);
            // 
            // receiver_textBox
            // 
            this.receiver_textBox.Location = new System.Drawing.Point(309, 138);
            this.receiver_textBox.Name = "receiver_textBox";
            this.receiver_textBox.Size = new System.Drawing.Size(335, 20);
            this.receiver_textBox.TabIndex = 6;
            this.receiver_textBox.TextChanged += new System.EventHandler(this.receiver_textBox_TextChanged);
            // 
            // EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiver_textBox);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.body_textBox);
            this.Controls.Add(this.body);
            this.Controls.Add(this.sender_textBox);
            this.Controls.Add(this.sender);
            this.Name = "EmployeeDetail";
            this.Text = "EmployeeDetail";
            this.Load += new System.EventHandler(this.EmployeeDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sender;
        private System.Windows.Forms.TextBox sender_textBox;
        private System.Windows.Forms.Label body;
        private System.Windows.Forms.TextBox body_textBox;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Label receiver;
        private System.Windows.Forms.TextBox receiver_textBox;
    }
}