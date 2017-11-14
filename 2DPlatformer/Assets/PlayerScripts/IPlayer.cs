using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayer
{

    bool AddListener(IPlayerListener playerListener);
    int GetHealth();
    void TakeDamage(int dmg);
    float GetCurrentMomentum();
    float GetMaxSpeed();
    float GetAcceleration();
    float GetJumpPower();
    bool AddPersistentModifier(IPlayerStatModifier modifier);
    bool AddModifier(IPlayerStatModifier modifier);
    bool RemoveAllModifiers();
    bool RemoveNegativeModifiers();
    bool RemovePositiveModifiers();
    void PlayerMove(Vector2 direction);
    void Jump();
}
