using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public GameObject button1;
	public GameObject button2;
	public GameObject button3;
	public GameObject button4;
	public GameObject button5;
    public GameObject anotherButton1;
    public GameObject anotherButton2;
    public GameObject anotherButton3;
    public GameObject anotherButton4;
    public GameObject anotherButton5;
    public GameObject aButton1;
    public GameObject aButton2;
    public GameObject aButton3;
    public GameObject aButton4;
    public GameObject aButton5;

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
            anotherButton1.gameObject.SetActive(false);
            anotherButton2.gameObject.SetActive(false);
            anotherButton3.gameObject.SetActive(false);
            anotherButton4.gameObject.SetActive(false);
            anotherButton5.gameObject.SetActive(false);
            aButton1.gameObject.SetActive(false);
            aButton2.gameObject.SetActive(false);
            aButton3.gameObject.SetActive(false);
            aButton4.gameObject.SetActive(false);
            aButton5.gameObject.SetActive(false);

     
			
		}
}
