using UnityEngine;
using System.Collections;

public class CreateObjectScript : MonoBehaviour {

	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;
	public GameObject prefab4;
	// Use this for initialization
	void Start () {
	
	}
	GameObject instance;
	// Update is called once per frame
	void Update () {

	}
	public void CreateObject1 () {
			instance = Instantiate (prefab1, new Vector3 (0, 0.6f, 0), Quaternion.identity) as GameObject;
	}
	public void CreateObject2 () {
		instance = Instantiate (prefab2, new Vector3 (4, 0.6f, 0), Quaternion.identity) as GameObject;
	}
	public void CreateObject3 () {
		instance = Instantiate (prefab3, new Vector3 (7, 0.6f, 0), Quaternion.identity) as GameObject;
	}
	public void CreateObject4 () {
		instance = Instantiate (prefab4, new Vector3 (10, 0.6f, 0), Quaternion.identity) as GameObject;
	}
}

