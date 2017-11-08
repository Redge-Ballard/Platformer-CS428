using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{

    private int baseHealth;
    private int baseSpeed;
    private int baseAcceleration;
    private int baseJumpPower;
    private List<IPlayerStatModifier> persistentModifiers;
    private List<IPlayerStatModifier> modifiers;
    private List<IPlayerListener> listeners;

    void Awake()
    {
        //MasterController.Instance.GetCurrentSceneController().RegisterPlayerScript();

        baseHealth = 1;
    }

    /*
     * Helper function that takes the stat type and specific base stat and iterates over the modifiers, 
     * sums up the stat changes, and returns the final stats value 
     */
    private int StatHelper(PlayerStatType type, int stat_base)
    {
        int final = stat_base;
        foreach(IPlayerStatModifier mod in persistentModifiers)
        {
            if(mod.GetType() == type)
            {
                final += mod.GetAmount();
            }
        }
        return final;
    }

    public bool AddListener(IPlayerListener playerListener)
    {
        listeners.Add(playerListener);
        return true;
    }

    //does this return base health? Or does it need to account for modifiers? 
    public int GetHealth()
    {
        return baseHealth;
    }

    //what does this return? the amount of damage taken? Or the current health after taking dmg? 
    public void TakeDamage(int dmg)
    {
        baseHealth -= dmg;
        UpdateListeners();
    }

    public int GetSpeed()
    {
        return StatHelper(PlayerStatType.Speed, baseSpeed);
    }

    public int GetAcceleration()
    {
        return StatHelper(PlayerStatType.Acceleration, baseAcceleration);
    }

    public int GetJumpPower()
    {
        return StatHelper(PlayerStatType.JumpPower, baseJumpPower);
    }

    public bool AddPersistentModifier(IPlayerStatModifier modifier)
    {
        persistentModifiers.Add(modifier);
        UpdateListeners();
        return true;
    }

    public bool AddModifier(IPlayerStatModifier modifier)
    {
        modifiers.Add(modifier);
        UpdateListeners();
        return true;
    }

    //removes both permanent and temp ones? Or should we remove just temp ones? 
    public bool RemoveAllModifiers()
    {
        persistentModifiers = new List<IPlayerStatModifier>();
        modifiers = new List<IPlayerStatModifier>();
        UpdateListeners();
        return true;
    }

    //just for temp?
    public bool RemoveNegativeModifiers()
    {
        //iterate through and remove negative modifiers
        foreach(IPlayerStatModifier mod in modifiers)
        {
            if(mod.GetAmount() < 0)
            {
                modifiers.Remove(mod);
            }
            UpdateListeners();
        }
        return true;
    }

    public bool RemovePositiveModifiers()
    {
        //itrate through and remove positive modifiers
        foreach (IPlayerStatModifier mod in modifiers)
        {
            if (mod.GetAmount() > 0)
            {
                modifiers.Remove(mod);
            }
        }
        UpdateListeners();
        return true;
    }

    public void UpdateListeners()
    {
        foreach(IPlayerListener listen in listeners)
        {
            listen.Update();
        }
    }
}
