using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersController : IPlayersController, IPlayerListener {

    List<IPlayer> players;
    List<IPlayersControllerListener> listeners;

    public PlayersController()
    {
        Player player = new Player();
        player.AddListener(this);
    }

    public IPlayer GetPlayer(int playerNum)
    {
        return players[playerNum];
    }

    public List<IPlayer> getPlayers()
    {
        return players;
    }

    public void AddListener(IPlayersControllerListener listener)
    {
        listeners.Add(listener);
    }

    public void Update()
    {
        //notifies the scene controller that things have happened 
        foreach(IPlayersControllerListener listen in listeners)
        {
            listen.Update();
        }
    }

}
