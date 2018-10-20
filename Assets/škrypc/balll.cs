using UnityEngine;
using System.Collections;

public class balll : MonoBehaviour {

	public Rigidbody rocketPrefab;
	public Transform barrelEnd;
	public Transform barrelEndParticle;
	public float delay;
	public float timeStamp,timeStamp2;
	//private float timeStamp2;
	public Material MouseEnterMaterial;
	// public Material MouseOverMaterial;
	public Material MouseExitMaterial;
	public Material MouseDownMaterial;
	public Material DelayEnabledMaterial;

	public Renderer rend;
	public Renderer rend2;


	void Update () {
		if (timeStamp2 <= Time.time)




		{
			rend.material = DelayEnabledMaterial;
			rend2.material = DelayEnabledMaterial;
			timeStamp2  = Time.time + delay;

		}
	}	

	void OnMouseExit() {
		//rend.material.color = Color.white;
		rend.material = MouseExitMaterial;
		rend2.material = MouseExitMaterial;
	}

	void OnMouseEnter() {
		//rend.material.color = Color.red;
		rend.material = MouseEnterMaterial;
		rend2.material = MouseEnterMaterial; 
	}

	void OnMouseDown() {
	if (timeStamp <= Time.time)
		{
			rend.material = MouseDownMaterial;
			rend2.material = MouseDownMaterial;
			timeStamp = timeStamp2 = Time.time + delay ;
			Rigidbody rocketInstance;
			rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
			rocketInstance.AddForce(barrelEnd.forward * 40, ForceMode.Impulse);
			Instantiate(barrelEndParticle, barrelEnd.position, barrelEnd.rotation);
		} 
	}


	
}