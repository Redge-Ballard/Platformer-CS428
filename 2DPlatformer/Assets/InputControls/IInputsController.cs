using UnityEngine;
using System.Collections;

public interface IInputsController : IGameActions, IGameStateListener
{
    void registerListener(IInputsControllerListener listener);
	void replaceListeners (IInputsControllerListener listener);
}
