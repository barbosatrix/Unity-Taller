using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class ScoreController : MonoBehaviour {

	private Text ScoreText;
	private float totalscore;
	private GameObject[] cookies;

	void Start () {
		ScoreText = FindObjectOfType(typeof(Text))as Text;
		cookies=GameObject.FindGameObjectsWithTag("Cookie");
		foreach(GameObject cookie in cookies)
			cookie.GetComponent<Cookie>().touched +=HandleCookieTouched;
	}
	void Update(){
		ScoreText.text="El puntaje total es:"+totalscore;

	}

	void HandleCookieTouched(){
		totalscore += 1;
		ScoreText.text="El puntaje es"+totalscore;
	}

	public void SuperCookieTouched(){
		totalscore=+10;

	}

}
