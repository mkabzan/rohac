using UnityEngine;


using UnityEngine;

public class RomDon2 : MonoBehaviour 
{
	public float thrust;
	public Rigidbody rb;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() 
	{
		
		//rb.AddForce(Random.value, Random.value, Random.value, ForceMode.Impulse);
		// Sets the position to be somewhere inside a circle
		// with radius 5 and the center at zero. Note that
		// assigning a Vector2 to a Vector3 is fine - it will
		// just set the X and Y values.
		//transform.position = Random.insideUnitCircle * 1;
	}


}