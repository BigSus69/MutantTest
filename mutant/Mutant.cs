using System.Reflection.Metadata.Ecma335;

public class Mutant
{
    public string name = "Unset";
    int age = 69;
    float height = 6.9f;
    bool isMale = true;

    public Mutant(string name1)
    {
        name = name1;
        Random rnd = new Random();
        int bigArmNumber = rnd.Next(1,5);
        int bigLegNumber = rnd.Next(2,6);

        Arm[] arm = new Arm[bigArmNumber];
        for (int i = 0; i < bigArmNumber; i++)
        {
            arm[i] = new Arm();
        }

        Leg[] leg = new Leg[bigLegNumber];
        for (int i = 0; i < bigLegNumber; i++)
        {
            leg[i] = new Leg();
        }

        Console.WriteLine("I have " + bigArmNumber + " arms and " + bigLegNumber + " legs.");
    }

    public void initiateCarPurchase()
    {
        Car car = new Car();
        car.purchase();
    }

    public void Greet(Mutant other)
    {
        Console.WriteLine("Hello " + other.name + ", my name is " + name + ".");
    }
}