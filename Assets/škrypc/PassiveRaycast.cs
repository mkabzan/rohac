using UnityEngine;
using System.Collections;
using System.Reflection;


public sealed class PassiveRaycast : MonoBehaviour
	{


	void Start () {
		
	
	}

	void Update() {
		RaycastHit hit;
		var fwd = transform.TransformDirection (Vector3.forward);
		Debug.DrawRay(transform.position, transform.forward , Color.cyan);
		if (Physics.Raycast (transform.position, transform.forward, out hit)) 
		{ 
			
			//print (hit.distance);


		}






	
	}
}
