using UnityEngine;
using System.Collections;

public class TransparentBallGenerator : MonoBehaviour {
	public GameObject TransparentPre;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject ball = Instantiate (TransparentPre)as GameObject;

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Vector3 worlddir = ray.direction;
			ball.GetComponent<Click> ().Shoot (
				worlddir.normalized * 2000);
		}
	}
}
