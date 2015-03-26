using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU02_Summative_Question04
{
    class Person
    {
        private string _name;
        private string _surname;
        private string _course;
        private int _crnumber;
        private string _display;

        Queue<Person> people = new Queue<Person>();

        public Person() //Default Constructor
        {
            _name = "";
            _surname = "";
            _course = "";
            _crnumber = 0;
            _display = "";
        }

        public Person(string name, string surname, string course, int crnumber) //Overloaded Constructor
        {
            this._name = name;
            this._surname = surname;
            this._course = course;
            this._crnumber = crnumber;
        }

        public string Name //Name variable property
        {
            get { return _name; }
            set { this._name = value; }
        }

        public string Surname //Surname variable property
        {
            get { return _surname; }
            set { this._surname = value; }
        }

        public string Course //Course variable property
        {
            get { return _course; }
            set { this._course = value; }
        }

        public int CRNumber //CRNumber variable property
        {
            get { return _crnumber; }
            set { this._crnumber = value; }
        }

        public string Display //Display variable property
        {
            get { return _display; }
            set { this._display = value; }
        }

        public void ViewInfo(string name, string surname, string course, int crnumber)
        {
            Person student = new Person(name, surname, course, crnumber); //Creates a new student object of the Person class
            people.Enqueue(student); //Adds the student object to the queue
            Display = "Student Info: \n";

            foreach (var p in people) //Displays the information of all the queued students
            {
                Display += "\nName : " + p._name + "\nSurname : " + p._surname + "\nCourse : " + p._course + "\nClassroom Number : " + p._crnumber.ToString() + "\n";
            }
        }
    }
}
