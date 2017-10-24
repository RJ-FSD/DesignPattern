using System;

public interface Strategy
{
    Hand NextHand(); //decide next move
    void Study(Boolean win); //memorize previous move
}
