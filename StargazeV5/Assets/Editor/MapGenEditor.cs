using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof (MapGen))]
public class MapGeneratorEditor : Editor {

	public override void OnInspectorGUI() {
		MapGen mapGen = (MapGen)target;

		if (DrawDefaultInspector ()) {
			if (mapGen.autoUpdate) {
				mapGen.GenerateMap ();
			}
		}

		if (GUILayout.Button ("맵 생성")) {
			mapGen.GenerateMap ();
		}
	}
}