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

    private void Start()
    {
        this.inputsController = MasterController.instance.getInputsController();
    }
    private void Update()
    {
        float horizontalMove = 0;
        if (Input.GetKey("d"))
        {
            horizontalMove += .1f;
        }

        if (Input.GetKey("a"))
        {
            horizontalMove -= .1f;
        }
        Vector2 moveVect = new Vector2(horizontalMove, 0);
        ActionObjectPlayerMoveDirection move = new ActionObjectPlayerMoveDirection(1, moveVect);
        inputsController.playerMoveDirection(move);
    }
}
