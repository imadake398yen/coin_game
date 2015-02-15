using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	AudioSource audio;
	public Text coinLabel;
	int coins;

	void Start () {
		audio = GetComponent<AudioSource>();
	}

	void Update () {
		if (coinLabel != null)
			coinLabel.text = "Coins : " + coins.ToString();
		else if (coinLabel == null)
			return;
	}

	void OnControllerColliderHit (ControllerColliderHit hit) {
		if (hit.gameObject.tag == "Item") {
			audio.Play();
			coins++;
			Destroy(hit.gameObject);
		}
	}

}
