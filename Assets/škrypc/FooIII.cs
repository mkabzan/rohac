using UnityEngine;
using System.Collections;

public class FooIII : MonoBehaviour {
	private Transform target;
	//private GameObject[] target;
	public float speed;
	void Update() {
		target = GameObject.Find("Jadlo").transform;
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}