using System;

public interface Strategy
{
    Hand nextHand(); //decide next move
    void study(Boolean win); //memorize previous move
}
