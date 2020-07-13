using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class EditClass : Form
    {
        private QuanLySinhVien _qlsv;
        public EditClass(Form form)
        { 
            _qlsv = form as QuanLySinhVien;
            InitializeComponent();
        }

        public void btnCancel_Click(Object sender, EventArgs e)
        {
            this.Close();
            
        }

        public void btnOK_Click(Object sender, EventArgs e)
        {
            string classId = this.tbIDClass.Text;
            string className = this.tbClassName.Text;
            _qlsv._processManagement.editClassRoom(classId, className);
            this.Close();
        }
        public TextBox getTexBoxClassID()
        {
            return this.tbIDClass;
        }
        
        public TextBox getTexBoxClassName()
        {
            return this.tbClassName;
        }
    }
}