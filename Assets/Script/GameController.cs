using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject Supercookie;
	private GameObject ActiveSuperCookie;

	// Use this for initialization
	void Start () {
		Instantiate(Supercookie);
		StartCoroutine(SheduleCookieDestroy());
	}
	//crear un acorutina
	IEnumerator SheduleCookieDestroy () {
		yield return new WaitForSeconds(3.0f);
		Destroy (ActiveSuperCookie);
	}
}
