using UnityEngine;
using System.Collections;

public class MouseEnter : MonoBehaviour {

	public Color mouseOverColor=Color.blue;
	Color originalColor;

	void Start (){
		originalColor = GetComponent <Renderer> ().sharedMaterial.color;
	}
	void OnMouseEnter (){
		GetComponent <Renderer> ().material.color = mouseOverColor;
	}
	void OnMouseExit (){
		GetComponent <DragObject> ().enabled = false;
		GetComponent <Renderer> ().material.color = originalColor;
	}
	void OnMouseDown (){
		GetComponent <DragObject> ().enabled = true;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
