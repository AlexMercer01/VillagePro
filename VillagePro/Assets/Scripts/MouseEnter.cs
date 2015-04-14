using UnityEngine;
using System.Collections;

public class MouseEnter : MonoBehaviour {

	void Start (){
	}
	void OnMouseExit (){
		GetComponent <DragObject> ().enabled = false;
	}
	void OnMouseDown (){
		GetComponent <DragObject> ().enabled = true;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
