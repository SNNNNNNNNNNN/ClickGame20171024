using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
	public void Shoot(Vector3 dir){
		GetComponent<Rigidbody> ().AddForce (dir);
	}
	// Use this for initialization
	void Start () {
		//Shoot (new Vector3 (-1000, 0, 0));
	}
	void OnCollisionEnter(Collision other){
		if (other.collider.tag == "Game") {
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
