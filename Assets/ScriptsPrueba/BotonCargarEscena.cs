using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BotonCargarEscena : MonoBehaviour {

	public string nombreDeEscenaParaCargar = "2";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		SceneManager.LoadScene (nombreDeEscenaParaCargar);
	}
}
