using UnityEngine;
using System.Collections;

public interface IGameStateListener
{

    // Update is called once per frame
    void UpdateForNewGameState(GameState gameState);
}
