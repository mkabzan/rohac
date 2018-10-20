using UnityEngine;
using System.Collections;

public class rotor : MonoBehaviour {
	void Example() {
		transform.position += Vector3.up * Time.deltaTime;
	}
}