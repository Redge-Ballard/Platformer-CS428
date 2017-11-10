using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsController : MonoBehaviour, IInputsController
{
    IInputs inputs;
    private List<IInputsControllerListener> listeners;

    public InputsController(IInputs inputs)
    {
        this.inputs = inputs;
        this.listeners = new List<IInputsControllerListener>();
    }

    public void changeScene(ActionObjectChangeScene a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public IInputs Inputs() 
    {
        return inputs;
    }

    public void Inputs(IInputs inputs)
    {
        this.inputs = inputs;
    }

    public void menuMoveDirection(ActionObjectMoveMenuDirection a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void playerMoveDirection(ActionObjectPlayerMoveDirection a_actionObject)
    {
        foreach (IInputsControllerListener listener in this.listeners)
        {
            listener.playerMoveDirection(a_actionObject);
        }

    }

    public void playerUseAbility(ActionObjectPlayerUseAbility a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void selectLevelAbility(ActionObjectSelectLevelAbility a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void showLevelAbilitySelectionView(ActionObjectShowLevelAbilitySelectionView a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void showLevelSelectionView(ActionObjectShowLevelSelectionsView a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void showMainMenu(ActionObjectShowMainMenu a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void showSettingsView(ActionObjectShowSettingsView a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            //inputs.pressJump(); 
        }
    }


    private void Awake()
    {
        MasterController.Instance.addGameStateListener(this);
    }

    public void UpdateForNewGameState(GameState gameState)
    {
        switch (gameState) {
            case GameState.LevelSinglePlayer:
                inputs = new InputsLevelSinglePlayer(this);
                break;
        }
    }
}
