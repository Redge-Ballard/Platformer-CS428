﻿using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{

    private int baseHealth;
    public float currentMomentum = 0;
    public float baseMaxSpeed = 1;
    public float baseAcceleration = 1;
    public float baseJumpPower = 500;
    private List<IPlayerStatModifier> persistentModifiers;
    private List<IPlayerStatModifier> modifiers;
    private List<IPlayerListener> listeners;
    private bool isGrounded = false;

    void Start()
    {
        MasterController.instance.registerPlayer(this);
        persistentModifiers = new List<IPlayerStatModifier>();
        modifiers = new List<IPlayerStatModifier>();
        listeners = new List<IPlayerListener>();
        baseHealth = 1;
    }

    public void PlayerMove(Vector2 move)
    {
        Vector3 pos = transform.position;
        pos.x += move.x;
        pos.y += move.y;
        transform.position = pos;
    }

    /*
     * Helper function that takes the stat type and specific base stat and iterates over the modifiers, 
     * sums up the stat changes, and returns the final stats value 
     */
    private float StatHelper(PlayerStatType type, float stat_base)
    {
        float final = stat_base;
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
        print("In Player taking damage");
        baseHealth -= dmg;
        UpdateListeners();
    }
    public float GetMaxSpeed()
    {
        return StatHelper(PlayerStatType.Speed, baseMaxSpeed);
    }

    public float GetCurrentMomentum()
    {
        return StatHelper(PlayerStatType.Speed, currentMomentum);
    }

    public float GetAcceleration()
    {
        return StatHelper(PlayerStatType.Acceleration, baseAcceleration);
    }

    public float GetJumpPower()
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
        foreach(IPlayerListener listener in listeners)
        {
            listener.Update();
        }
    }

    public void Jump()
    {
        if (isGrounded) {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, GetJumpPower()));
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            isGrounded = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        }
    }
}
