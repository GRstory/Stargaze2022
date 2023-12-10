using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchRocket : MonoBehaviour
{
    private Vector3 destination = new Vector3(0.0f, 0.0f, 200f);
    private void Update() {
        transform.position += new Vector3(0, 0, 0.05f);
    }
}