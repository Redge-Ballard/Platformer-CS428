using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		//Debug.Log ("calling initialization");
		//theMaster = MasterController.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void backToMenu()
    {
		ActionObjectShowMainMenu a_actionObject = new ActionObjectShowMainMenu();
		SceneControllerMainMenu SceneControl = (SceneControllerMainMenu)MasterController.instance.GetSceneController();
		SceneControl.showMainMenu (a_actionObject);
    }

    public void buttonClick(int buttonID)
    {
		
		ActionObjectShowLevelAbilitySelectionView a_actionObject = new ActionObjectShowLevelAbilitySelectionView();
		SceneControllerMainMenu SceneControl = (SceneControllerMainMenu)MasterController.instance.GetSceneController();
		SceneControl.showLevelAbilitySelectionView (a_actionObject);


    }
}
