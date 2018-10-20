using UnityEngine;
using System.Collections;

public class RandomEnemySpawner2 : MonoBehaviour {
	public GameObject KatzbalgerEnemySpawn;
	public int minWaitTime = 1;
	public int maxWaitTime = 10;
	// Use this for initialization

	void Start () 
	{

	}

	void Awake()
	{
		StartCoroutine("homos");
	}

	IEnumerator homos()
	{
		while(true)
		{
			yield return new WaitForSeconds(5);
			//Debug.Log("Sending");
			yield return new WaitForSeconds(Random.Range(0.0F, 10.0F));
			//Debug.Log("hovénko");
			Instantiate(KatzbalgerEnemySpawn, transform.position, transform.rotation);
			yield return new WaitForSeconds(Random.Range(0.0F, 10.0F));
			//Debug.Log("okénko");
			//Instantiate(KatzbalgerEnemySpawn, transform.position, Quaternion.identity);
			//Debug.Log ("OnCoroutine: "+(int)Time.time);
		}
	}

	//IEnumerator waiter()
	//{
	//	int wait_time = Random.Range (minWaitTime, maxWaitTime);
	//	yield return new WaitForSeconds (wait_time);
	//	print ("I waited for "+ wait_time + "sec");
	//	Instantiate(KatzbalgerEnemySpawn, transform.position, Quaternion.identity);




}


// Update is called once per frame
//void Update () {
//StartCoroutine (waiter());
//Instantiate(KatzbalgerEnemySpawn, transform.position, Quaternion.identity);
//while (true) {
//	WaitForSeconds (Random.Range(minWaitTime, maxWaitTime));
//	Instantiate(KatzbalgerEnemySpawn, transform.position, Quaternion.identity);
//}




