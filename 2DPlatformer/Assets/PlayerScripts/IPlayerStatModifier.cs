using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerStatModifier
{
    PlayerStatType GetType();
    int GetAmount();
    int GetRemainingDuration();
    int ModifyStat(PlayerStatType statType);
    void DecrementDuration();
}
