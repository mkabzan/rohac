using UnityEngine;
using System.Collections;

public class buttonspawner : MonoBehaviour {
	//public Material MouseEnterMaterial;
	//public Material MouseOverMaterial;
	//public Material MouseExitMaterial;
	//public Material MouseDownMaterial;

	public GameObject KatzbalgerSpawn;
    public Renderer rend;
	//public Renderer rend2;
	void Start() {


	}
	//void OnMouseEnter() {
		//rend.material.color = Color.red;
		//rend.material = MouseEnterMaterial;
		//	rend2.material = MouseEnterMaterial;
	//}
	//void OnMouseOver() {
	//rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
	//	rend.material = MouseOverMaterial;
	//}
	//void OnMouseExit() {
		//rend.material.color = Color.white;
		//rend.material = MouseExitMaterial;
		//	rend2.material = MouseExitMaterial;
	//}

	void OnMouseDown() {

		//Debug.Log("Spawned.");
		// Message using rich text.
		//Debug.Log("<color=red>KatzBalger1:</color> čum");
		Instantiate(KatzbalgerSpawn, transform.position, Quaternion.identity);
		//Application.LoadLevel("SomeLevel");
		//rend.material = MouseDownMaterial;
		//	rend2.material = MouseDownMaterial;

	}


}

