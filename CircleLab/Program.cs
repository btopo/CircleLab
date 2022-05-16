
public class Program
{
    public static void Main(string[] args)
    {
        bool continueProgram = true;
        int counter = 0;
        while (continueProgram)
        {
        Console.WriteLine("Please enter the radius of a circle.: ");
        var isNumber = double.TryParse(Console.ReadLine(), out double radius); // checking to see if the user entry is not a number.
            if (!isNumber || radius < 1)
            {
                Console.WriteLine("Not a valid number and press enter to continue. ");
                continue;  // starts the loop at the beginning. 
            }
            
            Circle userCircle = new Circle(radius);
            double userCalculatedArea = Math.Round( userCircle.CalculateArea(radius), 2 ); // calculating the user input and rounding to 2 decimal places.
            double userCalculatedCircumference = Math.Round( userCircle.CalculateCircumference(radius), 2);
            Console.WriteLine($" The area of the circle is{userCalculatedArea} ");
            Console.WriteLine($" The circumference of the circle is {userCalculatedCircumference}");

            bool exitLoop = true;
            while (exitLoop)
            {
                Console.WriteLine(" Do you want to do another? Press Y/N :");
                string userEntry = Console.ReadLine();
               if(userEntry.Equals ("N", StringComparison.InvariantCultureIgnoreCase))
                {
                    exitLoop = false;
                }
                else if (!userEntry.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Please enter valid response. ");
                    
                }
                
                


                if (userEntry.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                {
                    counter = counter + 1;
                    continue;

                }
                else if (userEntry.Equals("N", StringComparison.InvariantCultureIgnoreCase))
                {
                    continueProgram = false;
                }
            }
        }

        Console.WriteLine($"The number of circles you asked for is {counter} thank you and goodbye! ");
    }
}    

public class Circle
{
    private double radius { get; set; }

    public Circle(double newRadius)
    {
        radius = newRadius;
    }

    public double CalculateCircumference( double raidus)
    {
        double circumfrence = 2 * Math.PI * raidus;
        return circumfrence;
    }

    public string CalculateFormattedCircumference( double radius)
    {
        double circumfrence = CalculateCircumference(radius);
        return circumfrence.ToString();
    }

    public double CalculateArea(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }
    public string CalculateFormattedArea(double radius)
    {
        double area = CalculateArea(radius);
        return area.ToString();
    }
   /* private string FormatNumber(double x)
    {
        return x.ToString;
    }
   */
}