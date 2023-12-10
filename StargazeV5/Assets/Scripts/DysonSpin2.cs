using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DysonSpin2 : MonoBehaviour
{
    public GameObject planet;
    public float speed;
    void Update()
    {
        Spin();
    }

    void Spin()
    {
        transform.RotateAround(planet.transform.position, Vector3.right, speed*Time.deltaTime);
    }
}
