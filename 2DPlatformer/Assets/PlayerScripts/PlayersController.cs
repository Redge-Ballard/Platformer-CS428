using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersController : IPlayersController {

    List<IPlayer> players;

    public IPlayer GetPlayer(int playerNum)
    {
        return null;
    }

    public List<IPlayer> getPlayers()
    {
        return players;
    }

}
