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
			instance = Instantiate (prefab1, prefab1.transform.position, prefab1.transform.rotation) as GameObject;
	}
	public void CreateObject2 () {
        instance = Instantiate(prefab2, prefab2.transform.position, prefab2.transform.rotation) as GameObject;
	}
	public void CreateObject3 () {
        instance = Instantiate(prefab3, prefab3.transform.position, prefab3.transform.rotation) as GameObject;
	}
	public void CreateObject4 () {
        instance = Instantiate(prefab4, prefab4.transform.position, prefab4.transform.rotation) as GameObject;
	}
}

