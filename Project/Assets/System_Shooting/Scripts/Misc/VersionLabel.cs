using UnityEngine;
using System.Collections;

public class VersionLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		GUI.Label(new Rect(Screen.width/2-105, Screen.height-24, 450, 25), "War of Empire Free Version 0.0.1  Johan Fournel w/Matteo Fabbro");
	}
}
