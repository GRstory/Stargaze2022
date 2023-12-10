using UnityEngine;

public class PrologueUI : MonoBehaviour
{
    //도움말, 목표 UI
    public GameObject btn01;
    public GameObject btn02;
    public GameObject btn03;
    public GameObject btn04;
    public GameObject btn05;

    public void Btnfunc01(){
        btn01.SetActive(true);
        btn02.SetActive(false);
        btn03.SetActive(false);
        btn04.SetActive(false);
        btn05.SetActive(false);
    }
    public void Btnfunc02(){
        btn01.SetActive(false);
        btn02.SetActive(true);
        btn03.SetActive(false);
        btn04.SetActive(false);
        btn05.SetActive(false);
    }
    public void Btnfunc03(){
        btn01.SetActive(false);
        btn02.SetActive(false);
        btn03.SetActive(true);
        btn04.SetActive(false);
        btn05.SetActive(false);
    }
    public void Btnfunc04(){
        btn01.SetActive(false);
        btn02.SetActive(false);
        btn03.SetActive(false);
        btn04.SetActive(true);
        btn05.SetActive(false);
    }
    public void Btnfunc05(){
        btn01.SetActive(false);
        btn02.SetActive(false);
        btn03.SetActive(false);
        btn04.SetActive(false);
        btn05.SetActive(true);
    }
}
