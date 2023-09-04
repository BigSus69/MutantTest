public class Arm
{
    public Arm()
    {
        Random rnd = new Random();
        int bigHandNumber = rnd.Next(7,15);
        Hand[] hands = new Hand[bigHandNumber];
        for(int i = 0; i < bigHandNumber; i++)
        {
            hands[i] = new Hand();
        }
    }
}