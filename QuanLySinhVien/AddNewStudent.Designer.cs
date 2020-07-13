using System;
using System.ComponentModel;

namespace QuanLySinhVien
{
    partial class AddNewStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lbAddStudent = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbClassId = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.tbxStudentGender = new System.Windows.Forms.TextBox();
            this.tbxStudentAddress = new System.Windows.Forms.TextBox();
            this.tbxClassId = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.btnAddStudentOK = new System.Windows.Forms.Button();
            this.btnCancelAddStudent = new System.Windows.Forms.Button();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.tbxStudentID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAddStudent
            // 
            this.lbAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbAddStudent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbAddStudent.Location = new System.Drawing.Point(123, 9);
            this.lbAddStudent.Name = "lbAddStudent";
            this.lbAddStudent.Size = new System.Drawing.Size(203, 25);
            this.lbAddStudent.TabIndex = 0;
            this.lbAddStudent.Text = "ADD STUDENT";
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(33, 85);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 21);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            // 
            // lbGender
            // 
            this.lbGender.Location = new System.Drawing.Point(33, 132);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(55, 21);
            this.lbGender.TabIndex = 2;
            this.lbGender.Text = "Gender:";
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(33, 169);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(55, 21);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Address:";
            // 
            // lbClassId
            // 
            this.lbClassId.Location = new System.Drawing.Point(33, 212);
            this.lbClassId.Name = "lbClassId";
            this.lbClassId.Size = new System.Drawing.Size(55, 21);
            this.lbClassId.TabIndex = 4;
            this.lbClassId.Text = " Class ID:";
            // 
            // lbPhone
            // 
            this.lbPhone.Location = new System.Drawing.Point(33, 256);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(55, 21);
            this.lbPhone.TabIndex = 5;
            this.lbPhone.Text = "Phone:";
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Location = new System.Drawing.Point(116, 82);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(210, 20);
            this.tbxStudentName.TabIndex = 6;
            // 
            // tbxStudentGender
            // 
            this.tbxStudentGender.Location = new System.Drawing.Point(116, 129);
            this.tbxStudentGender.Name = "tbxStudentGender";
            this.tbxStudentGender.Size = new System.Drawing.Size(210, 20);
            this.tbxStudentGender.TabIndex = 7;
            // 
            // tbxStudentAddress
            // 
            this.tbxStudentAddress.Location = new System.Drawing.Point(116, 166);
            this.tbxStudentAddress.Name = "tbxStudentAddress";
            this.tbxStudentAddress.Size = new System.Drawing.Size(210, 20);
            this.tbxStudentAddress.TabIndex = 8;
            // 
            // tbxClassId
            // 
            this.tbxClassId.Location = new System.Drawing.Point(116, 209);
            this.tbxClassId.Name = "tbxClassId";
            this.tbxClassId.Size = new System.Drawing.Size(210, 20);
            this.tbxClassId.TabIndex = 9;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(116, 253);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(210, 20);
            this.tbxPhone.TabIndex = 10;
            // 
            // btnAddStudentOK
            // 
            this.btnAddStudentOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddStudentOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudentOK.Location = new System.Drawing.Point(276, 303);
            this.btnAddStudentOK.Name = "btnAddStudentOK";
            this.btnAddStudentOK.Size = new System.Drawing.Size(50, 27);
            this.btnAddStudentOK.TabIndex = 11;
            this.btnAddStudentOK.Text = "OK";
            this.btnAddStudentOK.Click+= new EventHandler(this.btnOKAddStudent_Click);
            this.btnAddStudentOK.UseVisualStyleBackColor = false;
            // 
            // btnCancelAddStudent
            // 
            this.btnCancelAddStudent.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCancelAddStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelAddStudent.Location = new System.Drawing.Point(116, 306);
            this.btnCancelAddStudent.Name = "btnCancelAddStudent";
            this.btnCancelAddStudent.Size = new System.Drawing.Size(52, 24);
            this.btnCancelAddStudent.TabIndex = 12;
            this.btnCancelAddStudent.Text = "Cancel";
            this.btnCancelAddStudent.UseVisualStyleBackColor = false;
            this.btnCancelAddStudent.Click += new System.EventHandler(this.btnCancelAddStudent_Click);
            // 
            // lbStudentID
            // 
            this.lbStudentID.Location = new System.Drawing.Point(33, 50);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(55, 21);
            this.lbStudentID.TabIndex = 13;
            this.lbStudentID.Text = "ID:";
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Location = new System.Drawing.Point(116, 47);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(210, 20);
            this.tbxStudentID.TabIndex = 14;
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 394);
            this.Controls.Add(this.tbxStudentID);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.btnCancelAddStudent);
            this.Controls.Add(this.btnAddStudentOK);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxClassId);
            this.Controls.Add(this.tbxStudentAddress);
            this.Controls.Add(this.tbxStudentGender);
            this.Controls.Add(this.tbxStudentName);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbClassId);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAddStudent);
            this.Name = "AddNewStudent";
            this.Text = "AddNewStudent";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAddStudentOK;
        private System.Windows.Forms.Button btnCancelAddStudent;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbAddStudent;
        private System.Windows.Forms.Label lbClassId;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.TextBox tbxClassId;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxStudentAddress;
        private System.Windows.Forms.TextBox tbxStudentGender;
        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.TextBox tbxStudentName;

        #endregion
    }
}