using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculationsOnComplex();

            //guidExample();

            Console.ReadLine();


        }

        public static void ComplexNumberEx()
        {
            Complex complex1 = new Complex(12, 6);
            Console.WriteLine(complex1);

            Complex complex2 = new Complex(8, 3);
            Console.WriteLine("Adding complex number:" +(complex1+complex2));

            Complex complex3 = new Complex(6, 1);
            Console.WriteLine("Square root complex number:" + Complex.Sqrt(complex3));

            double complexReal = complex1.Real;


        }

        public static void BigIntExampe()
        {
            //any double value passed will be droped.
            //only take in whole numbers
            BigInteger bigInt = new BigInteger(2837651.99846);
            Console.WriteLine(bigInt);

            String str = "73552946452009645";
            BigInteger bigInt2 = BigInteger.Parse(str);
            Console.WriteLine(bigInt2);
            bigInt2.GetType();


        }

        public static void CalculationsOnComplex()
        {
            Complex cNum1 = new Complex(13, 9);
            Complex cNum2 = new Complex(8, 9);
            Console.WriteLine("Addition: " + (cNum1 + cNum2));
            Console.WriteLine("Subtraction: " + (cNum1 -cNum2));
            Console.WriteLine("Multiplication: " + (cNum1*cNum2));
            Console.WriteLine("Division: " + (cNum1/cNum2));

            //return cNum1 + cNum2;
            //res = cNum2 * cNum1;
            
        }

        public static void guidExample()
        {
            var myGuid = Guid.NewGuid();
            var myGuid2 = Guid.NewGuid();

            //check if 2 guids are equal
            Console.WriteLine(myGuid == myGuid2);
            //returns true or false

            var bytes = new Byte[16]; //in bytes
            var guid3 = new Guid(bytes);  //convert to guid => guid of zeros

        }

        public static void tuppleExample()
        {
            //combining multiple data types to be returned
            Tuple<int, double, string> myTuple = new Tuple<int, double, string>(1, 8.3, "kelly");

            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item2);

            var tuple = Tuple.Create(3, 2.5, "sally");

            //CANNOT WORK
            //foreach(var item in myTuple)
            //{
            //    Console.WriteLine(item);
            //}

            var longTuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
            //item 8 is a tuple itself. can contain anothr tuple in it
            Console.WriteLine(longTuple.Item1);
            //Console.WriteLine(longTuple.Item8); => does not exist
            Console.WriteLine(longTuple.Rest); //=>to get item number 8

            var longERtuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(3,21,45,6,22,87));
            Console.WriteLine(longERtuple.Rest.Item1.Item1);
        }


        private static void print(Tuple<int, int,int> tuple)
        {
            //
        }
        //value tuple =>instal from nuget
        private static void ValueTupleEx()
        {
            ValueTuple<int, string, string> valueTuple = (1, "heidi", "london");
            (string, double, int) valueTuple2 = ("morning", 5.5, 0);
            (string name, double salary, int id) valueTuple3 = ("holly", 5.5, 0);
            Console.WriteLine(valueTuple3.name);
            Console.WriteLine(valueTuple3.salary);

            (int id, string name, string country) = getValueTuple();
            //not a tuple. 
            //deconstructing the values from tuple and now become a variable

            Console.WriteLine(id);
            Console.WriteLine(name);
        }

        //tuple with returns
        private static Tuple<int, string, double> returnTuple()
        {
            return Tuple.Create(1, "fred", 8.8);
        }

        private static (int, string, string) getValueTuple()
        {
            return (1, "mike", "laos");
        }

        private static void GlobalisationEx()
        {
            var ukEn = new CultureInfo("en-GB");
            var ar = new CultureInfo("");
        }
    }
}
