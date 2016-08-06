using UnityEngine;
using System.Collections;

public class PlayerPath : MonoBehaviour {

	public GameObject[] paths = new GameObject[3];

	public int currentPath;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < paths.Length; i++){
			if(i == 0){
				paths [i] = GameObject.Find ("LeftPath");
			}
			if (i == 1) {
				paths [i] = GameObject.Find ("MidPath");
			}
			if (i == 2) {
				paths [i] = GameObject.Find ("RightPath");
			}
			}
		}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (paths [currentPath].transform.position.x, paths [currentPath].transform.position.y, paths [currentPath].transform.position.z);
		if (Input.GetKeyUp (KeyCode.A)) {
			currentPath--;
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			currentPath++;
		}
		if (currentPath == -1) {
			currentPath = 0;
		}
		if (currentPath == 3) {
			currentPath = 2;
		}
	}
}
