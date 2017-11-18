using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsMainMenu : IInputs
{
    IInputsController inputsController;

    public InputsMainMenu(IInputsController inputsController)
    {
        this.inputsController = inputsController;
    }

    public void pressA()
    {
        throw new System.NotImplementedException();
    }

    public void pressD()
    {
        throw new System.NotImplementedException();
    }

    public void pressJump()
    {
        throw new System.NotImplementedException();
    }

    public void pressS()
    {
        throw new System.NotImplementedException();
    }

    public void pressW()
    {
        throw new System.NotImplementedException();
    }
}
