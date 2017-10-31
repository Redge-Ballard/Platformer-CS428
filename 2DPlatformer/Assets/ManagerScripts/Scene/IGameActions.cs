using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameActions {
	void changeScene (ActionObjectChangeScene a_actionObject);
	void showMainMenu(ActionObjectShowMainMenu a_actionObject);
	void showSettingsView(ActionObjectShowSettingsView a_actionObject);
	void showLevelSelectionView(ActionObjectShowLevelSelectionsView a_actionObject);
	void showLevelAbilitySelectionView(ActionObjectShowLevelAbilitySelectionView a_actionObject);
	void selectLevelAbility(ActionObjectSelectLevelAbility a_actionObject);
	void playerUseAbility(ActionObjectPlayerUseAbility a_actionObject);
	void playerMoveDirection(ActionObjectPlayerMoveDirection a_actionObject);
}
