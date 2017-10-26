using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	
	void OnCollisionEnter(Collision other){
			Destroy (gameObject);
	}
	// Update is called once per frame
	void Update () {
	
	}
}