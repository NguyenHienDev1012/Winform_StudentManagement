using System.Collections.Generic;
using QuanLySinhVien.Properties.Model;

namespace QuanLySinhVien.Properties.Dao
{
    public class ProcessManagement 
    {

        private List<ClassRoom> _listClasses;
        
       
        public ProcessManagement()
        {
            _listClasses = new List<ClassRoom>();
            this._listClasses= initListClassRoom();
        }

        public List<ClassRoom> initListClassRoom()
        {
            //DH17DTA
            Student s1=new Student("17130061","Nguyen Thanh Hien", "nam", " Cat Hanh - Phu Cat - Binh Dinh", "DH17DTA", 0343288734);
            Student s2=new Student("17130062","Nguyen Van Tuan", "nam", " Cat Lam - Phu Cat - Binh Dinh", "DH17DTA", 0373785858);
            Student s3=new Student("17130063","Le Van Hoang", "nam", " Cat Trinh - Phu Cat - Binh Dinh", "DH17DTA", 0338684678);
            Student s4=new Student("17130064","Vo Thi My Linh", "nu", " Cat Chanh - Phu Cat - Binh Dinh", "DH17DTA", 0378946568);
            List<Student> _studentsDTA=new List<Student>();
            _studentsDTA.Add(s1);
            _studentsDTA.Add(s2);
            _studentsDTA.Add(s3);
            _studentsDTA.Add(s4);
            
            //DH17DTB
            Student s5=new Student("17130071","Ho Van Nhan", "nam", " Linh Dong - Thu Duc - TP. HCM", "DH17DTB", 0367347588);
            Student s6=new Student("17130072","Nguyen Bao Nhan", "nam", "Nguyen Han Hanh - Tan Binh - Tp. HCM", "DH17DTB", 0363756678);
            Student s7=new Student("17130073","Le Thi Be", "nu", " Hai Ba Trung - Quan 1 - Tp. HCM", "DH17DTB", 043789465);
            Student s8=new Student("17130074","Hoang Nhat Truong", "nam", "Le Duan - Q2 - Tp. HCM", "DH17DTB",083965968);
            List<Student> _studentsDTB=new List<Student>();
            _studentsDTB.Add(s5);
            _studentsDTB.Add(s6);
            _studentsDTB.Add(s7);
            _studentsDTB.Add(s8);
            
            //DH17DTC
            Student s9=new Student("17130081","Le Thi Hang", "nu", " Song Cau - Phu Yen", "DH17DTC", 0343288734);
            Student s10=new Student("17130082","Nguyen Quoc Bao", "nam", "Binh Thuan", "DH17DTC", 0343288734);
            Student s11=new Student("17130083","Nguyen Truong An", "nam", "Khanh Hoa", "DH17DTC", 0343288734);
            Student s12=new Student("17130084","Nguyen Van Nhat", "nam", "Lam Dong", "DH17DTC", 0343288734);

            //DH17DTD
            Student s13=new Student("17130091","Nguyen Van Hau", "nam", " Song Cam - Phu Yen", "DH17DTD", 0343288734);
            Student s14=new Student("17130092","Le Hoai Hao", "nam", "Binh Duong", "DH17DTD", 0343288734);
            Student s15=new Student("17130093","Nguyen Ngoc An", "nam", "Khanh Hoa", "DH17DTD", 0343288734);
            Student s16=new Student("17130094","Vo My Hoa", "nu", "Ha Noi", "DH17DTD", 0343288734);

            List<Student> _studentsDTC= new List<Student>();
            _studentsDTC.Add(s9);
            _studentsDTC.Add(s10);
            _studentsDTC.Add(s11);
            _studentsDTC.Add(s12);
            ClassRoom classRoomA=new ClassRoom("DH17DTA", "Cong nghe thong tin A", _studentsDTA);
            ClassRoom classRoomB=new ClassRoom("DH17DTB", "Cong nghe thong tin B", _studentsDTB);
            ClassRoom classRoomC=new ClassRoom("DH17DTC", "Cong nghe thong tin C", _studentsDTC);
            ClassRoom classRoomD=new ClassRoom("DH17DTD", "Cong nghe thong tin D", _studentsDTC);
           
            this._listClasses.Add(classRoomA);
            this._listClasses.Add(classRoomB);
            this._listClasses.Add(classRoomC);
            this._listClasses.Add(classRoomD);
            return this._listClasses;
        }

        public void addClassRoom(ClassRoom calssRoom)
        {
            this._listClasses.Add(calssRoom);
        }

        public ClassRoom getClassRoom(string classRoomId)
        {
            ClassRoom classRoom= new ClassRoom();
            foreach (var c in _listClasses)
            {
                if (c.Id.Equals(classRoomId))
                {
                    classRoom = c;
                    return c;
                }
                
            }
            return null;
        }
        public  bool editClassRoom(string idClassRoom, string nameClassRoom)
        {
            bool isOK=false;

            foreach (var classsRoom in this._listClasses)
            {
                if (classsRoom.Id.Equals(idClassRoom))
                {
                    classsRoom.Name = nameClassRoom;
                    isOK = true;
                    return isOK;
                }
                
            }
            
            return isOK;
        }

        public bool deleteRoom(string idClassRoom)
        {
            bool isOK = false;
            for (int i = 0; i < _listClasses.Count; i++)
            {
                if (_listClasses[i].Equals(idClassRoom))
                {
                    this._listClasses.Remove(_listClasses[i]);
                    isOK = true;
                    return isOK;
                }
                
            }
            return isOK;
        }

        public List<ClassRoom> ListClasses
        {
            get => _listClasses;
            set => _listClasses = value;
        }
    }
}