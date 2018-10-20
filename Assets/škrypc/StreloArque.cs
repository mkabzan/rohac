using UnityEngine;
using System.Collections;

public class StreloArque : MonoBehaviour {

	public Animator animator;
	public Rigidbody rocketPrefab;
	public Transform barrelEnd;
	public Transform barrelEndParticle;
	public float barrelEnd4ce = 10.00f ;
	public float delay;
	public float RandomRangeMin = 1.00f;
	public float RandomRangeMax = 1.10f;
	public float timeStamp,timeStamp2;
	//private float timeStamp2;
	public Material MouseEnterMaterial;
	// public Material MouseOverMaterial;
	public Material MouseExitMaterial;
	public Material MouseDownMaterial;
	public Material DelayEnabledMaterial;

	public Renderer rend;
	public Renderer rend2;

	public GameObject Childo;

	void Update () {
		if (timeStamp2 <= Time.time)




		{
			rend.material = DelayEnabledMaterial;
			rend2.material = DelayEnabledMaterial;
			timeStamp2  = Time.time + delay;
			Childo.GetComponent<DeloGeloRotator>().enabled = (false);
		}
	}	

	//void OnMouseExit() {
	//rend.material.color = Color.white;
	//	rend.material = MouseExitMaterial;
	//	rend2.material = MouseExitMaterial;
	//}

	//void OnMouseEnter() {
	//rend.material.color = Color.red;
	//	rend.material = MouseEnterMaterial;
	//	rend2.material = MouseEnterMaterial; 
	//}

	void OnMouseDown() {
		if (timeStamp <= Time.time)
		{
			rend.material = MouseDownMaterial;
			rend2.material = MouseDownMaterial;
			timeStamp = timeStamp2 = Time.time + delay ;
			Rigidbody rocketInstance;
			rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
			rocketInstance.AddForce(barrelEnd.forward * barrelEnd4ce * Random.Range(RandomRangeMin, RandomRangeMax), ForceMode.Impulse);
			Instantiate(barrelEndParticle, barrelEnd.position, barrelEnd.rotation);
			animator.SetTrigger("strelmaster");
			//Childo.GetComponent<DeloGeloRotator>().enabled = (true);


			Childo.GetComponent<DeloGeloRotator>().enabled = (true);


		}



	}



}
