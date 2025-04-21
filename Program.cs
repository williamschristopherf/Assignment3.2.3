using Assignment3._2._3;

Console.WriteLine("Enter the radius of circle 1. ");
double radius1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the radius of circle 2. ");
double radius2 = Convert.ToDouble(Console.ReadLine());

Circle circle1 = new Circle(radius1);
Circle circle2 = new Circle(radius2);

double sum = circle1 + circle2;
double difference = circle1 - circle2;

Console.WriteLine($"Area of circle 1 is {circle1.area}");
Console.WriteLine($"Area of circle 2 is {circle2.area}");
Console.WriteLine($"Sum of the area of the 2 circles is {sum}");
Console.WriteLine($"Difference of the area of the 2 circles is {difference}");