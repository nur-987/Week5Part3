using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region intro
            List<int> lst = new List<int>();
            lst.Add(3);
            lst.AddRange(new List<int>() { 8, 2, 5 });
            lst.Remove(8);
            #endregion
        }

        public static void myStackexample()
        {
            Stack<int> stk1 = new Stack<int>();
            Stack<Student> studentsStack = new Stack<Student>();

            stk1.Count();
            //peek: read the last value
            //pop; remove the last value
        }
        public static void QueueExample()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(4);
            q.Dequeue(); //removes the first element

            q.Peek();
            q.Clear();

        }

        public static void myDictionary()
        {
            Dictionary<int, int[]> dict;
            //something like this?
            dict.Add(1, int[5] myArry = new int[] { 1,4,9,6,2});
            //unique keys and an array of numbers tied to that key

            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
            {
                dict2.Add(i, 1 * 1);

            }
            if (dict2.ContainsKey(4))
            {
                Console.WriteLine("key value pair present in dictionaray");
            }
            foreach (KeyValuePair<int,int> item in dict2)
            {
                Console.WriteLine($"Key is {item.Key} and value is {item.Value}");
            }

            var listKeys = dict2.Keys.ToList(); //dict2.Values.ToList 
            foreach (int i in listKeys)
            {

            }
        }

        public static void myDictionary2()
        {
            int[] arr = new int[] { 1, 1, 4, 2, 3, 6, 1, 4, 2, 6, 6, 5, 3, 5 };
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (myDict.ContainsKey(arr[i]))
                {
                    myDict[arr[i]]++;
                }
                else
                {
                    myDict.Add(arr[i], 1);
                }
            }

            SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();
            //normal dictionary => sorted on the basis of first come first serve
            //sorted dictionary => sorted on the basis of value
        }

    }
    class Student //List
    {
        public int id;
        public string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static void AddStudents()
        {
            List<Student> lst = new List<Student>();
            lst.Add(new Student(2, "Mike"));
            lst.Add(new Student(1, "Ken"));
            lst.Add(new Student(4, "Jacob"));
            lst.Add(new Student(3, "Blake"));

            var sortedLst = lst.OrderBy(x => x.id).ToList();
            Console.WriteLine("sorted list");
            foreach(var stud in sortedLst)
            {
                Console.WriteLine($"Student id: {stud.id} and student name {stud.name}");
            }

            var sortedLst2 = lst.OrderBy(x => x.name).ToList();
            var sortedLst3 = lst.OrderByDescending(x => x.id).ToList();
        }
    }




}
