using System;

public class Player
{
    private String name;
    private Strategy strategy;
    private int wincount;
    private int losecount;
    private int gamecount;

	public Player(String name, Strategy strategy)//creates a player with choosen strategy
	{
        this.name = name;
        this.strategy = strategy;
	}

    public Hand nextHand()//ask strategy for next hand move
    {
        return strategy.nextHand();
    }

    public void win()//match result is win
    {
        strategy.study(true);
        wincount++;
        gamecount++;
    }
    public void lose()//match result is lose
    {
        strategy.study(true);
        losecount++;
        gamecount++;
    }
    public void even()//match result is draw
    {
        gamecount++;
    }
    public override String ToString()
    {
        return "[" + name + ":" + gamecount + "games, " + wincount + "win, " + losecount + "  lose" + "]";
    }
}
