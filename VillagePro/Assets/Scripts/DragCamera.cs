using UnityEngine;
using System.Collections;

public class DragCamera : MonoBehaviour {
	public GameObject go;
	public float moveSpeed;
	public float upSpeed;
	public float sensetivity;
	float x, y;

	void Start (){
		x = transform.eulerAngles.x;
		y = transform.eulerAngles.y;
		if (GetComponent <Rigidbody>()) 
			GetComponent <Rigidbody> ().freezeRotation=true;
}
	// Update is called once per frame
	void FixedUpdate () {
		float MoveHorizontal = Input.GetAxis("Horizontal");
		float MoveVertical = Input.GetAxis("Vertical");
		go.transform.position = new Vector3 (go.transform.position.x + (MoveHorizontal * moveSpeed * Time.deltaTime), go.transform.position.y, go.transform.position.z + (MoveVertical * moveSpeed * Time.deltaTime));
		if (Input.GetKey ("space")) 
			go.transform.position= new Vector3 (go.transform.position.x, go.transform.position.y +( upSpeed*Time.deltaTime), go.transform.position.z);
		if (Input.GetKey ("left ctrl"))
			go.transform.position = new Vector3 (go.transform.position.x, go.transform.position.y - (upSpeed * Time.deltaTime), go.transform.position.z);
		if (Input.GetMouseButton (1)) {
			x+=Input.GetAxis ("Mouse X") *sensetivity;
			y-=Input.GetAxis ("Mouse Y") *sensetivity;
			transform.rotation=Quaternion.Euler (y, x, 0);
		}
	}
}
