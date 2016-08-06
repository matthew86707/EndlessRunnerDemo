using UnityEngine;
using System.Collections;

public class NextLevelSegment : MonoBehaviour {

	public GameObject nextSeg;
	public GameObject pos;

	// Use this for initialization
	void Start () {
		pos = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter(Collider other) {
		if(other.transform.gameObject.tag == "PlayerCam"){

			nextSeg = (GameObject) GameObject.Instantiate (this.gameObject.transform.parent.gameObject);
			nextSeg.transform.Translate (-15.0f, 0.0f, 0.0f);
			int posNum = Random.Range (0, 3);
			nextSeg.transform.GetChild(2).transform.position = new Vector3 (pos.GetComponent<PlayerPath> ().paths [posNum].transform.position.x + -15.0f, nextSeg.transform.position.y + 0.3f, pos.GetComponent<PlayerPath> ().paths [posNum].transform.position.z);

	}
}
}