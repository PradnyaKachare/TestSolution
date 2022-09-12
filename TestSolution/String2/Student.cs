using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
    //1.	Create a class Student with following attributes
    //(int id,String name,String[] hobbies).Create 2 student.

    class Student
    {
        public int id;
        public string name;
        string[] hobbie = { "playing","Singing","Dancing"};
        //string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

        static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 1;
            s.name = "Pradnya";

            Console.WriteLine(s.id);
            Console.WriteLine(s.name);
        }
    }

}

