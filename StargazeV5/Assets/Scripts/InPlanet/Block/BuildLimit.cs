using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildLimit : MonoBehaviour //건축물 설치 제한
{
    private int[] build = {20,20,20,20,20,40,40,100,10}; //건축물당 제한 수량

    public GameObject[] btn;
    public GameObject[] limit;

    public void Btn01Press(){
        build[0] -= 1;
        if(build[0] == 0) limit[0].SetActive(true);
    }

    public void Btn02Press(){
        build[1] -= 1;
        if(build[1] == 0) limit[1].SetActive(true);
    }
    public void Btn03Press(){
        build[2] -= 1;
        if(build[2] == 0) limit[2].SetActive(true);
    }
    public void Btn04Press(){
        build[3] -= 1;
        if(build[3] == 0) limit[3].SetActive(true);
    }
    public void Btn05Press(){
        build[4] -= 1;
        if(build[4] == 0) limit[4].SetActive(true);
    }
    public void Btn06Press(){
        build[5] -= 1;
        if(build[5] == 0) limit[5].SetActive(true);
    }
    public void Btn07Press(){
        build[6] -= 1;
        if(build[6] == 0) limit[6].SetActive(true);
    }
    public void Btn08Press(){
        build[7] -= 1;
        if(build[7] == 0) limit[7].SetActive(true);
    }
    public void Btn09Press(){
        build[8] -= 1;
        if(build[8] == 0) limit[8].SetActive(true);
    }
}
