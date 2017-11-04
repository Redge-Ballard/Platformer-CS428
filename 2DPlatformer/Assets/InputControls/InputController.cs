using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : Inputs
{
    Inputs inputs; 

    public InputController(Inputs inputs)
    {
        this.inputs = inputs;
    }

    public Inputs Inputs() 
    {
        return inputs;
    }

    public void Inputs(Inputs inputs)
    {
        this.inputs = inputs;
    }

    public void pressA()
    {
        inputs.pressA();
    }

    public void pressD()
    {
        inputs.pressD();
    }

    public void pressJump()
    {
        inputs.pressJump();
    }

    public void pressS()
    {
        inputs.pressS();

    }

    public void pressW()
    {
        inputs.pressW();
    }
}
