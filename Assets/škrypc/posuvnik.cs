using UnityEngine;
using System.Collections;

public class posuvnik : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//void Update () {
	//	transform.position = new Vector3(Random.Range(-6, 6),Random.Range(1, 1), Random.Range(1, 1));
	//}

	private bool dirRight = true;
	public float speed = 2.0f;
	public float position_right = 4.0f;
	public float position_left = -4.0f;

	void Update () {
		if (dirRight)
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		else
			transform.Translate (-Vector2.right * speed * Time.deltaTime);

		if(transform.position.x >= position_right) {
			dirRight = false;
		}

		if(transform.position.x <= position_left) {
			dirRight = true;
		}
	}
}
