using UnityEngine;

public class CameraSet : MonoBehaviour
{
    public GameObject camera2D;
    public GameObject camera3D;
    public bool cameraMode; //true: 2D, false: 3D
    private void Update() {
        if(Input.GetKeyDown(KeyCode.V)){ // 시점변경 실행
			cameraMode = !cameraMode;
            if(cameraMode){
                camera3D.SetActive(false);
                camera2D.SetActive(true);
            }
            else{
                camera3D.SetActive(true);
                camera2D.SetActive(false);
            }
        }
    }
}
