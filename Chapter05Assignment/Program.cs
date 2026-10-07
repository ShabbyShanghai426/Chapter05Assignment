using System.Numerics;

namespace Chapter05Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Enter Aquarium PH (0-14): ");
             Aquarium.FindPhLevel(Console.ReadKey().KeyChar - '0');

            //Question 2
            Console.WriteLine("Enter a month (1-12): ");
             string input = Console.ReadLine();

             //Month parse
             if (int.TryParse(input, out int inputMonth))
             {
                 try
                 {
                     Month selectedMonth = new Month(inputMonth);
                     Console.WriteLine("\nResult:");
                     Console.WriteLine(selectedMonth.ToString());
                 }
                 catch (ArgumentOutOfRangeException ex)
                 {
                     Console.WriteLine($"\nERROR: {ex.Message}");
                 }
             }
             else
             {
                 Console.WriteLine("\nERROR: Please enter a valid number (1-12)");
             }


            //Question 3
            Console.WriteLine("BMI Calculator");

             //Bmi height
             Console.Write("\nEnter height in meters (max 2.72): ");
             if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0 || height > 2.72)
             {
                 Console.WriteLine("\nInvalid height. Height must be between 0 and 2.72 meters.");
                 return;
             }

             //bmi weight
             Console.Write("\nEnter weight in kilograms: ");
             if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
             {
                 Console.WriteLine("\nInvalid weight. Must be a positive number.");
                 return;
             }

             double bmi = weight / (height * height);

             string status = bmi switch
             {
                 < 18.5 => "Underweight",
                 < 25.0 => "Normal weight",
                 < 30.0 => "Overweight",
                 _ => "Obesity"
             };

             // bmi print
             Console.WriteLine("\n--- Results ---");
             Console.WriteLine($"Height: {height:F2} m");
             Console.WriteLine($"Weight: {weight:F1} kg");
             Console.WriteLine($"BMI:    {bmi:F1}");
             Console.WriteLine($"Status: {status}");
            

            //Question 4
            Console.Write("\nEnter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Employee Type (S for Salaried, H for Hourly): ");
            string type = Console.ReadLine().Trim().ToUpper();

            Employee emp = null;

            if (type == "S")
            {
                Console.Write("Enter Salary Amount: $");
                double salary = Convert.ToDouble(Console.ReadLine());
                emp = new SalariedEmployee(firstName, lastName, id, salary);
            }
            else if (type == "H")
            {
                Console.Write("Enter Hourly Rate: $");
                double rate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Hours Worked this Week: ");
                double hours = Convert.ToDouble(Console.ReadLine());

                emp = new HourlyEmployee(firstName, lastName, id, rate, hours);
            }
            else
            {
                Console.WriteLine("Invalid employee type entered.");
                return;
            }

            emp.DisplayPayStub();
        }
    }
}
