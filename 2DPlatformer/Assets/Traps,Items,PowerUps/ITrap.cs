using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrap {

    //either modifies the health or adds a statmodifier to the player (depending on the type of trap)
    void TrapPlayer(IPlayer player);
    int GetBaseCooldown();
    int GetRemainingCooldown();
}
