using System;

public class Hand
{
    public const int HANDVALUE_STONE = 0; //int value of stone
    public const int HANDVALUE_SCISSORS = 1; // int value of scissors
    public const int HANDVALUE_PAPER = 2; // int value of paper
    public static Hand[] hand = new Hand[] { new Hand(HANDVALUE_STONE), new Hand(HANDVALUE_SCISSORS), new Hand(HANDVALUE_PAPER) }; //three hand moves objects
    private static readonly String[] name = new String[] { "STONE", "SCISSORS", "PAPER" }; //hand string expression

    private int handvalue; //this hand move
    private Hand(int handvalue)
	{
        this.handvalue = handvalue;
	}

    public static Hand GetHand(int handvalue) //get hand object from int value
    {
        return hand[handvalue];
    }

    public Boolean IsStrongerThan(Hand h) //if this stronger than h return true
    {
        return Fight(h) == 1;
    }

    public Boolean IsWeakerThan(Hand h) //if this weaker than h return true
    {
        return Fight(h) == -1;
    }

    private int Fight(Hand h) //thie vs h
    {
        if (this == h) //if draw return 0
        {
            return 0;
        }
        else if ((this.handvalue + 1) % 3 == h.handvalue) //if this won return 1
        {
            return 1;
        }
        else //if h won return -1
        {
            return -1;
        }
    }
    public override String ToString() //toString method
    {
            return name[handvalue];
    }
}
