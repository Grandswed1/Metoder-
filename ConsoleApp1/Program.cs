using System.Runtime.ConstrainedExecution;

class Program { 

    static public void Main(String[] args) 
    { 
        Multi(3.1,3.1);
    }

static void Hello32()
{
    for (int i = 0; i < 31; i++)
    {
        Console.WriteLine("Hello World");
    }
}

static void Kvadrat(int parameter)
{
    parameter*=parameter;
    Console.WriteLine(parameter);
}

static double Multi(double trouble, double trouble2)
{
    return trouble*trouble2;
}

static double RightTriangleArea(double length, double height)
{
    double area = height*length/2;
    return area;
}

static double CirlceArea(double radius)
{
    double area = radius*radius*3.14; 
    return area; 
}

static int GetNumberInput()
{
    while (true)
    {
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
            break;
        }
        catch (System.Exception)
        {
            Console.WriteLine("Error");
            throw;
        }
    }
}

static int GetChoice(String input1, String input2, String input3)
{
    Console.WriteLine(input1, input2, input3); 
    int number = Convert.ToInt32(Console.ReadLine());
    switch(number)
    {
        case 1: 
            return number;
            break; 
        case 2:
            return number;
            break; 
        case 3:
            return number;
            break;
        default:
            Console.WriteLine("välj nummer tack");
            return 0;
            break;
    }
}

}