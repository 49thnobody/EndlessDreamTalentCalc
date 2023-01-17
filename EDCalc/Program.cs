int talentPoints;
int pointSpent;

while (true)
{
    try
    {
        Console.Write("Enter Talent Points: ");
        talentPoints = int.Parse(Console.ReadLine());

        Console.Write("Enter Point Spent: ");
        pointSpent = int.Parse(Console.ReadLine());

        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    } 
}

var calculations = Calculator.Calculate(talentPoints, pointSpent);

Console.WriteLine("Calculations:");
Console.WriteLine(calculations);

Console.ReadKey();