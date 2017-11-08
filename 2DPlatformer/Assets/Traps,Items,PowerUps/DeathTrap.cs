﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrap : MonoBehaviour, ITrap {

    int cooldown;

	// Use this for initialization
	void Start () {
        //set cooldown 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //will notify player of collision  
    //maybe call TrapPlayer? 
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {

        }
    }

    public void TrapPlayer(IPlayer player)
    {
        player.TakeDamage(1);
    }

    public int GetBaseCooldown()
    {
        return cooldown;
    }

    //shouldn't this be in StatModifier?? 
    public int GetRemainingCooldown()
    {
        return 0;
    }
}