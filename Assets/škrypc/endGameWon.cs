using UnityEngine;
using System.Collections;

public class endGameWon : MonoBehaviour {

	bool updatos = false;
	bool gonk = false;
	public GameObject Pysimko;



	void OnTriggerEnter (Collider other){

		if(other.gameObject.tag == "Player"){
			gonk = true;
			Pysimko.SetActive(true);
			//Debug.Log("EnamaKolize");
		}
	}

	void Update () {
		if(gonk){
			Debug.Log("EndZoneCount");
			//yield WaitForSeconds(5.0);  // or however long you want it to wait

			StartCoroutine("homos2");
			//Childo.gameObject.tag = "Diede"; 
			//GetComponent<dieEnemy>().enabled = (false);
			//this.GetComponent<CapsuleCollider>().isTrigger = (true);

		}

	}

	IEnumerator homos2()
	{
		Debug.Log("HomošCouroutine");
		//if(tojm) {
		yield return new WaitForSeconds(5);

		Application.LoadLevel(Application.loadedLevel);

		//}
	}
}
