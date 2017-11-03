using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMainMenuView {

	void ShowMainView();
	void ShowSettingsView();
	void ShowLevelSelectionView();
	void ShowLevelItemSelectionView ();
	void SetController();
}

