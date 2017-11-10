using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllerGenericLevel : ISceneController {

    IPlayersController playerController;


    public void changeScene(ActionObjectChangeScene a_actionObject)
    {
        throw new System.NotImplementedException();
    }

    public void menuMoveDirection(ActionObjectMoveMenuDirection a_actionObject)
    {
        List<IPlayer> players = playerController.getPlayers();
        IPlayer player = players[0];
    }

    public void playerMoveDirection(ActionObjectPlayerMoveDirection a_actionObject)
    {
        throw new System.NotImplementedException();
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

}
