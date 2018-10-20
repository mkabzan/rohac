using UnityEngine;
using System.Collections;

public class rayCharlesScripl : MonoBehaviour {



	void Update() 
	{

		if ( Input.GetMouseButtonDown (0)){ 
			RaycastHit hit; 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
			if ( Physics.Raycast (ray,out hit,100.0f)) {
				//StartCoroutine(ScaleMe(hit.transform));
				Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
			}
		}


	//IENumerable ScaleMe(Transform objTr) {
	//	objTr.localScale *= 1.2f;
	//	yield return new WaitForSeconds(0.5f);
	//	objTr.localScale /= 1.2f;
	//}


	}
}
