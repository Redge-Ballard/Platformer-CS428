using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem  {

    void useItem(IPlayer player);
    int getBaseCooldown();
    int getRemainingCooldown();
}
