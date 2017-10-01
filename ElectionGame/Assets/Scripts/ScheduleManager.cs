using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScheduleManager : MonoBehaviour {

	//need to load CSV file to get full list of items

	GameObject[] events;

	// Use this for initialization
	void Start () {
		events = GameObject.FindGameObjectsWithTag ("Target");
		foreach(GameObject ev in events){
			ev.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject ev in events){
			if(ev.GetComponent<TargetManager>().startTime < Time.time && ev.GetComponent<TargetManager>().endTime > Time.time ){
				ev.SetActive (true);
			}else{
				ev.SetActive (false);
			}
		}
	}
}
