using System;
using System.Linq;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace Main3
{
    internal class Program
    {
        //enum
        enum eWeekDay {Saterday=1,Sunday,Monday,Tuesday,Wednesday,Thursday,Friday}
        //if you set a value , it will auto number everything after it.
        enum enCategories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }

        //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
        //but not string

        enum enCategories2 :Byte
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }
        int ID = 1;
        public struct sUsers {public int ID;public int Avg; }
        struct stStudent
        {
            public string FirstName;
            public string LastName;
        }

        static void PrintMyName()
        {
            Console.WriteLine("Mohammed Al-Hammouz");
        }
        static int SumOfTwoNumber(int num1,int num2)
        {
            return num1 + num2;
        }
        static void PrintInformation(string Name="Mohammed",int Age = 77)
        {
            Console.WriteLine($"name:{Name} ,age:{Age}");
        }

        static string GetMyName()
        {
            return "Mohammed-AbuHadhoud";

        }

        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void MyMethod(int age1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name's Mohammed Al-Hammouz");
            Console.WriteLine("I'm learning C#");
            Console.WriteLine("It's an easy language to learn :)");
            Console.WriteLine("The sum of 10 + 20 is " + (10 + 20));
            Console.WriteLine("The sum of 10 + 20 is " + 10 + 20);
            Console.WriteLine("{0} {1}", "Welcome to", "ProgrammingAdvices");
            Console.WriteLine("My name's {0} I live in {1}", "Mohammed", "Jordan");
            //Escape Carachter
            Console.WriteLine("Useful Escape Caracter:\n");
            //NewLine
            Console.WriteLine("New Line:");
            Console.WriteLine("Well come\n To ProgrammingAdvices:\n");
            //Tab
            Console.WriteLine("Tab:");
            Console.WriteLine("Well come\t To ProgrammingAdvices:\n");
            //Backspace
            Console.WriteLine("Backspace:");
            Console.WriteLine("Well come  \bTo ProgrammingAdvices:\n");
            //Single Quote
            Console.WriteLine("Single Quote:");
            Console.WriteLine("Well come\' To ProgrammingAdvices:\n");
            //Double Quote
            Console.WriteLine("Double Quote:");
            Console.WriteLine("Well come\" To ProgrammingAdvices:\n");
            //Backslash
            Console.WriteLine("Backslash:");
            Console.WriteLine("Well come \\\\\\ To ProgrammingAdvices:\n");
            //Alert
            Console.WriteLine("Alert:");
            Console.WriteLine("\a");
            //comments
            /*
                        This is
                            Multiple line 
                            comments
            */
            //variables
            string MyName = "Mohammed Al-Hammouz";
            Console.WriteLine(MyName);
            int x = 10, y = 20;
            Console.WriteLine("x="+x);
            Console.WriteLine("y=" + y);
            //This line will give correct answer :-)
            Console.WriteLine("The sum of x + y is " + (x + y));
            //This line will give wrong answer :-(
            Console.WriteLine("The sum of x + y is " + x + y);
            //Other common data types
            double MyDouble = 25.89D;
            Console.WriteLine(MyDouble);
            char MyChar = 'M';
            Console.WriteLine(MyChar);
            bool MyBool = true;    
            Console.WriteLine(MyBool);
            //@ using it with reserved word if I haven't any names
            string @break = "Mohammed";
            Console.WriteLine(@break);
            //Implicity Typed Variables
            //var not recommended for use
            //var = auto in c++
            //if we want to use var ,you must be initialized the variable 
            var a = 10;
            var b = 10.5;
            var c = "Mohammed";
            Console.WriteLine("a = {0}, b = {1}, c = {2}",a,b,c);
            /*int num1 = 1;
            int num2 = 10;
            Random number = new Random();
            
            number.Next();
            Console.WriteLine(number);*/
            //Number Datatypes

            //Byte

            byte b1 = 255;
            //  byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
            sbyte sb1 = -128;
            sbyte sb2 = 127;
            Console.WriteLine("\nByte:");
            Console.WriteLine("Min={0} , Max={1}", Byte.MinValue, Byte.MaxValue);


            Console.WriteLine("\nSByte:");
            Console.WriteLine("Min={0} , Max={1}", SByte.MinValue, SByte.MaxValue);

            //Short
            short s1 = -32768;
            short s2 = 32767;
            // short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

            ushort us1 = 65535;
            //  ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            Console.WriteLine("\nShort:");
            Console.WriteLine("Min={0} , Max={1}", Int16.MinValue, Int16.MaxValue);

            Console.WriteLine("\nUShort:");
            Console.WriteLine("Min={0} , Max={1}", UInt16.MinValue, UInt16.MaxValue);

            //int
            int i = -2147483648;
            int j = 2147483647;
            //  int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            uint ui1 = 4294967295;
            // uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            Console.WriteLine("\nInt:");
            Console.WriteLine("Min={0} , Max={1}", Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("\nUInt:");
            Console.WriteLine("Min={0} , Max={1}", UInt32.MinValue, UInt32.MaxValue);

            //Long
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("\nLong:");
            Console.WriteLine("Min={0} , Max={1}", Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("\nULong:");
            Console.WriteLine("Min={0} , Max={1}", UInt64.MinValue, UInt64.MaxValue);


            //Float
            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine("\nFloat:");
            Console.WriteLine("Min={0} , Max={1}", float.MinValue, float.MaxValue);


            //double
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("\nDouble:");
            Console.WriteLine("Min={0} , Max={1}", double.MinValue, double.MaxValue);



            //Decimal
            //The decimal type has more precision and a smaller range
            //than both float and double,
            //and so it is appropriate for financial and monetary calculations.
            decimal d3 = 123456789123456789123456789.5m;
            decimal d4 = 1.1234567891345679123456789123m;

            Console.WriteLine("\nDecimal:");
            Console.WriteLine("Min={0} , Max={1}", decimal.MinValue, decimal.MaxValue);


            //Scientific Notation
            //Use e or E to indicate the power of 10 
            //as exponent part of scientific notation with float, double or decimal.

            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000



            //hex & Binary
            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);

            //default types
            int @i1 = default(int); // 0
            Console.WriteLine("@i1={0}",@i1);
            float f11 = default(float);// 0
            Console.WriteLine("@f11={0}", @f11);
            decimal d11 = default(decimal);// 0
            Console.WriteLine("d11={0}", d11);
            bool b11 = default(bool);// false
            Console.WriteLine("b11={0}", b11);
            char c11 = default(char);// '\0'
            Console.WriteLine("c11={0}", c11);
            int @i11 = default; // 0
            Console.WriteLine("@i11={0}", @i11);
            float f111 = default;// 0
            Console.WriteLine("f111={0}", f111);
            decimal d111 = default;// 0
            Console.WriteLine("d111={0}", d111);
            bool @b111 = default;// false
            Console.WriteLine("@b111={0}", @b111);
            char c111 = default;// '\0'
            Console.WriteLine("c111={0}", c111);


            eWeekDay weekDay;
            weekDay = eWeekDay.Friday;
            Console.WriteLine(weekDay);
            Console.WriteLine(((int)weekDay));
            //Nullable Types
            Nullable<int> Num = null;
            Console.WriteLine(Num);
            Nullable<float> Float = null;
            Console.WriteLine(Float);
            //Anonymous Type
            //In C#, an anonymous type is a type (class) without any name that can contain
            //public read-only properties only.
            //It cannot contain other members, such as fields, methods, events, etc.
            var student = new { Id = 1, FirstName = "Mohammed", LastName = "Al-Hammouz" };
            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Id);
            Console.WriteLine(student);
            var student2 = new { student,country="Jordan",City="Amman" };
            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student2.student.FirstName);
            Console.WriteLine(student2.student.LastName);
            Console.WriteLine(student2.student.Id);
            Console.WriteLine(student2.country);
            Console.WriteLine(student2.City);
            var student3 = new
            {
                Id = 20,
                FirstName = "Mohammed",
                LastName = "Al-Hammouz",
                Address = new { Id = 1, City = "Amman", Country = "Jordan" }
           
              

        };
            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student3.Id);
            Console.WriteLine(student3.FirstName);
            Console.WriteLine(student3.LastName);

            Console.WriteLine(student3.Address.Id);
            Console.WriteLine(student3.Address.City);
            Console.WriteLine(student3.Address.Country);
            Console.WriteLine(student3.Address);

            //C# - Struct
            stStudent student1;
            student1.FirstName = "Mohammed";
            Console.WriteLine(student1.FirstName);
            student1.FirstName = "Hazem";
            Console.WriteLine(student1.FirstName);
            sUsers User = new sUsers();
            User.ID = 2;
            User.Avg = 99;
            Console.WriteLine(User.ID);
            Console.WriteLine(User.Avg);
            //C# 4.0 (.NET 4.5) introduced a new type called dynamic
            //that avoids compile-time type checking. A dynamic type escapes type checking at compile-time; instead, it resolves type at run time.
            //A dynamic type variables are defined using the dynamic keyword.
            dynamic num1=10;
            num1 = "1";
            //Set Date && Time
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);
            DateTime dt2 = new DateTime(2025,5,4);
            Console.WriteLine(dt2);
            DateTime dt3 = new DateTime(2025, 5, 4, 3, 47,55);
            Console.WriteLine(dt3);
            DateTime dt4 = new DateTime(2025, 5, 4, 3, 47, 55, DateTimeKind.Utc);
            Console.WriteLine(dt4);
            DateTime dt5 = new DateTime();
            dt5 = DateTime.UtcNow;
            Console.WriteLine(dt5);
            DateTime dt6 = new DateTime();
            
                
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);
            //DateTime Static Fields
            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            //TimeSpan
            TimeSpan time = new TimeSpan(49,25,34);
            Console.WriteLine(time);
            Console.WriteLine(time.Days);
            Console.WriteLine(time.Hours);
            Console.WriteLine(time.Minutes);
            Console.WriteLine(time.Seconds);
            DateTime newDate= dt4.Add(time);
            Console.WriteLine(newDate);
            TimeSpan result = newDate.Subtract(dt4);
            Console.WriteLine(result);
            Console.WriteLine(dt4 == newDate);
            var str = "4/5/2025";
            DateTime dt7;
            var isValidateDate = DateTime.TryParse(str, out dt7);
            if (isValidateDate)
            {
                Console.WriteLine(dt7);
            }
            else
            {
                Console.WriteLine($"{str} is not a vaild date string");
            }
            var str2 = "55/6/2033";
            var isValidateDate2= DateTime.TryParse(str2, out dt7);
            if (isValidateDate2)
            {
                Console.WriteLine(dt7);
            }
            else
            {
                Console.WriteLine($"{str2} is not a vaild date string");
            }
            //C# Strings
            string S1 = "Mohammed Al-Hammouz";
            Console.WriteLine(S1.Substring(2,5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(2,"xxxxxxxxxx"));
            Console.WriteLine(S1.Replace("m","h"));
            Console.WriteLine(S1.IndexOf("h"));
            Console.WriteLine(S1.Contains("Mohammed"));
            Console.WriteLine(S1.Contains("Hadi"));
            Console.WriteLine(S1.LastIndexOf("m"));
            string S2 = "Ali Homar";
            string[] NameList = S2.Split(' ');
            Console.WriteLine(NameList[0]);
            Console.WriteLine(NameList[1]);
            string S3 = "  Abu-Hadhoud  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            //  String Interpolation

            string FirstName = "Mohammed";
            string LastName = "Al-Hammouz";
            string code = "1234";
            Console.WriteLine($"Mr.{FirstName} {LastName},Code={code}");
            /* Implicit Casting(automatically) -converting a smaller type to a larger type size
            char -> int -> long -> float -> double

            Explicit Casting(manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char*/
            int myInt = 17;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 17
            Console.WriteLine(myDouble);   // Outputs 17

            double @Mydouble = 17.58;
            int @myint = (int)@Mydouble;    // Manual casting: double to int

            Console.WriteLine(@Mydouble);   // Outputs 17.58
            Console.WriteLine(@myint);      // Outputs 17

            int myInt1 = 20;
            double myDouble1 = 7.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt1));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt1));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble1));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

         
            Console.WriteLine(eWeekDay.Friday); //output: Friday 
            int day = (int)eWeekDay.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 

            var wd = (eWeekDay)5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday 

            //ReadLine()
            //string FullName=Console.ReadLine().Normalize();
            //Console.WriteLine(FullName);
            //int Number=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Number);

            //switch statment
            int day1;
            day1=Convert.ToInt32(Console.ReadLine());
            switch (day1)
            {
                case 1:
                    Console.WriteLine(eWeekDay.Saterday);
                    break;
                case 2:
                    Console.WriteLine(eWeekDay.Sunday);
                    break;
                case 3:
                    Console.WriteLine(eWeekDay.Monday);
                    break;
                case 4:
                    Console.WriteLine(eWeekDay.Monday);
                    break;
                case 5:
                    Console.WriteLine(eWeekDay.Tuesday);
                    break;
                case 6:
                    Console.WriteLine(eWeekDay.Wednesday);
                    break;
                case 7:
                    Console.WriteLine(eWeekDay.Friday);
                    break;
            }
            char ch;
            ch=Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("the char is vowel");
                    break;
                default:
                    Console.WriteLine("the char isn't vowel");
                    break;
            }
            char op;
            double first, second, Result;
            Console.WriteLine("Enter first number");
            first=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            op=(char)Console.Read();
            switch (op)
            {
                case '+':
                    Result = first + second;
                    Console.WriteLine("{0} + {1}" +" = "+ $"{Result}", first, second, Result);
                    break;
                case '-':
                    Result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, Result);
                    break;
                case '*':
                    Result = first * second;
                    Console.WriteLine($"{first} * {second} = {Result}", first, second, Result);
                    break;
                case '/':
                    Result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, Result);
                    break;
            }
            string Name = "Mohammed";

            //You can compare string as well using switch
            switch (Name.ToLower())
            {
                case "mohammed":

                    Console.WriteLine("Yes Mohammed");
                    break;

                case "ali":

                    Console.WriteLine("Yes ALi");
                    break;

                default:
                    Console.WriteLine("No Name Matched!");
                    break;

            }
            //ternary (? :) Operator
            int Num1 = 2;
            if (Num1 % 2 == 0)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
            Console.WriteLine(Num1%2==0?false:true);
            //for loops
            Console.WriteLine("\nForward Loop:");
            //forward loop

            for (int index = 0; index <= 7; index++)
            {
                Console.WriteLine(index);
                
            }
            Console.WriteLine("\nBackword Loop:");
            //backword loop
            for (int index = 10; index >= 1; index--)

            {

                Console.WriteLine(index);

            }

            Console.WriteLine("\nNested Loops:");
            //forward loop

            for (int index = 0; index <= 7; index++)
            {
                for (int jndex = 0; jndex <= 7; jndex++)
                {
                    Console.WriteLine("i={0},j={1}",index,jndex);

                }
                

            }
            //while loop
            int Index = 0;
            while (Index <= 9)
            {
                Console.WriteLine("i={0}",Index);
                Index++;
            }
            int Jindex = 0;
            do
            {
                Console.WriteLine("C# while Loop: Iteration {0}", Jindex);
                Jindex++;
            }while (Jindex <= 9);
            //break
            int J = 1;
            do
            {
                J++;
                Console.WriteLine("C# while Loop: Iteration {0}", J);

                if (J == 3)
                    break;

                

            } while (J <= 5);

            //continue
            int I = 1;
            do
            {
                I++;
                Console.WriteLine("C# while Loop: Iteration {0}", I);

                if (I == 3)
                    continue;

               

            } while (I <= 5);
            //C# Array Declaration
            int[] Arr;
            // allocate memory for array
            Arr= new int[9];
            Arr[0] = 1;
            Arr[1] = 2;
            Arr[2] = 3;
            Arr[3] = 4;
            Arr[4] = 5;
            Arr[5] = 6;
            Arr[6] = 7;
            Arr[7] = 8;
            Arr[8] = 9;
            //Access Array Elements
            // create an array
            int[] numbers = { 1, 2, 3 };

            //access first element
            Console.WriteLine("Element in first index : " + numbers[0]);

            //access second element
            Console.WriteLine("Element in second index : " + numbers[1]);

            //access third element
            Console.WriteLine("Element in third index : " + numbers[2]);


            //through loop
            Console.WriteLine("\nAccess array using loop:\n");
            for (int Ind = 0; Ind < numbers.Length; Ind++)
            {
                Console.WriteLine("Element in index {0} : {1} ", Ind, numbers[0]);
            }
            //Two-Dimensional Array Declaration
            int[,] D = new int[2, 3] { { 1, 2, 3 }, { 3, 4, 5 } };
            //foreach
            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int Male=0, Female=0;
            foreach (char g in gender)
            {
                if(g == 'm')
                {
                    Male++;
                }
                else
                {
                    Female++;
                }
            }
            Console.WriteLine("Number of male = {0}", Male);
            Console.WriteLine("Number of female = {0}", Female);

            char[] word = { 'H', 'e', 'l', 'l', 'o' };
            foreach (char w in word)
            {
                Console.WriteLine(w);
            }
            //Linq operations
            Console.WriteLine("Max number of numbers is:{0}",numbers.Max());
            Console.WriteLine("Min number of numbers is:{0}", numbers.Min());
            Console.WriteLine("Sum of numbers is:{0}", numbers.Sum());
            Console.WriteLine("Average of numbers is:{0}", numbers.Average());
            Console.WriteLine("Count of numbers is:{0}", numbers.Count());
            //Math
            Console.WriteLine("Max of 5, 10 is: {0}", Math.Max(5, 10));
            Console.WriteLine("Min of 5, 10 is: {0}", Math.Min(5, 10));
            Console.WriteLine("Squir Root of 64 is: {0}", Math.Sqrt(64));
            Console.WriteLine("Absolute (positive) value of  -4.7 is: {0}", Math.Abs(-4.7));
            Console.WriteLine("Round of 9.99 is: {0}", Math.Round(9.99));
            //Methods
            PrintMyName();
            Console.WriteLine("The sum of 3 and 4 is", SumOfTwoNumber(3, 4));
            PrintInformation();
            PrintInformation("Oday",99);
            Console.WriteLine("My Name is {0}", GetMyName());
            MyMethod(child3: "Omar", child1: "Saqer", child2: "Hamza");
            MyMethod(child3: "Mazen", child2: "koko", age1: 77);
            Random rnd = new Random();

            for (int jindex = 0; jindex < 4; jindex++)
            {
                Console.WriteLine(rnd.Next(10, 20)); // returns random integers >= 10 and < 20
            }
            Console.ReadKey();
        }
    }
}
