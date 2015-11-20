using UnityEngine;
using System.Collections;

public class colision: MonoBehaviour {

	void OnTriggerEnter(Collider other){
		gameObject.SetActive (false);
		Debug.Log ("algo choco el objeto");
	}
}
