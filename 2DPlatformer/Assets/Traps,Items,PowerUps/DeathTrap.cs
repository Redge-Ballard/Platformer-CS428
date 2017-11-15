using System.Collections;
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
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            IPlayer player = collision.gameObject.GetComponent<IPlayer>();
            TrapPlayer(player);
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
