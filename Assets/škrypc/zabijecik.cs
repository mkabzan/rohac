using UnityEngine;
using System.Collections;

public class zabijecik : MonoBehaviour {
	public int tojm = 4;
	public float flickerRate = 0.01f;
	public GameObject mesha;
    private int kong = 0;
	public int blikacka = 7;
	// Use this for initialization

	void Start () {
		
		StartCoroutine("homoFlicker");
	}




	void DoFlicker()
	{
		//int state = Random.Range(0, 2);

		if(kong == 0)
		{mesha.active=false;
			kong = 1;}
		else
		{mesha.active=true;
			kong = 0;}
	}


	// Update is called once per frame
	void Update () {
		Destroy (gameObject, tojm);
	}




	IEnumerator homoFlicker()
	{
		//Debug.Log("HomoFlickerCouroutine");
		//if(tojm) {
		yield return new WaitForSeconds(blikacka);

		InvokeRepeating("DoFlicker", .1f, flickerRate);

		//}
	}


}
