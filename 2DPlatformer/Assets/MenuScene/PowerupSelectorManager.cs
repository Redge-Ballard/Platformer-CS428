using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PowerupSelectorManager : MonoBehaviour {
    HashSet<string> listOfSelections;
	//MasterController theMaster = MasterController.Instance;
    // Use this for initialization
    void Start () {
        listOfSelections = new HashSet<string>();
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


	public void play()
	{
		//TODO: need to switch to whatever level we need. Also somehow pass the contents of ListOfSelections to it. 
		//Debug.Log("TODO: switch to the level scene");

		ActionObjectChangeScene a_actionObject = new ActionObjectChangeScene();
		SceneControllerMainMenu SceneControl = (SceneControllerMainMenu)MasterController.instance.GetSceneController();
		SceneControl.changeScene (a_actionObject);

	}


	public void genericButtonSelected()
	{
		string nameOfButton = EventSystem.current.currentSelectedGameObject.name;
		//Debug.Log (nameOfButton);
		powerupSelected(nameOfButton);
	}

	/**
	 * Meant to select (highlight) the button given
	 */
	public void selectButton(string buttonName)
	{
		UnityEngine.UI.Button btn = GameObject.Find(buttonName).GetComponent<Button>();
		//btn.Select();
		btn.image.color = Color.black;
	}

	/**
	 * Meant to deselect (unhighlight) the button given
	 */
	public void deselectButton(string buttonName)
	{
		UnityEngine.UI.Button btn = GameObject.Find(buttonName).GetComponent<Button>();
		//btn.OnDeselect (null);
		btn.image.color = Color.white;

	}

	/**
	 * 
	 * Given a button name, e.g. "DoubleJump," this function will add to a list the selected button IF it can be selected. It also calls 
	 * functions handling the UI (selection and deselection) of the buttons
	 */
    void powerupSelected(string buttonName)
    {
		//Debug.Log ("In powerup Selected!");
		if (listOfSelections.Contains(buttonName))
        {
            listOfSelections.Remove(buttonName);
			deselectButton (buttonName);
			Debug.Log ("Deselecting " + buttonName);
        }
        else
        {
            if (listOfSelections.Count >= 3)
            {
                //can't do anything. Don't select or deselect. 
            }
            else
            {
                listOfSelections.Add(buttonName);
				selectButton (buttonName);
				Debug.Log ("Selecting " + buttonName);
            }
        }

        
        
        
    }
}
