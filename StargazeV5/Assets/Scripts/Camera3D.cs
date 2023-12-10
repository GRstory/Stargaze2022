using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3D : MonoBehaviour
{
    public GameObject camera;
    float speed = 120f;
    private float xRotate, yRotate, xRotateMove, yRotateMove; 
    public float rotateSpeed = 400.0f;
    private void Update() {
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        if(Input.GetMouseButton(0)) // 클릭한 경우
        {
            xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
            yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

            yRotate = transform.eulerAngles.y + yRotateMove;
            //xRotate = transform.eulerAngles.x + xRotateMove; 
            xRotate = xRotate + xRotateMove;
            
            xRotate = Mathf.Clamp(xRotate, -90, 90); // 위, 아래 고정
            
            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        }

        float cx = camera.transform.position.x;
        float cy = camera.transform.position.y;
        float cz = camera.transform.position.z;

        if(camera.transform.position.y <= 7.0f) camera.transform.position = new Vector3(cx, 7.0f, cz);
        if(camera.transform.position.y >= 50) camera.transform.position = new Vector3(cx, 50, cz);
        if(camera.transform.position.x <= -120) camera.transform.position = new Vector3(-120, cy, cz);
        if(camera.transform.position.x >= 120) camera.transform.position = new Vector3(120, cy, cz);
        if(camera.transform.position.z <= -120) camera.transform.position = new Vector3(cx, cy, -120);
        if(camera.transform.position.z >= 120) camera.transform.position = new Vector3(cx, cy, 120);
    }
}
