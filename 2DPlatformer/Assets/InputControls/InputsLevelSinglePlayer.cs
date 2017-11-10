using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsLevelSinglePlayer : MonoBehaviour, IInputs
{
    private IInputsController inputsController;

    public InputsLevelSinglePlayer(IInputsController inputsController)
    {
        this.inputsController = inputsController; 
    }

    private void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            Vector2 right = new Vector2(1, 0);
            ActionObjectPlayerMoveDirection moveRight = new ActionObjectPlayerMoveDirection(1, right);
            inputsController.playerMoveDirection(moveRight);
        }
    }
}
