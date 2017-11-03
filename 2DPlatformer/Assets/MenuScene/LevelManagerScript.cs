using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour {

	MasterController theMaster;//= MasterController.Instance;
	// Use this for initialization
	void Start () {
		//Debug.Log ("calling initialization");
		theMaster = MasterController.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void backToMenu()
    {
		ActionObjectShowMainMenu a_actionObject = new ActionObjectShowMainMenu();
		SceneControllerMainMenu SceneControl = (SceneControllerMainMenu)theMaster.GetSceneController();
		SceneControl.showMainMenu (a_actionObject);
    }

    public void buttonClick(int buttonID)
    {
		Debug.Log ("hit that button yo");
		ActionObjectShowLevelAbilitySelectionView a_actionObject = new ActionObjectShowLevelAbilitySelectionView();
		SceneControllerMainMenu SceneControl = (SceneControllerMainMenu)theMaster.GetSceneController();
		SceneControl.showLevelAbilitySelectionView (a_actionObject);

		//SceneManager.LoadScene("Level_" + buttonID);
    }
}
