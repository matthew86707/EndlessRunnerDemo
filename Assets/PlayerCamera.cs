using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
		}
	}
}
