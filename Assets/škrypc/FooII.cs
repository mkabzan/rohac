using UnityEngine;
using System.Collections;

public class FooII : MonoBehaviour 
{

	public float delay;
	public GameObject thingy;

	void Start () 
	{
		InvokeRepeating("Spawn", delay, delay);
	}

	void Spawn () 
	{
		GameObject thingy_clone = Instantiate(thingy, new Vector3(Random.Range(-6, 6),Random.Range(-6, 6), Random.Range(-6, 6)), Quaternion.identity) as GameObject;
		Vector3 scale = thingy_clone.transform.localScale;
		scale.x = Random.Range (1, 14);
		thingy_clone.transform.localScale = scale;
	}
}