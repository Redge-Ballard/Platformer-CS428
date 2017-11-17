using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour {
	//MasterController theMaster = MasterController.Instance;
	MainMenuViewBasic menuViewBasic = new MainMenuViewBasic();
	static SceneControllerMainMenu menuController = new SceneControllerMainMenu();





	// Use this for initialization
	void Start () {
		menuViewBasic = new MainMenuViewBasic();
		menuController = new SceneControllerMainMenu();
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


		MasterController.instance.registerAsSceneController (menuController);

		ActionObjectShowLevelSelectionsView a_actionObject = new ActionObjectShowLevelSelectionsView();

		//theMaster.Start();
		SceneControllerMainMenu SceneControl = (SceneControllerMainMenu)MasterController.instance.GetSceneController();
		SceneControl.showLevelSelectionView (a_actionObject);

	}
}
