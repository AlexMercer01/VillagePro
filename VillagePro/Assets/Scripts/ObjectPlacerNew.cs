using UnityEngine;
using System.Collections;

public class ObjectPlacerNew : MonoBehaviour
{
	Camera myCamera;
	public GameObject placeableObject;
	private Transform marker;

	void Start ()
	{
		myCamera = GetComponent<Camera> ();
        if (myCamera == null)
        {
            myCamera = Camera.main;
        }
	}

	void Update ()
	{
		if (placeableObject != null) {
			RaycastHit hit;
			Ray myRay = myCamera.ScreenPointToRay (Input.mousePosition);
			bool isRayTouched = Physics.Raycast (myRay, out hit);
			if (isRayTouched) {
				marker.position = hit.point;
			} else {
				marker.position = new Vector3(100000f,100000f,100000f);
			}
			if (Input.GetMouseButtonDown (0)) {
				if (isRayTouched) {
					Instantiate (placeableObject, hit.point, Quaternion.identity);
					placeableObject = null;
					Destroy(marker.gameObject);
				}
			}
		}
	}

	public void SetPlaceableObject (GameObject newPlaceableObject)
	{
		placeableObject = newPlaceableObject;
		marker = (Instantiate(placeableObject) as GameObject).transform;
	}
}
