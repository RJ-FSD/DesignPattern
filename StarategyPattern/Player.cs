using System;

public class Player
{
    private String name;
    private IStrategy strategy;
    private int wincount;
    private int losecount;
    private int gamecount;

	public Player(String name, IStrategy strategy)//creates a player with choosen strategy
	{
        this.name = name;
        this.strategy = strategy;
	}

    public Hand NextHand()//ask strategy for next hand move
    {
        return strategy.NextHand();
    }

    public void Win()//match result is win
    {
        strategy.Study(true);
        wincount++;
        gamecount++;
    }
    public void Lose()//match result is lose
    {
        strategy.Study(true);
        losecount++;
        gamecount++;
    }
    public void Even()//match result is draw
    {
        gamecount++;
    }
    public override String ToString()
    {
        return "[" + name + ":" + gamecount + "games, " + wincount + "win, " + losecount + "  lose" + "]";
    }
}
