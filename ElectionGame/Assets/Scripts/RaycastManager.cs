using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastManager : MonoBehaviour {

	public LayerMask layer;
	public float raycastDistance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Raycast ();
	}

	void Raycast(){
		Vector3 fwd = GetComponentInChildren<Camera> ().transform.TransformDirection (Vector3.forward);
		RaycastHit hit;

		if(Physics.Raycast(this.transform.position, fwd, out hit, raycastDistance, layer)){
			GameObject go = hit.collider.gameObject;
			Debug.Log ("hit object: " + go.name);
		}
	}

}
