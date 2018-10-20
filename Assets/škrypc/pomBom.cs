using UnityEngine;
using System.Collections;

public class pomBom : MonoBehaviour {
	public float candomMax = 10 ;
	public float candomMin = -10 ;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		//transform.Rotate (Vector3(100 * Time.deltaTime, candom * Time.deltaTime, candom * Time.deltaTime)));
		//transform.Rotate (Vector3.right * ( Random.Range(candomMax,candomMin) * candomMax * Time.deltaTime));
		transform.Rotate (Vector3.right * ( Random.Range(candomMax,candomMin) * candomMax * Time.deltaTime * 0.001F ));
		transform.Rotate (Vector3.up * ( Random.Range(candomMax,candomMin) * candomMax * Time.deltaTime * 0.001F ));
		transform.Rotate (Vector3.back * ( Random.Range(candomMax,candomMin) * candomMax * Time.deltaTime * 0.001F ));
	}
}
