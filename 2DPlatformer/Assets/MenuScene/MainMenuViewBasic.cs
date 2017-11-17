using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuViewBasic: IMainMenuView{

	public MainMenuViewBasic()
	{
	}

	public void ShowMainView()
	{
		//Debug.Log ("We in ShowMainSelectionView!");
		SceneManager.LoadScene("MenuScene");
	}

	public void ShowSettingsView()
	{
	}
	public void ShowLevelSelectionView()
	{
		//Debug.Log ("We in ShowLevelSelectionView!");
		SceneManager.LoadScene("LevelSelectionScene");
	}

	public void ShowLevelItemSelectionView ()
	{
		//Debug.Log ("We in ShowItemSelectionView!");
		SceneManager.LoadScene("PowerupSelectorScene");
	}
	public void SetController()
	{
	}

	public void ShowTestLevelView()
	{
		SceneManager.LoadScene("Test");
	}

}
