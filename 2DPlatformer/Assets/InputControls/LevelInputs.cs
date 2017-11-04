using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInputs : Inputs
{
    IGameActions gameActions;

    public LevelInputs(IGameActions gameActions) 
    {
        this.gameActions = gameActions;
    }

    public void pressA()
    {
        ActionObjectPlayerMoveDirection moveRight = new ActionObjectPlayerMoveDirection();
        gameActions.playerMoveDirection(moveRight);
    }

    public void pressD()
    {
        ActionObjectPlayerMoveDirection moveRight = new ActionObjectPlayerMoveDirection();
        gameActions.playerMoveDirection(moveRight);
    }

    public void pressJump()
    {
        ActionObjectPlayerMoveDirection jump = new ActionObjectPlayerMoveDirection();
        gameActions.playerMoveDirection(jump);
    }

    public void pressS()
    {
        // Do nothing
    }

    public void pressW()
    {
        // Do nothing
    }
}
