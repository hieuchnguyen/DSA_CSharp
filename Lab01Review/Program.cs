using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Review
{
    class Program
    {
        //https://ideone.com/eGhXKB
        /// <summary>
        /// Buoc 1. Khai bao va dinh nghia lop Student gom 4 thuoc tinh
        /// Id, Fullname, Birthday, Gender
        /// </summary>
        public class Student
        {
            public int Id;
            public string Fullname;
            public string Birthday;
            public bool Gender;
        }

        /// <summary>
        /// Buoc 2. Su dung lop Student
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Khai bao va khoi tao gia tri
            Student std = new Student();
            std.Id = 100;
            std.Fullname = "Nguyen";
            std.Birthday = "1990";
            std.Gender = true;

            // Debug: nhan F9 tai dong lenh dung-> nhan F5 debug
            Console.WriteLine("{0}, {1}, {2}, {3}",
                std.Id,
                std.Fullname,
                std.Birthday,
                std.Gender);
        }
    }
}