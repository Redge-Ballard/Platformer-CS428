using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour {
	MasterController theMaster = MasterController.Instance;
	MainMenuViewBasic menuViewBasic = new MainMenuViewBasic();
	// Use this for initialization
	void Start () {
		theMaster.initializeMenuSceneController();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void QuickPlay()
    {
		//TODO: maybe go immediately to section 1
		//SceneManager.LoadScene("InitialScene");
		Debug.Log("TODO: Need to open some new level scene.");
    }


    public void LevelSelect()
    {
        //SceneManager.LoadScene("LevelSelectionScene");
		//Debug.Log ("Level select dawg");
		//menuViewBasic.ShowLevelSelectionView();
		ActionObjectShowLevelSelectionsView a_actionObject = new ActionObjectShowLevelSelectionsView();

		//theMaster.Start();
		SceneControllerMainMenu SceneControl = (SceneControllerMainMenu)theMaster.GetSceneController();
		SceneControl.showLevelSelectionView (a_actionObject);

	}
}
