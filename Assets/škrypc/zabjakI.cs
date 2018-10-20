using UnityEngine;
using System.Collections;

public class zabjakI : MonoBehaviour
{
	public Transform target;

	public float speed = 5;
	//public float directionChangeInterval = 1;


	CharacterController controller;
	float heading;
	Vector3 targetRotation;





	void Awake ()
	{
		//controller = GetComponent<CharacterController>();

	
	}



	void Update () 
	{
		transform.LookAt(target.transform.position);
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
	}
}


















