using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderToBounds : MonoBehaviour {

	public SpriteRenderer blackBox;

	// Use this for initialization
	void Start () {
		SpriteRenderer sprite = GetComponent<SpriteRenderer> ();
		Vector2 bounds = sprite.size;
		GetComponent<BoxCollider2D> ().size = bounds;
		blackBox.size = sprite.size - new Vector2 (0.5f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
