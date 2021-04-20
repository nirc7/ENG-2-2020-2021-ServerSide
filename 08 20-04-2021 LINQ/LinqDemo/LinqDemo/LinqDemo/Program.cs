using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Var And Anonymous
            //var num = 7;
            ////num = "avi";

            //int[] nums = { 3, 7, 2, 9, 1, 0, 5, 8 };

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            ////reference variableName = new ObjectType();
            //Student s = new Student() { ID = 7, Name = "avi", Grade = 100 };
            //Student s2 = new Student() { ID = 7, Name = "avi", Grade = 100 };
            //Console.WriteLine(s == s2);
            //Console.WriteLine(s.Equals(s2));

            //var at1 = new { ID = 5, Age = 30.5, Color = "green" };
            //Console.WriteLine(at1.GetType());

            //var at2 = new { ID = 7, Age = 40.5, Color = "red" };
            //Console.WriteLine(at2.GetType());

            //var at3 = new { Num = "5", Age = 30.5, Color = "green" };
            //Console.WriteLine(at3.GetType());

            //Console.WriteLine(at1.GetType() == at2.GetType());

            //Console.WriteLine(at3.GetType() == at2.GetType());

            #endregion

            #region LINQ

            int[] nums = new int[] { 3, 8, 4, 2, 9, 5, 7, 1 };

            var evens = from num in nums
                        where num % 2 == 0 && num > 4
                        orderby num descending
                        select num + 5; //qeury definition - not runned yet!

            nums[4] = 10;

            foreach (var item in evens) //run the qeury!
            {
                Console.WriteLine(item);
            }

            string[] names = new string[] { "ben", "avi", "dan", "aviel", "gil", "avigail" };

            IEnumerable<int> nSWAV = from name in names
                                     where name.StartsWith("av") && name.Length <= 5
                                     orderby name.Length ascending //default
                                     select name.Substring(2).Length;

            Console.WriteLine();
            foreach (var item in nSWAV)
            {
                Console.WriteLine(item);
            }

            var nEndsWL = (from name in names
                           where name.EndsWith("l")
                           orderby name.Length descending//default
                           select name).ToList();

            Console.WriteLine(nEndsWL[0]);


            Student[] students = new Student[]
            {
                new Student(){ID=2, Name = "avi", Grade =100},
                new Student(){ID=3, Name = "dora", Grade =98},
                new Student(){ID=1, Name = "ben", Grade =99},
                new Student(){ID=4, Name = "charlie", Grade =97}
            };

            var studentsWA = from stu in students
                             where stu.Grade > 97 && stu.Name.Contains("a")
                             //select stu.ID + "-" + stu.Name;
                             //select new StudentIDandName() { ID = stu.ID, Name = stu.Name };
                             select new
                             {
                                 myID = stu.ID,
                                 myName = stu.Name
                             };

            Console.WriteLine();
            foreach (var item in studentsWA)
            {
                //Console.WriteLine("ID="+ item.Split('-')[0] + " Name=" + item.Split('-')[1]);
                //Console.WriteLine("ID=" + item.ID + " Name=" + item.Name  );
                Console.WriteLine("ID=" + item.myID + " Name=" + item.myName);
            }



            //code
            Console.WriteLine();
            foreach (var item in studentsWA)
            {
                //Console.WriteLine("I:" + item.Split('-')[0] + " N:" + item.Split('-')[1]);
                //Console.WriteLine("I:" + item.ID + " N:" + item.Name);
                Console.WriteLine("I:" + item.myID + " N:" + item.myName);
            }
            #endregion

        }
    }
    //class StudentIDandName
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //}
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        //...

        public override string ToString()
        {
            return $"{ID},{Name},{Grade}";
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                return GetHashCode() == obj.GetHashCode();
            }
            return false;
        }

    }
}
