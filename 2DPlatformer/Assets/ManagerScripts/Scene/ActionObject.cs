using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class ActionObject{
	//An abstract base class from which other action objects inherit
}
public class ActionObjectChangeScene : ActionObject{

}
public class ActionObjectShowMainMenu : ActionObject{
	//todo: take in variables for startup?
}
public class ActionObjectShowSettingsView : ActionObject{

}
public class ActionObjectShowLevelSelectionsView : ActionObject{
	//todo: take in levels unlocked
}
public class ActionObjectShowLevelAbilitySelectionView : ActionObject{
	//todo: take in abilities unlocked and level selected
}
public class ActionObjectSelectLevelAbility : ActionObject{
	//call this within PowerupSelectorManager
}
public class ActionObjectPlayerUseAbility : ActionObject{
	public int PlayerNum { get; set; }
	public IPlayerStatModifier Modifier { get; set; }
	public ActionObjectPlayerUseAbility(int playerNumber, IPlayerStatModifier modifier)
	{
		this.PlayerNum = playerNumber;
		this.Modifier = modifier;
	}

}

public class ActionObjectJump : ActionObject
{

}

public class ActionObjectPlayerMoveDirection : ActionObject{
    public Vector2 Direction { get; set; }
    public int PlayerNumber { get; set; }

    public ActionObjectPlayerMoveDirection(int playerNumber, Vector2 direction)
    {
        this.PlayerNumber = playerNumber;
        this.Direction = direction;
    }
}

public class ActionObjectMoveMenuDirection : ActionObject
{
    


}