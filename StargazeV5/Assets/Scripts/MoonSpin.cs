using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MoonSpin : MonoBehaviour {
    public float speed;
    public Transform target;
 
    void Update () {
        // 버전 1 (지구와 달에붙임) -> 잘못된 결과가 나온다. (지구의 움직임을 달이 고려하지 않기 때문)
        //transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);
        // 버전 2 (태양과 지구에 붙인 후 부모 자식 설정함) -> 결과는 잘나옴
        transform.Rotate(0, speed*Time.deltaTime, 0);
        
    }
}