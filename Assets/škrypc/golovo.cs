using UnityEngine;
using System.Collections;

public class golovo : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}



	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;
	void Update() {
		Vector3 targetPosition = new Vector3(Random.Range(-10.0F, 10.0F), Random.Range(0.0F, 2.0F), Random.Range(-10.0F, 10.0F));
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
	}


}
