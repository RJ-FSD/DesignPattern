using System;

public interface IStrategy
{
    Hand NextHand(); //decide next move
    void Study(Boolean win); //memorize previous move
}
