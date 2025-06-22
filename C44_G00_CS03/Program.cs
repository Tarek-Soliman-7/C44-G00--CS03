namespace C44_G00_CS03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Check the number can be divided by 3 and 4 : ");
            //int.TryParse(Console.ReadLine(), out int x);
            //Console.WriteLine(x%3==0 && x%4 ==0 ? "Yes" : "No");
            #endregion

            #region Q2
            //int.TryParse(Console.ReadLine(), out int x);
            //Console.WriteLine(x > 0 ? "Positive" : x < 0 ? "Negative" : "Zero");
            #endregion

            #region Q3
            //Console.WriteLine("Enter The Numbers: ");
            //int.TryParse(Console.ReadLine(), out int x);
            //int.TryParse(Console.ReadLine(), out int y);
            //int.TryParse(Console.ReadLine(), out int z);
            //int max = x > y ? (x > z ? x : z) : (y > z ? y : z);
            //Console.WriteLine($" Max element = {max}");
            //int min = x < y ? (x < z ? x : z) : (y < z ? y : z);
            //Console.WriteLine($" Min element = {min}");
            #endregion

            #region Q4
            //int.TryParse(Console.ReadLine(), out int x);
            //Console.WriteLine(x%2==0?"Even":"Odd");
            #endregion

            #region Q5
            //char.TryParse(Console.ReadLine(), out char c);
            //Console.WriteLine(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
            //                  || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'
            //                    ? "Vowel" : "Consonant");
            #endregion

            #region Q10
            //Console.WriteLine("Enter Marks of five subjects: ");
            //int.TryParse(Console.ReadLine(), out int sub1);
            //int.TryParse(Console.ReadLine(), out int sub2);
            //int.TryParse(Console.ReadLine(), out int sub3);
            //int.TryParse(Console.ReadLine(), out int sub4);
            //int.TryParse(Console.ReadLine(), out int sub5);
            //int total = sub1 + sub2 + sub3 + sub4 + sub5;
            //int average = total / 5;
            //int percentage = total / 5;
            //Console.WriteLine($"Total Marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}%");
            #endregion

            #region Q11
            //Console.WriteLine("Month Number: ");
            //int.TryParse(Console.ReadLine(), out int month);
            //int days=0;
            //if (month == 1)
            //    days = 31;
            //else if (month == 2)
            //    days = 28;
            //else if (month == 3)
            //    days = 31;
            //else if (month == 4)    
            //    days = 30;
            //else if (month == 5)
            //    days = 31;
            //else if (month == 6)
            //    days = 30;
            //else if (month == 7)
            //    days = 31;
            //else if (month == 8)
            //    days = 31;
            //else if (month == 9)
            //    days = 30;
            //else if (month == 10)
            //    days = 31;
            //else if (month == 11)
            //    days = 30;
            //else if (month == 12)
            //    days = 31;
            //Console.WriteLine(month<13?$"Days in Month: {days}.":"Invalid input month. ");
            #endregion

            #region Q12
            Console.WriteLine("Enter The Numbers: ");
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);
            Console.WriteLine("Enter The Operation: ");
            char.TryParse(Console.ReadLine(), out char op);
            if (op == '+')
                Console.WriteLine($"x + y = {x + y}");
            else if (op == '-')
                Console.WriteLine($"x - y = {x - y}");
            else if (op == '*')
                Console.WriteLine($"x * y = {x * y}");
            else if (op == '/')
            {
                if (y != 0)
                    Console.WriteLine($"x / y = {x / y}");
                else
                    Console.WriteLine("Division by zero is not allowed.");
            }
            #endregion
        }
    }
}
