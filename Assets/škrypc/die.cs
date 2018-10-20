using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {
	//public Renderer rend;
	public Animator animator;
	public GameObject Childo;
	//public Transform chill;
	//public Component[] triggerik;
	//bool Diedo = false;
	//public GameObject Diedo;
	//public GameObject flashing_Label;
	//private float timer;

	bool KolizeTag;


	void OnTriggerEnter (Collider other){
		
		if(other.gameObject.tag == "EnemyWeaponTag"){
			KolizeTag = true;
		   //rend = GetComponent<Renderer>();
		   //rend.enabled = true;
	       // StartCoroutine("DoBlinks(3f, 0.2f)");
		   
		}
	}



	void Update () {

		if(KolizeTag){
			// Do something

			//InvokeRepeating("DoFlicker", .1f, flickerRate);
			    //StartCoroutine("blinkous");
				//Debug.Log("Kill Enemaka");
				animator.SetTrigger("death");
				animator.SetBool("died", true);
				//this.GetComponent<MeshRenderer>().enabled = false; 
				//GetComponent<Animation>().Play("death");
				//other.gameObject.tag = null;

				Childo.gameObject.tag = "Diede"; 
				//print(other.gameObject.tag);
				//sDestroy (other.gameObject);
				//Destroy (other.gameObject);
				//Destroy(GetComponent(BoxCollider));
				//triggerik.enabled = !triggerik.enabled;
				//gameObject.SetActive(false);
				GetComponent<die>().enabled = (false);
			    GetComponent<zabijecik>().enabled = (true);
			    //GetComponent<CapsuleCollider>().enabled = (false);
		     	this.GetComponent<CapsuleCollider>().isTrigger = (true);
			    this.GetComponent<BoxCollider>().enabled = (true);



			}// else {animator.SetTrigger("normal");}

	
	}



	//void OnTriggerEnter(Collider other) {

		//public var destroyChildren = false;
		//if(Diedo == false) {
			//Instantiate(prefab);
		//	animator.SetBool("death2", true);
		//	Diedo = true;}
		//{ if (other.gameObject.tag=="EnemyTag") { other.gameObject.tag = "hummer"; print(other.gameObject.tag); } 


	//}




}