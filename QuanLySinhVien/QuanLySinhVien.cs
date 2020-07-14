using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Properties.Dao;
using QuanLySinhVien.Properties.Model;

namespace QuanLySinhVien
{
    public partial class QuanLySinhVien : Form
    {
        public  ProcessManagement _processManagement;
        private System.Windows.Forms.Button []btnClassRoom;
        private System.Windows.Forms.CheckBox[] cbxClassRoom;
        private DataGridView dataGridViewStudents;
        private DataGridViewColumn order;
        private DataGridViewColumn ID;
        private DataGridViewColumn Name;
        private DataGridViewColumn Dob;
        private DataGridViewColumn Address;
        private DataGridViewColumn ClassId;
        private DataGridViewColumn Phone;
        
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Button btnClearStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnEditStudent;
        
        private Label lbClass= new Label();
        
        private TextBox _tbxEditIdSV;
        private TextBox _tbxEditNameSV;
        private TextBox _tbxEditDob;
        private TextBox _tbxEditAddress;
        private TextBox _tbxEditClassID;
        private TextBox _tbxEditPhoneNuber;
        
        private Label _lbEditIdSV;
        private Label _lbEditNameSV;
        private Label _lbEditDob;
        private Label _lbEditAddress;
        private Label _lbEditClassID;
        private Label _lbEditPhoneNuber;
        
        
        
        public QuanLySinhVien()
        {
             InitializeComponent();
            _processManagement =new ProcessManagement();
             loadListClassRoom();
             dataGridViewStudents=new DataGridView();
             dataGridViewStudents.AutoSize = true;
             initFieldToEdit();
             this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
             // dataGridViewStudents
             // 
             this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
             this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.order, this.ID, this.Name, this.Dob, this.Address, this.ClassId, this.Phone});
             this.dataGridViewStudents.Location = new System.Drawing.Point(137, 142);
             this.dataGridViewStudents.Name = "dataGridViewStudents";
             this.dataGridViewStudents.Size = new System.Drawing.Size(655, 45);
             this.dataGridViewStudents.TabIndex = 4;

             ((System.ComponentModel.ISupportInitialize) (this.dataGridViewStudents)).BeginInit();
             // STT
             this.order.HeaderText = "STT";
             this.order.Name = "STT";
             // ID
             this.ID.HeaderText = "ID";
             this.ID.Name = "ID";
             // Name
             this.Name.HeaderText = "Name";
             this.Name.Name = "Name";
             // Dob
             this.Dob.HeaderText = "Gender";
             this.Dob.Name = "Gender";
             // Address
             this.Address.HeaderText = "Address";
             this.Address.Name = "Address";
             // ClassId
             this.ClassId.HeaderText = "Class ID";
             this.ClassId.Name = "ClassId";
             // Phone
             this.Phone.HeaderText = "Phone";
             this.Phone.Name = "Phone";
             //
        }

        public delegate void MyEventHandle(Object sender, EventArgs e);
       
        public  void loadListClassRoom()
        { 
            cbxClassRoom = new CheckBox [_processManagement.ListClasses.Count];
            btnClassRoom =new Button[_processManagement.ListClasses.Count];
            for (int i = 0; i < _processManagement.ListClasses.Count; i++)
            {
                
                btnClassRoom[i] =new Button();
                cbxClassRoom[i] =new CheckBox();
                
                this.btnClassRoom[i].Location = new System.Drawing.Point(3, 3);
                this.btnClassRoom[i].Name = "btnClass";
                this.btnClassRoom[i].Size = new System.Drawing.Size(105, 46);
                this.btnClassRoom[i].TabIndex = i;
                this.btnClassRoom[i].Text = ""+_processManagement.ListClasses[i].Id;
                this.btnClassRoom[i].UseVisualStyleBackColor = true;
                this.btnClassRoom[i].Click+= new EventHandler(btnClassRoom_click);

                this.cbxClassRoom[i].Location = new System.Drawing.Point(3, 3);
                this.cbxClassRoom[i].Name = "checkBox1";
                this.cbxClassRoom[i].Size = new System.Drawing.Size(20, 15);
                this.cbxClassRoom[i].TabIndex = i;
                this.cbxClassRoom[i].Text = "cbxDeleteClass";
                this.cbxClassRoom[i].UseVisualStyleBackColor = true;
                this.cbxClassRoom[i].Click+=new EventHandler(btnCbxClassRoom_click);
                this.flPanelClasses.Controls.Add(this.btnClassRoom[i]);
                this.flPanelClasses.Controls.Add(cbxClassRoom[i]);
            }
            
        }

        public FlowLayoutPanel _flowLayoutPanel()
        {
            return this.flPanelClasses;
        }

        public DataGridView getDataGridView()
        {
            return this.dataGridViewStudents;
        }
        private void btnClassRoom_click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.lbClass.Visible = true;
            lbClass.Size=new Size(300,50);
            int tabIndex = btn.TabIndex;
            ClassRoom classRoom= null;
            drawDataGridView(classRoom,tabIndex);
           
        }

        public void drawDataGridView(ClassRoom _classRoom,int  tabIndex)
        {
            if (_classRoom == null)
            {
                _classRoom = _processManagement.ListClasses[tabIndex];
            }

            lbClass.Text = "Class name: "+_classRoom.Name+"\n";
            lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));

            int count = 0;
            foreach (var student in _classRoom.ListStudent)
            {
                count ++;
                this.panelAction.Controls.Clear();
                this.initButtonStudentAction();
                this.Controls.Add(lbClass);
                lbClass.Location = new System.Drawing.Point(236, 50);
                flPanelClasses.Controls.Clear();
                dataGridViewStudents.Size=new Size(600, 150);
                this.flPanelClasses.Controls.Add(this.dataGridViewStudents);
                ((System.ComponentModel.ISupportInitialize) (this.dataGridViewStudents)).EndInit();
                string[] row = { ""+count,""+student.Id, ""+student.Name, ""+student.Gender, ""+student.Address, ""+student.ClassId, ""+student.Phone};
                dataGridViewStudents.Rows.Add(row);
                getRows(0);
            }

        }
        
        private void dataGridViewStudent_CellDoubleClick(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows) 
            {
                this._tbxEditIdSV.Text= row.Cells[1].Value.ToString();
                this._tbxEditNameSV.Text= row.Cells[2].Value.ToString();
                this._tbxEditDob.Text= row.Cells[3].Value.ToString();
                this._tbxEditAddress.Text= row.Cells[4].Value.ToString();
                this._tbxEditClassID.Text= row.Cells[5].Value.ToString();
                this._tbxEditPhoneNuber.Text= row.Cells[6].Value.ToString();
            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0&&e.RowIndex<this.dataGridViewStudents.RowCount-1)
            {
                getRows(e.RowIndex);
            }
        }

        private void getRows(int RowIndex)
        {
            DataGridViewRow row = this.dataGridViewStudents.Rows[RowIndex];
            this._tbxEditIdSV.Text= row.Cells[1].Value.ToString();
            this._tbxEditNameSV.Text= row.Cells[2].Value.ToString();
            this._tbxEditDob.Text= row.Cells[3].Value.ToString();
            this._tbxEditAddress.Text= row.Cells[4].Value.ToString();
            this._tbxEditClassID.Text= row.Cells[5].Value.ToString();
            this._tbxEditPhoneNuber.Text= row.Cells[6].Value.ToString();
        }

        private void initButtonStudentAction()
        {
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnAddStudent  = new System.Windows.Forms.Button();
            this.btnClearStudent= new System.Windows.Forms.Button();
            this.btnSaveStudent= new System.Windows.Forms.Button();


            this.panelAction.Controls.Add(this.btnAddStudent);
            this.panelAction.Controls.Add(this.btnClearStudent);
            this.panelAction.Controls.Add(this.btnEditStudent);
            this.panelAction.Controls.Add(this.btnSaveStudent);
            this.panelAction.Controls.Add(this.btnDeleteStudent);

            this.btnAddStudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudent.Location = new System.Drawing.Point(30, 16);
            this.btnAddStudent.Name = "btnAdd";
            this.btnAddStudent.Size = new System.Drawing.Size(61, 29);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click+=new EventHandler(this.btnAddStudent_click);


            this.btnClearStudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearStudent.Location = new System.Drawing.Point(120, 16);
            this.btnClearStudent.Name = "btnEditStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(61, 29);
            this.btnClearStudent.TabIndex = 1;
            this.btnClearStudent.Text = "Clear";
            this.btnClearStudent.UseVisualStyleBackColor = false;
            this.btnClearStudent.Click+=new EventHandler(this.btnClearStudent_click);
            
            this.btnEditStudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditStudent.Location = new System.Drawing.Point(210, 16);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(61, 29);
            this.btnEditStudent.TabIndex = 1;
            this.btnEditStudent.Text = "Edit";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click+=new EventHandler(this.btnEditStudent_click);
            
            this.btnSaveStudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveStudent.Location = new System.Drawing.Point(300, 16);
            this.btnSaveStudent.Name = "btnEditStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(61, 29);
            this.btnSaveStudent.TabIndex = 1;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            this.btnSaveStudent.Click+=new EventHandler(this.btnSaveStudent_click);


            this.btnDeleteStudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteStudent.Location = new System.Drawing.Point(390, 16);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(61, 29);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click+=new EventHandler(this.btnDeleteStudent_click);


            // this.dataGridViewStudents.Click+=new EventHandler(this.dataGridViewStudent_CellDoubleClick);
            this.dataGridViewStudents.CellClick+=new DataGridViewCellEventHandler(dataGridViewStudent_CellClick);
            
        }

        public void initFieldToEdit()
        {
             _tbxEditIdSV= new System.Windows.Forms.TextBox();
            _tbxEditNameSV= new System.Windows.Forms.TextBox();
            _tbxEditDob= new System.Windows.Forms.TextBox();
            _tbxEditAddress= new System.Windows.Forms.TextBox();
             _tbxEditClassID= new System.Windows.Forms.TextBox();
            _tbxEditPhoneNuber= new System.Windows.Forms.TextBox();
            
            _tbxEditIdSV.Enabled = false;
            _tbxEditNameSV.Enabled = false; 
            _tbxEditDob.Enabled = false;
            _tbxEditAddress.Enabled = false; 
            _tbxEditClassID.Enabled = false;
            _tbxEditPhoneNuber.Enabled = false;
            
            this._tbxEditIdSV.Location = new System.Drawing.Point(290, 80);
            this._tbxEditIdSV.Size = new System.Drawing.Size(154, 20);
            this._tbxEditIdSV.TabIndex = 3;
            
            this._tbxEditNameSV.Location = new System.Drawing.Point(290, 110);
            this._tbxEditNameSV.Size = new System.Drawing.Size(154, 20);
            this._tbxEditNameSV.TabIndex = 3;

            this._tbxEditDob.Location = new System.Drawing.Point(290, 140);
            this._tbxEditDob.Size = new System.Drawing.Size(154, 20);
            this._tbxEditDob.TabIndex = 3;

            this._tbxEditAddress.Location = new System.Drawing.Point(600, 80);
            this._tbxEditAddress.Size = new System.Drawing.Size(154, 20);

            this._tbxEditClassID.Location = new System.Drawing.Point(600, 110);
            this._tbxEditClassID.Name = "";
            this._tbxEditClassID.Size = new System.Drawing.Size(154, 20);

            this._tbxEditPhoneNuber.Location = new System.Drawing.Point(600, 140);
            this._tbxEditPhoneNuber.Name = "";
            this._tbxEditPhoneNuber.Size = new System.Drawing.Size(154, 20);

            this.Controls.Add(_tbxEditIdSV);
            this.Controls.Add(_tbxEditNameSV);
            this.Controls.Add(_tbxEditDob);
            this.Controls.Add(_tbxEditAddress);
            this.Controls.Add(_tbxEditClassID);
            this.Controls.Add(_tbxEditPhoneNuber);
           
            _lbEditIdSV= new System.Windows.Forms.Label();
            _lbEditNameSV= new System.Windows.Forms.Label();
            _lbEditDob= new System.Windows.Forms.Label();
            _lbEditAddress= new System.Windows.Forms.Label();
            _lbEditClassID= new System.Windows.Forms.Label();
            _lbEditPhoneNuber= new System.Windows.Forms.Label();
            
            
            this._lbEditIdSV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._lbEditIdSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._lbEditIdSV.Location = new System.Drawing.Point(200, 80);
            this._lbEditIdSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lbEditIdSV.Name = "label1";
            this._lbEditIdSV.Size = new System.Drawing.Size(289, 23);
            this._lbEditIdSV.TabIndex = 0;
            this._lbEditIdSV.Text = "ID:";
            this.Controls.Add(_lbEditIdSV);
            
            this._lbEditNameSV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._lbEditNameSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._lbEditNameSV.Location = new System.Drawing.Point(200, 110);
            this._lbEditNameSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lbEditNameSV.Name = "label1";
            this._lbEditNameSV.Size = new System.Drawing.Size(289, 23);
            this._lbEditNameSV.TabIndex = 0;
            this._lbEditNameSV.Text = "Name:";
            this.Controls.Add(_lbEditNameSV);
            
            this._lbEditDob.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._lbEditDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._lbEditDob.Location = new System.Drawing.Point(200, 140);
            this._lbEditDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lbEditDob.Name = "label1";
            this._lbEditDob.Size = new System.Drawing.Size(289, 23);
            this._lbEditDob.TabIndex = 0;
            this._lbEditDob.Text = "Gender:";
            this.Controls.Add(_lbEditDob);
            
             
            this._lbEditAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._lbEditAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._lbEditAddress.Location = new System.Drawing.Point(500, 80);
            this._lbEditAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lbEditAddress.Name = "label1";
            this._lbEditAddress.Size = new System.Drawing.Size(289, 23);
            this._lbEditAddress.TabIndex = 0;
            this._lbEditAddress.Text = "Address:";
            this.Controls.Add(_lbEditAddress);

            this._lbEditClassID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._lbEditClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._lbEditClassID.Location = new System.Drawing.Point(500, 110);
            this._lbEditClassID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lbEditClassID.Name = "label1";
            this._lbEditClassID.Size = new System.Drawing.Size(289, 23);
            this._lbEditClassID.TabIndex = 0;
            this._lbEditClassID.Text = "Class ID:";
            this.Controls.Add(_lbEditClassID);
            
            this._lbEditPhoneNuber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._lbEditPhoneNuber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._lbEditPhoneNuber.Location = new System.Drawing.Point(500, 140);
            this._lbEditPhoneNuber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lbEditPhoneNuber.Name = "label1";
            this._lbEditPhoneNuber.Size = new System.Drawing.Size(289, 23);
            this._lbEditPhoneNuber.TabIndex = 0;
            this._lbEditPhoneNuber.Text = "Phone:";
            this.Controls.Add(_lbEditPhoneNuber);

             

            
            
            
        }
        private void btnAddClassRoom_click(Object sender, EventArgs e)
        {
            AddNewClass newClassRoom=new AddNewClass(this);
            newClassRoom.StartPosition = FormStartPosition.CenterScreen;
            newClassRoom.Show();
        }

        private void btnDelete_click( Object sender, EventArgs e)
        {
            List<ClassRoom> listClassRooms =new List<ClassRoom>();
            for (int i = 0; i < cbxClassRoom.GetLength(0); i++)
            {
                if (cbxClassRoom[i].Checked)
                {
                    listClassRooms.Add(_processManagement.ListClasses[i]);
                }
            }

            for (int i = 0; i < listClassRooms.Count; i++)
            {
                _processManagement.ListClasses.Remove(listClassRooms[i]);
                this.flPanelClasses.Controls.Clear();
                this.loadListClassRoom();
            }

        }

        private void btnEdit_click(Object sender, EventArgs e)
        {
            EditClass _editClass=new EditClass(this);
            for (int i = 0; i < cbxClassRoom.GetLength(0); i++)
            {
                ClassRoom _classRoom= _processManagement.ListClasses[i];
                _editClass.getTexBoxClassID().Text = _classRoom.Id;
                _editClass.getTexBoxClassID().Enabled = false;
                _editClass.getTexBoxClassName().Text = _classRoom.Name;
                _editClass.StartPosition = FormStartPosition.CenterScreen;
            }
            _editClass.Show();
            
        }
        private void btnBack_click(Object sender, EventArgs e)
        {
            this.flPanelClasses.Controls.Clear();
            this.panelAction.Controls.Clear();
            this.panelAction.Controls.Add(btnAdd);
            this.panelAction.Controls.Add(btnEdit);
            this.panelAction.Controls.Add(btnDelete);
            this.lbClass.Visible = false;
            this.Controls.Add(panelAction);
            this.dataGridViewStudents.Rows.Clear();
            loadListClassRoom();
        }

        private void btnExit_click(Object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCbxClassRoom_click(Object sender, EventArgs e)
        {
        }

        private void btnAddStudent_click(object sender, EventArgs e)
        {
            AddNewStudent _addNewStudent =new AddNewStudent(this, _tbxEditClassID);
            _addNewStudent.StartPosition = FormStartPosition.CenterScreen;
            _addNewStudent.Show();

        }
 
        private void btnDeleteStudent_click(object sender, EventArgs e)
        {
            ClassRoom classRoom = _processManagement.getClassRoom(_tbxEditClassID.Text);
            string idStudent = this._tbxEditIdSV.Text;
            bool isDelete = classRoom.deleteStudent(idStudent);
            if (isDelete)
            {
                MessageBox.Show("Deleted successfully");
                this.dataGridViewStudents.Rows.Clear();
                this.dataGridViewStudents.Refresh();
                drawDataGridView(classRoom,0);

            }
            else
            {
                MessageBox.Show("Deleted fail, try again");
            }
        }
        private void btnEditStudent_click(object sender, EventArgs e)
        {
           // _tbxEditIdSV.Enabled = true;
            _tbxEditNameSV.Enabled = true; 
            _tbxEditDob.Enabled = true;
            _tbxEditAddress.Enabled = true; 
           // _tbxEditClassID.Enabled = true;
            _tbxEditPhoneNuber.Enabled = true;

        }

        private void btnSaveStudent_click(object sender, EventArgs e)
        {
            string idStudent = this._tbxEditIdSV.Text;
            string nameStudent = this._tbxEditNameSV.Text;
            string genderStudent = this._tbxEditDob.Text;
            string addressStudent = this._tbxEditAddress.Text;
            string classId = this._tbxEditClassID.Text;
            int phoneStudent = 0;
            try
            {
                phoneStudent = Int32.Parse(this._tbxEditPhoneNuber.Text);  
            }
            catch
            {
                MessageBox.Show("Error format phone number");

            }

            if (idStudent =="" || nameStudent== "" || genderStudent =="" || addressStudent == "" || classId== "" || phoneStudent == 0)
            {
                MessageBox.Show("Enter all fields are required.");
            }
            else
            {
                ClassRoom classRoom = _processManagement.getClassRoom(classId);
                Student s = new Student(idStudent, nameStudent, genderStudent, addressStudent, classId, phoneStudent);
                bool isEdited = classRoom.editStudent(s);

                if (isEdited)
                {
                    MessageBox.Show("Edited successfully.");
                    this.dataGridViewStudents.Rows.Clear();
                    this.dataGridViewStudents.Refresh();
                    _tbxEditIdSV.Enabled = false;
                    _tbxEditNameSV.Enabled = false;
                    _tbxEditDob.Enabled = false;
                    _tbxEditAddress.Enabled = false;
                    _tbxEditClassID.Enabled = false;
                    _tbxEditPhoneNuber.Enabled = false;


                    drawDataGridView(classRoom, 0);

                }

                else
                {
                    MessageBox.Show("Edited fail. Try again.");
                }
            }


        }
        private void btnClearStudent_click(object sender, EventArgs e)
        {
            _tbxEditNameSV.Clear();
            _tbxEditDob.Clear();
            _tbxEditAddress.Clear();
            // _tbxEditClassID.Clear(); 
            _tbxEditPhoneNuber.Clear();
            
            //_tbxEditIdSV.Enabled = true;
            _tbxEditNameSV.Enabled = true; 
            _tbxEditDob.Enabled = true;
            _tbxEditAddress.Enabled = true; 
           // _tbxEditClassID.Enabled = true;
            _tbxEditPhoneNuber.Enabled = true;
            

        }
            

    }
}