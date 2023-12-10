using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTree : MonoBehaviour
{
    private float min = -100;
    private float max = 100;

    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;
    public GameObject tree1Parent;
    public GameObject tree2Parent;
    public GameObject tree3Parent;
    public GameObject tree4Parent;

    private void Start() {
        Tree1();
        Tree2();
        Tree3();
        Tree4();
    }
    private void Tree1(){
        for (int i=0; i<12; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject treeCopy1 = Instantiate(tree1, new Vector3(dx, 0, dz), Quaternion.identity);
            treeCopy1.transform.parent = tree1Parent.transform;
        }
    }
    private void Tree2(){
        for (int i=0; i<12; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject treeCopy2 = Instantiate(tree2, new Vector3(dx, 0, dz), Quaternion.identity);
            treeCopy2.transform.parent = tree2Parent.transform;
        }
    }
    private void Tree3(){
        for (int i=0; i<12; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject treeCopy3 = Instantiate(tree3, new Vector3(dx, 0, dz), Quaternion.identity);
            treeCopy3.transform.parent = tree3Parent.transform;
        }
    }
    private void Tree4(){
        for (int i=0; i<12; i++){
            float dx = Random.Range(min, max);
            float dz = Random.Range(min, max);
            GameObject treeCopy4 = Instantiate(tree4, new Vector3(dx, 0, dz), Quaternion.identity);
            treeCopy4.transform.parent = tree4Parent.transform;
        }
    }
}
