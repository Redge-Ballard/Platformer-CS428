using UnityEngine;
using System.Collections;

public class InputsMainMenuSettings : IInputs
{

    IInputsController inputsController;

    public InputsMainMenuSettings(IInputsController inputsController)
    {
        this.inputsController = inputsController;
    }

    public InputsMainMenuSettings()
    {
    }

    public void pressS()
    {
        // Not sure how we want to facilitate moving up and down in the menu
        //ActionObjectMoveMenuDirection action = new ActionObjectMoveMenuDirection();
        //gameActions.menuMoveDirection(action);
    }

    public void pressW()
    {
        //ActionObjectMoveMenuDirection action = new ActionObjectMoveMenuDirection();
        //gameActions.menuMoveDirection(action);
    }

    public void pressA()
    {
        // Do nothing

    }

    public void pressD()
    {
        // Do nothing

    }

    public void pressJump()
    {
        // Do nothing
    }

}
