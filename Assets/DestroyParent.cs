using UnityEngine;
using System.Collections;

public class DestroyParent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Trigger");
	}

	void OnTriggerStay(Collider other) {
		if(other.transform.gameObject.tag == "PlayerCam"){
			Debug.Log ("Trigger");
			GameObject.Destroy (transform.parent.gameObject);
	}
}
}