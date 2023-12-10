using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoticeRocket : MonoBehaviour
{
    public GameObject notice;
    void Start()
    {
        Invoke("noticeOff", 0.2f);
        Invoke("noticeOn", 0.4f);
        Invoke("noticeOff", 0.6f);
        Invoke("noticeOn", 0.8f);
        Invoke("noticeOff", 1.0f);
        Invoke("noticeOn", 1.2f);
        Invoke("noticeOff", 1.4f);

    }
    private void noticeOn(){
        notice.SetActive(true);
    }
    private void noticeOff(){
        notice.SetActive(false);
    }
}
