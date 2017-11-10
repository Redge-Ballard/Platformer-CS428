using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerUp {

    //calls addModifier on player object
    void PowerUpPlayer(IPlayer player);
}
