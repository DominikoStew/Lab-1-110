using System;
using System.Collections.Generic;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Test();
        }


        void Test() {
            Console.WriteLine("Hello World!");

            string name = "Dominique";
            int age = 33;
            float average = 3.422f;
            decimal totoal = 1232.212m;
            bool found = false;
            //char letter = 'f';
            //uint positives = 123;
            //double largeNumber = 1313131313131313131;


            Console.WriteLine(name);

            for(int i =0; i< 10; i++) {
                Console.WriteLine(i);

                if(i == 5) {
                    Console.WriteLine("It's a five!!!");
                }
            }
            string message = SayHello(name, "Steward", age);
            Console.WriteLine(message);

            ListTest();

        }

        private string SayHello(string name, string lastName, int age){
            if(age < 12){
            //return "Hello" + name;
            return $"Hello {name}";
            //return string.Concat("Hello ", name);
            }
            // here
            return "w' sup body";
        }


        void ListTest(){
            //string[] ages = new string[999];
            //ages[0] = 1;
            //ages[1] = 2;
            //ages[1] = 3;

            List<int> listOfAges = new List<int>();
            listOfAges.Add(20);
            listOfAges.Add(10);
            listOfAges.Add(33);
            listOfAges.Add(40);
            listOfAges.Add(8);
            listOfAges.Add(91);
            listOfAges.Add(11);

            // vars
            var sum = 0;
            var smallest = listOfAges[0];

            for(var i = 0; i< listOfAges.Count; i++){
                var age = listOfAges[i];
                sum += age;

                if(age < smallest){
                    smallest = age;
                }

                if(age > biggest){
                    biggest = age;
                }

                if(age % 2 == 0){
                    // is even
                    evens += 1;
                }
            }
            System.Console.WriteLine("The sum: " + sum);
            System.Console.WriteLine("The avrg: " + (sum / listOfAges.Count) );
            System.Console.WriteLine("The min: " + smallest);
            System.Console.WriteLine("The max: " + biggest);
            System.Console.WriteLine("There are: " + evens + "even numbers");

        }

    }
}
