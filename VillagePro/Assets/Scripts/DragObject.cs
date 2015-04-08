using UnityEngine;
using System.Collections;

public class DragObject : MonoBehaviour {
	public Collider snapObject;
	public Camera myCamera;
	public Vector3 offset;
	GameObject terrain;


	public Camera MyCamera {
		get {
			if (myCamera == null) {
				myCamera = Camera.main;
			}
			return myCamera;
		}
	}

	// Use this for initialization
	void Start () {
		terrain = GameObject.FindGameObjectWithTag ("Terrain");
		snapObject = terrain.GetComponent <TerrainCollider> ();
	}

	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetMouseButton (0)) {
			Ray myRay = MyCamera.ScreenPointToRay (Input.mousePosition);

			RaycastHit[] hits = Physics.RaycastAll
				(myRay);
			if (hits.Length > 0) {
				for (int i = 0; i < hits.Length; i++) {
					if (hits [i].collider == snapObject) {
						transform.position = hits [i].point + offset;
						break;
					}
				}
			}
		}
	}
}