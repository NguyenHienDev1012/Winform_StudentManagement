using System;
using System.Windows.Forms;
using QuanLySinhVien.Properties.Dao;
using QuanLySinhVien.Properties.Model;

namespace QuanLySinhVien
{
    public partial class AddNewClass : Form
    {
        private QuanLySinhVien _qlsv;
        public AddNewClass(Form  form)
        {
            _qlsv= form as QuanLySinhVien;
            InitializeComponent();
        }

        private void btnOK_click(Object sender, EventArgs e)
        {
            string classId = tbxClassId.Text;
            string className = tbxClassName.Text;
            ClassRoom _classRoom=new ClassRoom(classId,className);
            _qlsv._processManagement.addClassRoom(_classRoom);
            this._qlsv._flowLayoutPanel().Controls.Clear();
            this._qlsv.loadListClassRoom();
            this.Close();
        }

        private void btnCancel_click(Object sender, EventArgs e)
        {
            this.Close();
        }
    }
}