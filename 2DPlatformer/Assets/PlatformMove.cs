using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {

	public GameObject target;
	public float speed = 1;

	private Vector3 start;
	private Vector3 end;
	private Vector3 goTo;


	// Use this for initialization
	void Start () {
		start = transform.position;
		end = target.transform.position;
		goTo = end;
		target.transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, goTo, step);
		if (transform.position == end) {
			goTo = start;
		}
		if (transform.position == start) {
			goTo = end;
		}
	}
}
