//This is a programe to compute the areas of shapes

using WhileLoops;

int option;
Shape shape = new Shape();
double area = 0;
double length;
double breadth;
const double pi = 3.142;
double radius;
double hieght;
double bases;
bool cont = true;
string ans = string.Empty;



do
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("Programe to compute area of shapes");
    Console.WriteLine("***********************************");
    Console.WriteLine();
    Console.WriteLine("Shape Area - Select a shape:");
    Console.WriteLine();

    Console.Beep();
    Console.WriteLine("1. Area of Circle");
    Console.WriteLine("2. Area of Rectangle");
    Console.WriteLine("3. Area of Triangle");
    Console.WriteLine("4. Area of Square");
    Console.WriteLine("5. Close Application");
    Console.WriteLine();

    Console.Write("Option: ");
    option = Convert.ToInt32(Console.ReadLine());
    Console.Beep();
    Console.WriteLine();
    switch (option)
    {
        case 1:
            Console.Write("Input Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input SI Unit: ");
            string si = Convert.ToString(Console.ReadLine());
            area = shape.CircleArea(radius, pi);
            Console.WriteLine("Area of Circle: " + area + " " + si);
            break;

        case 2:
            Console.Write("Input Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Breadth: ");
            breadth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input SI Unit: ");
            string sir = Convert.ToString(Console.ReadLine());
            area = shape.RectangleArea(length, breadth);
            Console.WriteLine("Area of Rectangle: " + area + " " + sir + "sqr");
            break;

        case 3:
            Console.Write("Inpute Height: ");
            hieght = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inpute Bases: ");
            bases = Convert.ToDouble(Console.ReadLine());
            area = shape.TriangleArea(hieght, bases);
            Console.WriteLine("Area of Triangle: " + area);
            break;

        case 4:
            Console.Write("Input Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input SI Unit: ");
            string sis = Convert.ToString(Console.ReadLine());
            area = shape.SquareArea(length);
            Console.WriteLine("Area of Square : " + area + " " + sis + "sqr");
            break;
        case 5:
            Console.WriteLine();
            Console.WriteLine("Thank you for using this app.");
            Console.WriteLine();
            Console.Beep();
            Environment.Exit(0);
            break;

    }
    Console.WriteLine();
    Console.Beep();
    Console.Write("Do you want to continue? Yes(Y) or No(N): ");
    ans = Console.ReadLine();
    if (ans.ToLower() == "yes" || ans.ToLower() == "y")
    {
        cont = true;
    }
    else
    {
        cont = false;
    }
}while (cont == true);

Console.WriteLine();
Console.WriteLine("Thank you for using this app.");
Console.WriteLine();









