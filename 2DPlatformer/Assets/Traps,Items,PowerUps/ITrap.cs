using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrap {

    void TrapPlayer(IPlayer player);
    int GetBaseCooldown();
    int GetRemainingCooldown();
}
