using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayer  {

    bool AddListener(IPlayerListener playerListener);
    List<IItem> GetItems();
    int GetHealth();
    int TakeDamage();
    int GetSpeed();
    int GetAcceleration();
    int GetJumpPower();
    bool AddPersistentModifier(IPlayerStatModifier modifier);
    bool AddModifier(IPlayerStatModifier modifier);
    bool RemoveAllModifiers();
    bool RemoveNegativeModifiers();
    bool RemovePositiveModifiers();
}
