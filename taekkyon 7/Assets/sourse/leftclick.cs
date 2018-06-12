using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftclick : MonoBehaviour {
	int i=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	private void OnMouseDown()
	{
		Debug.Log ("a");
		i--;
		if (i == 2)
			GameObject.Find ("ch1").GetComponent<spritend> ().c3 ();
		if (i == 1)
			GameObject.Find ("ch1").GetComponent<spritend> ().c2 ();
		if (i == 0) {
			GameObject.Find ("ch1").GetComponent<spritend> ().c1 ();
			i = 3;
		}

	}
			
			
		
}
