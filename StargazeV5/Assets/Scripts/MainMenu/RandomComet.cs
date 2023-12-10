using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomComet : MonoBehaviour
{
    public GameObject comet;
    private float min = -9;
    private float max = 9;
    private void Update() {
        int cometRand = Random.Range(1, 5000);
        if(cometRand == 25){
            int spawn = Random.Range(1, 50);
            Comet();
        }
    }

    private void Comet(){
        for (int i=0; i<100; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject starCopy3 = Instantiate(comet, new Vector3(dx, dz, 0), Quaternion.identity);
        }
    }

    private void MoceComet3(){
        int rand = Random.Range(1, 13);
        if(rand % 6 == 0){
            transform.position -= new Vector3(0.02f, 0.001f, 0);
        }
        else if(rand % 6 == 1){
            transform.position += new Vector3(0.01f, 0.05f, 0);
        }
        else if(rand % 6 == 2){
            transform.position -= new Vector3(0.02f, 0.04f, 0);
        }
        else if(rand % 6 == 3){
            transform.position += new Vector3(0.04f, 0.03f, 0);
        }
        else if(rand % 6 == 4){
            transform.position -= new Vector3(0.006f, 0.01f, 0);
        }
        else if(rand % 6 == 5){
            transform.position += new Vector3(0.08f, 0.003f, 0);
        }

    }
}
