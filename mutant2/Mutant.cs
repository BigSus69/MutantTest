public class Mutant
{
    public string name = "Unset";
    public Mutant(string name1)
    {
        new Random().Next(1,100);

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

}