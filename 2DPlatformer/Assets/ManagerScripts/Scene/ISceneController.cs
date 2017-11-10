using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISceneController : IInputsControllerListener {
    void registerPlayer(IPlayer player);
}
