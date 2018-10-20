using UnityEngine;
using System.Collections;

public class Pysmo : MonoBehaviour {
	public int count = 7000;
	//public Vector3 direction = Vector3.up;

	//public class ColorPointTester : MonoBehaviour {

	

		//public Vector3 vector;

		public Vector3 vectors;
	//}

	void Update() 
	{
		// Rotate the object around its local Y axis at 1 degree per second
		transform.Rotate(vectors * Time.deltaTime * count * Time.deltaTime );

		// ...also rotate around the World's Y axis
		// transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}




}
