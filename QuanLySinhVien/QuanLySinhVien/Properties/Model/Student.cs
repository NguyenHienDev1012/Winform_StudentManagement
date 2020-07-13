namespace QuanLySinhVien.Properties.Model
{
    public class Student
    {
        private string id;
        private string name;
        private string gender;
        private string address;
        private string classid;
        private int phone;

        public Student(string id, string name, string gender, string address, string classid, int phone)
        {
            this.id = id;
            this.name = name;
            this.gender= gender;
            this.address = address;
            this.classid = classid;
            this.phone = phone;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string ClassId
        {
            get => classid;
            set => classid = value;
        }

        public int Phone
        {
            get => phone;
            set => phone = value;
        }

        public override string ToString()
        {
            return "Id " +this.id + "name" +this.name +"gender" +this.gender +"address"+ this.address +"classId"+this.classid+ "phone" +this.phone;
        }
    }
    
}