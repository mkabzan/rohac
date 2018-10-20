using UnityEngine;
using System.Collections;

public class FooI : MonoBehaviour {

	public GameObject prefab;
	public    float    populationRate    = 1.0f;

	// Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane 
	void Start() {
		StartCoroutine(Dylej());
	}

	IEnumerator Example() {
		yield return new WaitForFixedUpdate();
	}



	IEnumerator Dylej()
	{
		while (enabled)
		{
			yield return new WaitForSeconds (populationRate);
			//Debug.Log ("Waited for " + populationRate + " seconds, and it's now " + Time.time);
			Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 0, Random.Range(-10.0F, 10.0F));
			Instantiate(prefab, position, Quaternion.identity);
		}
	}


	

}
