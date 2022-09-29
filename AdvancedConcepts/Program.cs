using System;
using System.Linq;
namespace AdvancedConcepts
{
    class Program
    {
        static string GetVowels(params string[] input)
        {
            if(input == null || input.Length ==0)
            {
                return string.Empty;
            }
            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            return string.Concat(input.SelectMany(word => word.Where(letter => vowels.Contains(char.ToUpper(letter))))); // three opertions
        }

        //Swapping value
        static void SwapWithValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //Swipping with Reference

        static void SwapWithReference(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

      /*  //Multiple Value can be retruned from methods

        public(string,string,string,int) GetPersonnalInfo(string id)
        {
            PersoneInfo per = PersonInfo.RetrieveInfoByld(id);
            return (per.FirstName, per.MiddleName, per.LastName, per.Age);
        }

        var person = GetPersonalInfo("111111111");
        Console.WriteLine($"{person.Item1}{person.Item3}:age={person.Item4});

        public (string FName, string MName, string LName, int Age) GetPersonalInfo(string id)
        {
            PersonInfo per = Person.Info.RetrieveInfoByld(id);
            return (per.FirstName, per.MiddleName, per.LastName, per.Age);
        }

        var person = GetPersonalInfo("111111");
        Console.WriteLine($"{person.Item1}{person.Item3}:age={person.Age});
        }
      */


        static void Main(string[] args)
        {
            /* string fromArray = GetVowels(new[] { "apple", "banana", "pear" });
             Console.WriteLine($"Vowels from array:'{fromArray}");

             string fromMultipleArguments = GetVowels("apple", "banana", "pear");
             Console.WriteLine($"Vowels from multiple arguments:'{fromMultipleArguments}'");

             string fromNull = GetVowels(null);
             Console.WriteLine($"Vowels from null:'{fromNull}");

             string fromNoValue = GetVowels();
             Console.WriteLine($"Vowems from no value:'{fromNoValue}");
            */
            /*var age = 20;
            Console.WriteLine("Var holds TYPE:{0}| val:{1}", age.GetType(), age);
            var name = "Lucas";
            Console.WriteLine("Var holds TYPE:{0}| val:{1}", name.GetType(), name);

            //ou 

            int[] odds = new int [] { 1, 3, 5, 7, 9 };
            Console.WriteLine("Var holds n array of numbers");

            foreach(var num in odds)
            {
                Console.WriteLine("Var holds TYPE:{0}| val:{1}", num.GetType(), num);
            }

            string.IsNullOrWhiteSpace("abc"); // ? "abc" : throw new ArgumentException("Fist");

            double a = 22.52;
            int i;
            i = (int) a;
            bool b = true;
            float f = 53.005f;
            Console.WriteLine(b.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(a.ToString());
            */

            Rectangle r1 = new Rectangle();
            r1.Name = "rectangle_1";

            r1.calculateArea(new int[] { 100, 200 });
            r1.getColor();

            Triangle t1 = new Triangle();
            t1.Name = "triangle_1";

            t1.calculateArea(new int[] { 100, 200 , 300});
            t1.getColor();



            Console.ReadKey();
        }
    }
}
    

