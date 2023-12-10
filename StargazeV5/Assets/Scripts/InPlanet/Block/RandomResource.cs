using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomResource : MonoBehaviour
{
    public GameObject rockIron;
    public GameObject rockCopper;
    public GameObject rockCoal;
    public GameObject rockTitanium;
    public GameObject rockOil;
    public GameObject rockUranium;
    private float min = -150.0f;
    private float max = 150.0f;

    private void Start() {
        for(int i = 0; i < 12; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject iron2 = Instantiate(rockIron, new Vector3(dx, 0, dz), Quaternion.identity);
        }
        for(int i = 0; i < 12; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject copper2 = Instantiate(rockCopper, new Vector3(dx, 0, dz), Quaternion.identity);
        }
        for(int i = 0; i < 8; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject coal2 = Instantiate(rockCoal, new Vector3(dx, 0, dz), Quaternion.identity);
        }
        for(int i = 0; i < 6; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject titanium2 = Instantiate(rockTitanium, new Vector3(dx, 0, dz), Quaternion.identity);
        }
        for(int i = 0; i < 3; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject oil2 = Instantiate(rockOil, new Vector3(dx, 0, dz), Quaternion.identity);
        }
        for(int i = 0; i < 3; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject uranium2 = Instantiate(rockUranium, new Vector3(dx, 0, dz), Quaternion.identity);
        }
    }
}