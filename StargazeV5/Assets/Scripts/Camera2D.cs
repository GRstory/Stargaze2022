using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2D : MonoBehaviour
{
    public Camera camera2D;
    public GameObject camera2DMini;
    private float speed = 200f;
    public float distance = 10.0f;
    private bool admin = false;
    private bool techBool = false;
    private bool invBool = false;
    private bool viewBool = false;
    public GameObject techTreeUI;
    public GameObject inventoryUI;
    public GameObject btn_GotoSpace;
    public GameObject btn_UnlockPlanet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if(Input.GetKeyDown(KeyCode.Tab)){ // InventoryUI ON
            SetInvBool();
        }
        if(Input.GetKeyDown(KeyCode.T)){ // TechTreeUI ON
            SetTechBool();
        }
        if(Input.GetKeyDown(KeyCode.P)){ // 관리자모드 실행
            GetAdmin();
        }
		
        distance -= Input.GetAxis("Mouse ScrollWheel") * 10.0f;

        if(distance < 10.0f) distance = 10.0f;
        if(distance > 30.0f) distance = 30.0f;

        camera2D.orthographicSize = distance;
        camera2DMini.transform.position = camera2D.transform.position;
    }

    private void GetAdmin(){
        if (!admin){
            btn_GotoSpace.SetActive(true);
            btn_UnlockPlanet.SetActive(true);
        }
        
        else {
            btn_GotoSpace.SetActive(false);
            btn_UnlockPlanet.SetActive(false);
        }

        admin = !admin;
    }

    private void SetTechBool(){
        if (!techBool) techTreeUI.SetActive(true);
        else techTreeUI.SetActive(false);

        techBool = !techBool;
    }

    private void SetInvBool(){
        if (!invBool) inventoryUI.SetActive(true);
        else inventoryUI.SetActive(false);

        invBool = !invBool;
    }
}
