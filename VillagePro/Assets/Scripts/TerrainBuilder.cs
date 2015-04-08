using UnityEngine;
using System.Collections;

public class TerrainBuilder : MonoBehaviour
{

	public Terrain terrain;
	public Texture2D map;
	public int resolution;
	public int compression=1;

	// Use this for initialization
	void Start ()
	{
		terrain = GetComponent<Terrain> ();

		float [,] terHeights = new float[resolution, resolution];

		for (int i =0; i<resolution; i++) {
			for (int j = 0; j<resolution; j++) {
			terHeights [i, j] = map.GetPixel(i,j).grayscale;
				terHeights [i, j]/=compression;
			}
		}
		terrain.terrainData.heightmapResolution = resolution;
		terrain.terrainData.SetHeights (0, 0, terHeights);

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
