using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LaunchDyson : MonoBehaviour
{
    public GameObject Deny1;
    public GameObject Deny2;
    public GameObject rocket;
    public TextMeshProUGUI dysonText;
    public TextMeshProUGUI dysonPercentText;
    public GameObject backToSpace;
    public GameObject showStatus;
    public GameObject launchUI;
    public GameObject camera2D;
    Vector3 destination = new Vector3(0, 0, 300);
    private void Update() {
        if(GameManager.instance.dysonLaunch == GameManager.instance.dysonBaseData) Deny1.SetActive(false);
        else Deny1.SetActive(true);
        if(GameManager.instance.GameDysonStatus >= 100){
            Deny2.SetActive(true);
            backToSpace.SetActive(true);
            showStatus.SetActive(false);
        }


        dysonText.text = GameManager.instance.dysonLaunch.ToString();
        dysonPercentText.text = "다이슨 완성도: " + GameManager.instance.GameDysonStatus.ToString() + "%";
    }
    public void LaunchDysonParts(){
        if(GameManager.instance.GameDysonStatus >= 100){
            Deny2.SetActive(true);
            backToSpace.SetActive(true);
            showStatus.SetActive(false);
        }
        else{
            GameManager.instance.dysonLaunch -= GameManager.instance.dysonBaseData;
            GameManager.instance.GameDysonStatus += 2;

            GameObject rocketClone = Instantiate(rocket, new Vector3(0, 0, 0), Quaternion.identity);
            rocketClone.SetActive(true);

            launchUI.SetActive(false);
            camera2D.transform.position = new Vector3(0, 10, 0);
        }
    }

    public void MoveRocket(GameObject rocket){
        rocket.transform.position = Vector3.Lerp(transform.position, destination, 0.001f);
    }


}
