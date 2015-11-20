using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public GameObject Supercookie;
	private GameObject ActiveSuperCookie;
	public GameSettings Caracteristicas;
	public ScoreController score;

	// Use this for initialization
	void Start () {
		StartCoroutine(SheduleCookieCreate());
	}
	//crear un acorutina
	IEnumerator SheduleCookieDestroy () {
		yield return new WaitForSeconds(Caracteristicas.appear);
		Destroy (ActiveSuperCookie);
		StartCoroutine(SheduleCookieCreate());
	}
	IEnumerator SheduleCookieCreate(){

		yield return new WaitForSeconds(Caracteristicas.appear);
		ActiveSuperCookie = Instantiate(Supercookie);
		ActiveSuperCookie.transform.position= Caracteristicas.spawnPoints[Random.Range(0,Caracteristicas.spawnPoints.Count)];
		ActiveSuperCookie.GetComponent<Supercookie>().touched +=HandleuperCookieTouched;
		StartCoroutine(SheduleCookieDestroy());
	}

	void HandleuperCookieTouched(){
		score.SuperCookieTouched();

	}

}
