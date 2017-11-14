using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{

    private int baseHealth;
    public int baseSpeed;
    public int baseAcceleration;
    public int baseJumpPower = 500;
    private List<IPlayerStatModifier> persistentModifiers;
    private List<IPlayerStatModifier> modifiers;
    private List<IPlayerListener> listeners;
    private bool isGrounded = false;

    void Start()
    {
        //print("start of player controller");
        MasterController.instance.registerPlayer(this);
        persistentModifiers = new List<IPlayerStatModifier>();
        modifiers = new List<IPlayerStatModifier>();
        listeners = new List<IPlayerListener>();
        baseHealth = 1;
    }

    void Update()
    {
        //Vector2 vec = new Vector2(.01f, 0);
        //PlayerMove(vec);
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

    public void Jump()
    {
        if (isGrounded) {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, GetJumpPower()));
        }
    }

    //public bool IsGrounded()
    //{
    //    re
    //}

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") {
            isGrounded = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }
    //public void AddPlayer(IPlayer player) {

    //}
}
