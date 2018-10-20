using UnityEngine;
using System.Collections;

public class destroyTime : MonoBehaviour

{
	public float DieOffTime = 6.00f;

	void Awake()
	{

		Destroy (gameObject, DieOffTime);
	}
}