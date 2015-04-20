using UnityEngine;
using System.Collections;

public class GrassScript : MonoBehaviour {
    
    public Texture2D grass;
    public Terrain terrain;

    void OnMouseDown()
    {
        terrain.GetComponent<Texture2D>();
    }
    
}
