using UnityEngine;
using System.Collections;

public class dieEnemy : MonoBehaviour {
	public int scoreValue;
	public Animator animator;
	public GameObject Childo;
	bool killa = false;

	private GameController gameController;
	void OnTriggerEnter (Collider other){

		if(other.gameObject.tag == "PlayerWeaponTag"){
			killa = true;
		}
	}

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("MainCamera");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void Update () {
		if(killa){
	     	Debug.Log("Kill Hrace");
			animator.SetTrigger("death");
			animator.SetBool("died", true);
			//Childo.gameObject.tag = "Diede"; 
			GetComponent<dieEnemy>().enabled = (false);
			this.GetComponent<CapsuleCollider>().isTrigger = (true);
			this.GetComponent<BoxCollider>().enabled = (true);
			GetComponent<zabijecik>().enabled = (true);
			gameController.AddScore (scoreValue);
		}

	}

}