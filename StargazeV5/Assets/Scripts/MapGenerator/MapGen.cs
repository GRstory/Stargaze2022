using UnityEngine;
using System.Collections;

public class MapGen : MonoBehaviour {
	public enum DrawMode {NoiseMap, ColorMap};
	public DrawMode drawMode;
	public int mapWidth;
	public int mapHeight;
	public float noiseScale;

	public int octaves;
	[Range(0,1)]
	public float persistance;
	public float lacunarity;

	public int seed;
	public Vector2 offset;

	public bool autoUpdate;

	public TerrainType[] regions;

	private void Start() {
		seed = GameManager.instance.GameSeed1;
		offset.x = GameManager.instance.GameOffetX;
		offset.y = GameManager.instance.GameOffetY;

		GenerateMap ();
	}

	public void GenerateMap() {
		float[,] noiseMap = Noise.GenerateNoiseMap (mapWidth, mapHeight, seed, noiseScale, octaves, persistance, lacunarity, offset);
		Color[] colorMap = new Color[mapHeight * mapWidth];

		for(int y = 0; y < mapHeight; y++){
			for(int x = 0; x < mapWidth; x++){
				float currentHeight = noiseMap[x, y];
				for (int z = 0; z < regions.Length; z++){
					if(currentHeight <= regions[z].height){
						colorMap[y * mapWidth + x] = regions[z].color;
						break;
					}
				}
			}
		}

		MapDisplay display = FindObjectOfType<MapDisplay> ();

		if(drawMode== DrawMode.NoiseMap){
			display.DrawTexture (TextureGen.TextureFromHeightMap(noiseMap));
		}
		else if (drawMode == DrawMode.ColorMap){
			display.DrawTexture (TextureGen.TextureFromColorMap(colorMap, mapWidth, mapHeight));
		}
	}

	void OnValidate() {
		if (mapWidth < 1) {
			mapWidth = 1;
		}
		if (mapHeight < 1) {
			mapHeight = 1;
		}
		if (lacunarity < 1) {
			lacunarity = 1;
		}
		if (octaves < 0) {
			octaves = 0;
		}
	}

}

[System.Serializable]
public struct TerrainType{
	public float height;
	public Color color;
	//public string name;
}