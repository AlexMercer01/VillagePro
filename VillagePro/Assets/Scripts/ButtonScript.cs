using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public GameObject button1;
	public GameObject button2;
	public GameObject button3;
	public GameObject button4;
	public GameObject button5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void OnMouseDown(){
			button1.gameObject.SetActive (true);
			button2.gameObject.SetActive (true);
			button3.gameObject.SetActive (true);
			button4.gameObject.SetActive (true);
			button5.gameObject.SetActive (true);
			
		}
}
