//length, width, and height



using ClassBoxData.Models;

double inputLength = double.Parse(Console.ReadLine());
double inputWidth = double.Parse(Console.ReadLine());
double inputHeight = double.Parse(Console.ReadLine());

try
{
    Box box = new Box(inputLength, inputWidth, inputHeight);

    Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
    Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
    Console.WriteLine($"Volume - {box.Volume():f2}");
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}