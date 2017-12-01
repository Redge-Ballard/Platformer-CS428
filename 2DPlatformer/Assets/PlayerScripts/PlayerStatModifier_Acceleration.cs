using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatModifier_Acceleration : IPlayerStatModifier {
    public int Duration { get; set; }
    public int Amount { get; set; }



    public PlayerStatModifier_Acceleration(int duration, int amount)
    {
        Duration = duration;
        Amount = amount;
    }


    public PlayerStatType GetType()
    {
        return PlayerStatType.Acceleration;
    }

    public int GetAmount()
    {
        return Amount;
    }

    public int GetRemainingDuration()
    {
        return Duration;
    }

    public int ModifyStat(PlayerStatType statType)
    {
        throw  new NotImplementedException();
    }

    public void DecrementDuration()
    {
        this.Duration -= 1;
    }
}
