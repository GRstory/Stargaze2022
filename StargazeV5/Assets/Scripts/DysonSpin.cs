using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DysonSpin : MonoBehaviour
{
    public float speed = 200;
    private void Update() {
        transform.Rotate(Vector3.forward* Time.deltaTime * speed);
    }
}
