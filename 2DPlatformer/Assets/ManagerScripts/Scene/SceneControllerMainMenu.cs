using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneControllerMainMenu: ISceneController{

	private IMainMenuView theMenuView; //this is the "basic" version of the main menu; we just need to change the class if it's ever implemented
	public SceneControllerMainMenu()
	{
		theMenuView = new MainMenuViewBasic ();
	}


	public void changeScene (ActionObjectChangeScene a_actionObject)
	{
		SceneControllerGenericLevel newSceneController = new SceneControllerGenericLevel ();
		MasterController.instance.registerAsSceneController (newSceneController);


		MainMenuViewBasic theBasicMenuView = (MainMenuViewBasic)theMenuView; //todo: should we do something different here? Seems like this isn't the right avenue. 
		theBasicMenuView.ShowTestLevelView ();
	}

	public void showMainMenu(ActionObjectShowMainMenu a_actionObject)
	{
		theMenuView.ShowMainView();
	}

	public void showSettingsView(ActionObjectShowSettingsView a_actionObject)
	{
	}

	public void showLevelSelectionView(ActionObjectShowLevelSelectionsView a_actionObject)
	{
		theMenuView.ShowLevelSelectionView ();
	}

	public void showLevelAbilitySelectionView(ActionObjectShowLevelAbilitySelectionView a_actionObject)
	{
		theMenuView.ShowLevelItemSelectionView ();
	}

	public void selectLevelAbility(ActionObjectSelectLevelAbility a_actionObject)
	{
	}

	public void playerUseAbility(ActionObjectPlayerUseAbility a_actionObject)
	{
	}

	public void playerMoveDirection(ActionObjectPlayerMoveDirection a_actionObject)
	{
	}

    public void menuMoveDirection(ActionObjectMoveMenuDirection a_actionObject)
    {
    }

    public void registerPlayer(IPlayer player)
    {
        throw new System.NotImplementedException();
    }

    public void playerJump(ActionObjectJump a_actionObject)
    {
        throw new System.NotImplementedException();
    }
}
