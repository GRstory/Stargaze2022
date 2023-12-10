using UnityEngine;
using TMPro;

public class TechNotice : MonoBehaviour
{
    public TextMeshProUGUI nowTech;
    public GameObject notice;

    void Update()
    {
        if(nowTech.text == "100.0%"){
            notice.SetActive(false);
            Invoke("NoticeON", 1);
        }
        else notice.SetActive(false);
    }

    private void NoticeOff(){
        notice.SetActive(false);
    }
    private void NoticeON(){
        notice.SetActive(true);
    }
}
