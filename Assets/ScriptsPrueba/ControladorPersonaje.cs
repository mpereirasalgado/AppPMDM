using UnityEngine;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {

	public bool enSuelo = true;
	public Transform comprobadorSuelo;
	float comprobadorRadio = 0.05f;
	public LayerMask mascaraSUelo;
	private bool dobleSalto = false;

	public float velocidad = 0f;

	private float mover = 0f;

	public float alturaSalto;


	void Update(){

		enSuelo = Physics2D.OverlapCircle (comprobadorSuelo.position, comprobadorRadio, mascaraSUelo);
		if (enSuelo) {
			dobleSalto = false;
		}
		mover = Input.GetAxis ("Horizontal");
		NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeEmpiezaACorrer");
		GetComponent<Rigidbody2D>().velocity = new Vector2(mover * velocidad, GetComponent<Rigidbody2D>().velocity.y);
		if(Input.GetKeyDown(KeyCode.Space)){
			
			if (enSuelo || !dobleSalto) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, alturaSalto);
				if (!dobleSalto && !enSuelo) {
					dobleSalto = true;
				}
			}
		}
	}






}
