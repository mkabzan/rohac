using UnityEngine;
using System.Collections;

public class sceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.GetStreamProgressForLevel("scriptingHokus") ==1){
			
			StartCoroutine("Homogej");
		}
	}


	IEnumerator Homogej()
	{
		Debug.Log("HomogejCoroutine started");
		//if(tojm) {
		yield return new WaitForSeconds(6);

		//Application.LoadLevel(Application.loadedLevel);
		Application.LoadLevel("scriptingHokus");
		//}
	}
}
