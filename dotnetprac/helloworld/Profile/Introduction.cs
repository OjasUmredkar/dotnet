namespace Intro{
    public partial class Profile{

        private int id;
        private string name;
        private string address;

        public Profile(int id, string name, string address, string school, string college, int age, char gender)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.school = school;
            this.college = college;
            this.age = age;
            this.gender = gender;
        }



        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }


        public override string ToString()
        {
            return base.ToString()+"Id: "+id+" Name: "+name+" Address: "+address+" School: "+school+" College: "+college+" Age: "+age+" Gender: "+gender;
        }
    }
}