using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockToCharacter : MonoBehaviour {

	public GameObject Character;
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Character.transform.position;
		pos.z = transform.position.z;
		gameObject.transform.position = pos;
	}
}
