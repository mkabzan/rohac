using UnityEngine;
using System.Collections;

public class RandomEnemySpawner : MonoBehaviour {
	public GameObject KatzbalgerEnemySpawn;
	public float minWaitTime = 1.0f;
	public float maxWaitTime = 10.0f;
	// Use this for initialization
	//private float ShorterdelayOverTimeMin;
	//private float ShorterdelayOverTimeMax;


	public float InitialTime = 1f;
	public float timer = 8f;
	public float timingModifier = 1.1f;

	/// somewhere, in an Update loop in a script far away...


	void Start () 
	{
	timer -= Time.deltaTime;

	if (timer < 0)
	{
		timer = (InitialTime / timingModifier);
		timingModifier += timingModifier;

	}

	}


	 void Awake()
	{
		StartCoroutine("homos");
	}

	IEnumerator homos()
	{
		while(true)
		{
			print ("FasterSpawnVer "+ timer + "sec");
			//yield return new WaitForSeconds(5);
			//Debug.Log("Sending");
			//yield return new WaitForSeconds(Random.Range(0.0F, 10.0F));
			//Debug.Log("hovénko");
			Instantiate(KatzbalgerEnemySpawn, transform.position, transform.rotation);
			yield return new WaitForSeconds(Random.Range(timer/minWaitTime, timer/maxWaitTime));
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
	



