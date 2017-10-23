using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (ShowVictory ());
		Vector3 vec = transform.position;
		vec.x = 5;
		transform.position = vec;
	}//Queue

	// Update is called once per frame
	void Update () {

	}

	IEnumerator ShowVictory(){
		print ("Hello");
		yield return new WaitForSeconds (3);
		Debug.Log ("Hi");
		lives = 100;
	}
}
