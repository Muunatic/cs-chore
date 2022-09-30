using System;

namespace main {

    public class main {

        public static void Main(string[] args) {

            Console.WriteLine("Input value with \"y\": ");
            string a = Console.ReadLine();
            string b = "z";
            string c = "x";
            string x;

            if (a == "y") {
                x = a;
                a = c;
                c = b;
                b = x;
                x = a + " " + b + " " + c;

                Console.WriteLine(x);
            } else {
                Console.WriteLine("Error!");
            }
            
        }
        
    }

}