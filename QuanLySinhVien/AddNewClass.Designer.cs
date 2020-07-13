using System;
using System.ComponentModel;

namespace QuanLySinhVien
{
    partial class AddNewClass
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
            this.lbAddClass = new System.Windows.Forms.Label();
            this.lbClassId = new System.Windows.Forms.Label();
            this.lbClassName = new System.Windows.Forms.Label();
            this.tbxClassId = new System.Windows.Forms.TextBox();
            this.tbxClassName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAddClass
            // 
            this.lbAddClass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbAddClass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbAddClass.Location = new System.Drawing.Point(78, 13);
            this.lbAddClass.Name = "lbAddClass";
            this.lbAddClass.Size = new System.Drawing.Size(152, 32);
            this.lbAddClass.TabIndex = 0;
            this.lbAddClass.Text = "ADD CLASSROOM";
            // 
            // lbClassId
            // 
            this.lbClassId.Location = new System.Drawing.Point(20, 61);
            this.lbClassId.Name = "lbClassId";
            this.lbClassId.Size = new System.Drawing.Size(58, 20);
            this.lbClassId.TabIndex = 1;
            this.lbClassId.Text = "Class Id:";
            // 
            // lbClassName
            // 
            this.lbClassName.Location = new System.Drawing.Point(20, 100);
            this.lbClassName.Name = "lbClassName";
            this.lbClassName.Size = new System.Drawing.Size(74, 19);
            this.lbClassName.TabIndex = 2;
            this.lbClassName.Text = "Class Name:";
            // 
            // tbxClassId
            // 
            this.tbxClassId.Location = new System.Drawing.Point(102, 59);
            this.tbxClassId.Name = "tbxClassId";
            this.tbxClassId.Size = new System.Drawing.Size(154, 20);
            this.tbxClassId.TabIndex = 3;
            // 
            // tbxClassName
            // 
            this.tbxClassName.Location = new System.Drawing.Point(102, 97);
            this.tbxClassName.Name = "tbxClassName";
            this.tbxClassName.Size = new System.Drawing.Size(154, 20);
            this.tbxClassName.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOK.Location = new System.Drawing.Point(223, 151);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(32, 22);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(102, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 22);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddNewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 199);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxClassName);
            this.Controls.Add(this.tbxClassId);
            this.Controls.Add(this.lbClassName);
            this.Controls.Add(this.lbClassId);
            this.Controls.Add(this.lbAddClass);
            this.Name = "AddNewClass";
            this.Text = "AddNewClass";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbAddClass;
        private System.Windows.Forms.Label lbClassId;
        private System.Windows.Forms.Label lbClassName;
        private System.Windows.Forms.TextBox tbxClassId;
        private System.Windows.Forms.TextBox tbxClassName;

        #endregion
    }
}