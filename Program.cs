
public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68);

        CheckForPositiveNegativeZero(-1); 
        CheckForPositiveNegativeZero(1); 
        CheckForPositiveNegativeZero(0); 
        FindMinimum(1,2,3);
        FindMinimum(2,1,3);
        FindMinimum(3,2,1);
        FindMaximum(1,2,3);
        FindMaximum(2,1,3);
        FindMaximum(3,2,1);
        IsDivisibleBy5(5);
        IsDivisibleBy5(6);
        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);
        CheckVowelOrConsonant("e");
        CheckVowelOrConsonant("E");
        CheckVowelOrConsonant("s");
        CheckVowelOrConsonant("S");
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    public static void CheckForPositiveNegativeZero(int num)
    {
        if(num > 0)
        {
            Console.WriteLine("Your number is postive.");
        }
        else if(num < 0)
        {
            Console.WriteLine("Your number is negtive.");
        }
        else
        {
            Console.WriteLine("Your number is zero.");
        }
    }
    public static void FindMinimum(int num1, int num2, int num3)
    {
        string min = "The minimum value is " + num1;
        
        if(num2 < num1)
        {
            min = "The minimum value is " + num2 + ".";
            if(num3 < num2)
        {
            min = "The minimum value is " + num3 + ".";
        }
        }
        else if(num3 < num1)
        {
            min = "The minimum value is " + num3 + ".";
        }
        Console.WriteLine(min);
    }
    
    public static void FindMaximum(int num1, int num2, int num3)
    {
        string max = "The maximum value is " + num1; 
        
        if(num2 > num1)
        {
            max = "The maximum value is " + num2 + ".";
            if(num3 > num2)
        {
            max = "The maximum value is " + num3 + ".";
        }
        }
        else if(num3 > num1)
        {
            max = "The maximum value is " + num3 + ".";
        }
        Console.WriteLine(max);
    }

    public static void IsDivisibleBy5(int num)
    {
        Boolean divsibleby5 = false;
        if((num % 5) == 0)
        {
            divsibleby5 = true;
        }
        if(divsibleby5)
        {
            Console.WriteLine(num + " is divisible by 5.");
        }
        else
        {
            Console.WriteLine(num + " is not divisible by 5.");
        }
    }
    public static void CheckEvenOrOdd(int num)
    {
        Boolean even = false;
        if((num % 2) == 0)
        {
            even = true;
        }
        if(even)
        {
            Console.WriteLine(num + " is an even number.");
        }
        else
        {
            Console.WriteLine(num + " is a odd number.");
        }
    }
    public static void CheckVowelOrConsonant(string letter)
    {
        switch(letter)
        {
            case "a":
            case "A":
            case "e":
            case "E":
            case "i":
            case "I":
            case "o":
            case "O":
            case "u":
            case "U":
                Console.WriteLine(letter + " is a vowel.");
                break;
            default:
                Console.WriteLine(letter + " is a consonant.");
                break;
        }
    }

    public static void DisplayDayOfWeek(int day)
    {
        switch(day)
        {
            case 0:
                Console.WriteLine("Sunday.");
                break;
            case 1:
                Console.WriteLine("Monday.");
                break;
            case 2:
                Console.WriteLine("Tuesday.");
                break;
            case 3:
                Console.WriteLine("Wednesday.");
                break;
            case 4:
                Console.WriteLine("Thursday.");
                break;
            case 5:
                Console.WriteLine("Friday.");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
        }
    }
}
