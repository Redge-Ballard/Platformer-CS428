using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersController : IPlayersController, IPlayerListener {

    List<IPlayer> players;
    List<IPlayersControllerListener> listeners;

    public PlayersController()
    {
        this.players = new List<IPlayer>();
        this.listeners = new List<IPlayersControllerListener>();
        //Player player = new Player();


        //player.AddListener(this);
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

    public void UpdatePlayerListener()
    {
        //notifies the scene controller that things have happened 
        foreach(IPlayersControllerListener listen in listeners)
        {
            listen.UpdateState();
        }
    }

    public void AddPlayer(IPlayer player)
    {
        player.AddListener(this);
        this.players.Add(player);
    }
}
