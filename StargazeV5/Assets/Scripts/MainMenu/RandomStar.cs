using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStar : MonoBehaviour
{
    private float min = -9;
    private float max = 9;
    private float minY = -30;
    private float maxY = 30;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star1Parent;
    public GameObject star2Parent;
    public GameObject star3Parent;
    private Vector3 starLimit = new Vector3(0, -40, 0);
    private Vector3 starReset = new Vector3(0, 40, 0);

    private void Start() {
        Star1();
        Star2();
        Star3();
    }
    private void Update() {
        MoveStar1();
        MoveStar2();
        MoveStar3();
    }
    private void Star1(){
        for (int i=0; i<50; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(minY, maxY);
            GameObject starCopy1 = Instantiate(star1, new Vector3(dx, dz, 0), Quaternion.identity);
            starCopy1.transform.parent = star1Parent.transform;
        }
    }
    private void Star2(){
        for (int i=0; i<50; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(minY, maxY);
            GameObject starCopy2 = Instantiate(star2, new Vector3(dx, dz, 0), Quaternion.identity);
            starCopy2.transform.parent = star2Parent.transform;
        }
    }
    private void Star3(){
        for (int i=0; i<100; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(minY, maxY);
            GameObject starCopy3 = Instantiate(star3, new Vector3(dx, dz, 0), Quaternion.identity);
            starCopy3.transform.parent = star3Parent.transform;
        }
    }


    private void MoveStar1(){
        star1Parent.transform.position -= new Vector3(0, 0.004f, 0);
        if(star1Parent.transform.position.y < starLimit.y) star1Parent.transform.position = starReset;
    }
    private void MoveStar2(){
        star2Parent.transform.position -= new Vector3(0, 0.0025f, 0);
        if(star2Parent.transform.position.y < starLimit.y) star2Parent.transform.position = starReset;
    }
    private void MoveStar3(){
        star3Parent.transform.position -= new Vector3(0, 0.001f, 0);
        if(star3Parent.transform.position.y < starLimit.y) star3Parent.transform.position = starReset;
    }

}
