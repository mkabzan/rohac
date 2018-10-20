﻿using UnityEngine;
using System.Collections;

public class blazenicek : MonoBehaviour { 
	public int startSize = 3;
	public int minSize = 1;
	public int maxSize = 6;

	public float speed = 2.0f;

	private Vector3 targetScale;
	private Vector3 baseScale;
	private int currScale;

	void Start() {
		baseScale = transform.localScale;
		transform.localScale = baseScale * startSize;
		currScale = startSize;
		targetScale = baseScale * startSize;
	}

	void Update() {
		transform.localScale = Vector3.Lerp (transform.localScale, targetScale, speed * Time.deltaTime);

		// If you don't want an eased scaling, replace the above line with the following line
		//   and change speed to suit:
		// transform.localScale = Vector3.MoveTowards (transform.localScale, targetScale, speed * Time.deltaTime);

		targetScale = baseScale * Random.Range(minSize, maxSize);
	}

	//public void ChangeSize(bool bigger) {

	//	if (bigger)
	//		currScale++;
	//	else
	//		currScale--;

	//	currScale = Mathf.Clamp (currScale, minSize, maxSize+1);

	//	targetScale = baseScale * currScale;
	//}    
}