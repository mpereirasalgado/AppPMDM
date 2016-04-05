using UnityEngine;
using System.Collections;

public class ActivarGameOver : MonoBehaviour {

	public GameObject camaraGameOver; 

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "GameOver");
	}

	void GameOver (Notification notificacion){
		camaraGameOver.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
