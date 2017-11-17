using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllerGenericLevel : MonoBehaviour, ISceneController {

    IPlayersController playerController;


    public void changeScene(ActionObjectChangeScene a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void menuMoveDirection(ActionObjectMoveMenuDirection a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void playerJump(ActionObjectJump a_actionObject)
    {
        IPlayer player = playerController.GetPlayer(0);
        player.Jump();
    }

    public void playerMoveDirection(ActionObjectPlayerMoveDirection a_actionObject)
    {
        IPlayer player = playerController.GetPlayer(0);
        player.PlayerMove(a_actionObject.Direction);
    }

    public void playerUseAbility(ActionObjectPlayerUseAbility a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void registerPlayer(IPlayer player)
    {
        this.playerController.AddPlayer(player);
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

    public void Start()
    {
        this.playerController = new PlayersController();
        playerController.AddListener(this);
        MasterController.instance.registerAsSceneController(this);
    }

    public void UpdateState()
    {
        print("I'm being notified");
        IPlayer player = playerController.GetPlayer(0);
        if (player.GetHealth() <= 0)
        {
           print("Player is dead"); 
        }
    }
}
