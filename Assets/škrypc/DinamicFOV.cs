﻿using UnityEngine;
using System.Collections;
using System.Reflection;
public class DinamicFOV : MonoBehaviour
{
	public int zoomLevelSelected = 0;
	public float[] ZoomLevels = new float[] { 60, 40, 20 };




	void Update()
	{
		int zoomChange = + 0;
		if (Input.GetAxis("Mouse ScrollWheel") > 0) { zoomChange = +1;} // back


		else if (Input.GetAxis("Mouse ScrollWheel") < 0) { zoomChange = -1; } // forward
		if (zoomChange !=  0)
		{
			zoomLevelSelected = Mathf.Clamp(zoomLevelSelected + zoomChange, 0, ZoomLevels.Length - 1);
			GetComponent<Camera>().fieldOfView = ZoomLevels[zoomLevelSelected];


		}
	}


}