using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISceneController : IInputsControllerListener, IPlayersControllerListener {
    void registerPlayer(IPlayer player);
}
