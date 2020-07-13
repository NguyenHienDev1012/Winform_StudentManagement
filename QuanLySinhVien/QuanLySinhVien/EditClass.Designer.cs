using System;
using System.ComponentModel;

namespace QuanLySinhVien
{
    partial class EditClass
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
            this.lbEditClassRoom = new System.Windows.Forms.Label();
            this.lbClassID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDClass = new System.Windows.Forms.TextBox();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEditClassRoom
            // 
            this.lbEditClassRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbEditClassRoom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbEditClassRoom.Location = new System.Drawing.Point(80, 12);
            this.lbEditClassRoom.Name = "lbEditClassRoom";
            this.lbEditClassRoom.Size = new System.Drawing.Size(174, 31);
            this.lbEditClassRoom.TabIndex = 0;
            this.lbEditClassRoom.Text = "EDIT CLASSROOM";
            // 
            // lbClassID
            // 
            this.lbClassID.Location = new System.Drawing.Point(20, 58);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(75, 30);
            this.lbClassID.TabIndex = 1;
            this.lbClassID.Text = "Class ID:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class Name:";
            // 
            // tbIDClass
            // 
            this.tbIDClass.Location = new System.Drawing.Point(101, 55);
            this.tbIDClass.Name = "tbIDClass";
            this.tbIDClass.Size = new System.Drawing.Size(186, 20);
            this.tbIDClass.TabIndex = 3;
            // 
            // tbClassName
            // 
            this.tbClassName.Location = new System.Drawing.Point(101, 109);
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Size = new System.Drawing.Size(186, 20);
            this.tbClassName.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOK.Location = new System.Drawing.Point(242, 171);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(45, 25);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(101, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbClassName);
            this.Controls.Add(this.tbIDClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbClassID);
            this.Controls.Add(this.lbEditClassRoom);
            this.Name = "EditClass";
            this.Text = "EditClass";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.Label lbEditClassRoom;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.TextBox tbIDClass;

        #endregion
    }
}