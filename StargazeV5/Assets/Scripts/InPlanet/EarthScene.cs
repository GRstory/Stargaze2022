using UnityEngine;
using UnityEngine.SceneManagement;

public class EarthScene : MonoBehaviour
{
    void OnMouseDown() {
        SceneManager.LoadScene("EarthScene");
    }
}
