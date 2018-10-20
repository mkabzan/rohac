using UnityEngine;
using System.Collections;

public class renderQueScript : MonoBehaviour {



		public int renderQueuePosition = 1;

		void Start(){
			GetComponent<Renderer>().material.renderQueue = renderQueuePosition;
		}

}
