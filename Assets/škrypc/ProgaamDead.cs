using UnityEngine;
using System.Collections;

public class ProgaamDead : MonoBehaviour {

	public int countCollisions = 0;

	void OnCollisionEnter(Collision hit)
	{
		if (hit.gameObject.name == "Cube" )
			countCollisions++;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
