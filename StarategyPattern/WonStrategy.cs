using System;

public class WonStrategy : Strategy //strategy that chooses next move which won previously  
{
    private Random rand;
    private Boolean won = false;
    private Hand prevHand; 
	public WonStrategy(int seed)
	{
        rand = new Random(seed);
	}
    public Hand nextHand()
    {
        if(!won)
        {
            prevHand = Hand.getHand(rand.Next(3));
        }
        return prevHand;
    }
    public void study(Boolean win)
    {
        won = win;
    }
}
