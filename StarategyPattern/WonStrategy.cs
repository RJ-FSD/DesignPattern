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
    public Hand NextHand()
    {
        if(!won)
        {
            prevHand = Hand.GetHand(rand.Next(3));
        }
        return prevHand;
    }
    public void Study(Boolean win)
    {
        won = win;
    }
}
