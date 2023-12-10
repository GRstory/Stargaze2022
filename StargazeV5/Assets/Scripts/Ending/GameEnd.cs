using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public void MainMenuExit(){
        Debug.Log("게임 종료");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
