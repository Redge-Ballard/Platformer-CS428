using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayersController {

    IPlayer GetPlayer(int playerNumber);
    List<IPlayer> getPlayers();

}
