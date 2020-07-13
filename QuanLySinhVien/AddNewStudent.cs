using System;
using System.Windows.Forms;
using QuanLySinhVien.Properties.Model;

namespace QuanLySinhVien
{
    public partial class AddNewStudent : Form
    {
        private QuanLySinhVien qlsv;
        private TextBox tbxClassIdTranfer;
        private ClassRoom classRoom;
        public AddNewStudent(Form callingForm, TextBox tbxClassIdTranfer)
        {
            this.qlsv= callingForm as QuanLySinhVien;
            this.tbxClassIdTranfer = tbxClassIdTranfer;
            InitializeComponent();
        }


        private void btnCancelAddStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOKAddStudent_Click(object sender, EventArgs e)
        {
            string idSV = this.tbxStudentID.Text;
            string nameSV = this.tbxStudentName.Text;
            string genderSV = this.tbxStudentGender.Text;
            string addressSV = this.tbxStudentAddress.Text;
            string classID = this.tbxClassId.Text;
            int phone= 0;
            try
            {
                 phone = Int32.Parse(this.tbxPhone.Text);  
            }
           catch
           {
               MessageBox.Show("Error format phone number");

           }

            if (idSV =="" || nameSV== "" || genderSV =="" || addressSV == "" || classID== "" || phone == 0)
            {
                MessageBox.Show("Enter all fields are required.");
            }
            else
            {
                Student student =new Student(idSV, nameSV, genderSV, addressSV, classID, phone);
                classRoom= qlsv._processManagement.getClassRoom(this.tbxClassIdTranfer.Text);
                MessageBox.Show(this.tbxClassIdTranfer.Text);
                classRoom.addStudent(student);
                qlsv.getDataGridView().Rows.Clear();
                qlsv.getDataGridView().Refresh();
                qlsv.drawDataGridView(classRoom,0);

            }
        }
        
        
    }
}