using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TechStatusUI : MonoBehaviour
{
    public TextMeshProUGUI techName;
    public TextMeshProUGUI techPercent;
    public TextMeshProUGUI nowTech;
    public GameObject notice;
    private string[] techNameList = {"고급 천체역학", "소형 원자로", "원자력 로켓엔진", "소행성 채굴", "화성 탐사", "효율적 자원채광", "효율적 자원가공", "스카이훅", "수성 탐사", "다이슨 패널" ,"다이슨 에너지 집광", "우주 레일"};

    private void Update() {
        int nowTech = GameManager.instance.GameTechUnlocked;

        float nowTechPercent = ReturnPercent(nowTech);
        techName.text = techNameList[nowTech];
        techPercent.text = (nowTechPercent * 100).ToString("N1") + "%";
    }

    private float ReturnPercent(int tech){
        if(tech == 0){
            float add = GameManager.instance.tech01[0] + GameManager.instance.tech01[1] + GameManager.instance.tech01[2];
            float total = 150;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 1){
            float add = GameManager.instance.tech02[0] + GameManager.instance.tech02[1] + GameManager.instance.tech02[2];
            float total = 200;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 2){
            float add = GameManager.instance.tech03[0] + GameManager.instance.tech03[1] + GameManager.instance.tech03[2];
            float total = 350;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 3){
            float add = GameManager.instance.tech04[0] + GameManager.instance.tech04[1] + GameManager.instance.tech04[2];
            float total = 600;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 4){
            float add = GameManager.instance.tech05[0] + GameManager.instance.tech05[1] + GameManager.instance.tech05[2];
            float total = 150;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 5){
            float add = GameManager.instance.tech06[0] + GameManager.instance.tech06[1] + GameManager.instance.tech06[2];
            float total = 250;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 6){
            float add = GameManager.instance.tech07[0] + GameManager.instance.tech07[1] + GameManager.instance.tech07[2];
            float total = 350;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 7){
            float add = GameManager.instance.tech08[0] + GameManager.instance.tech08[1] + GameManager.instance.tech08[2];
            float total = 600;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 8){
            float add = GameManager.instance.tech09[0] + GameManager.instance.tech09[1] + GameManager.instance.tech09[2];
            float total = 250;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 9){
            float add = GameManager.instance.tech10[0] + GameManager.instance.tech10[1] + GameManager.instance.tech10[2];
            float total = 200;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 10){
            float add = GameManager.instance.tech11[0] + GameManager.instance.tech11[1] + GameManager.instance.tech11[2];
            float total = 300;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        if(tech == 11){
            float add = GameManager.instance.tech12[0] + GameManager.instance.tech12[1] + GameManager.instance.tech12[2];
            float total = 600;

            float percent = add / total;
            NoticeAuto(percent);
            return percent;
        }
        return 0;
    }
    private void NoticeOff(){
        notice.SetActive(false);
    }
    private void NoticeON(){
        notice.SetActive(true);
    }
    private void NoticeAuto(float percent){
        if(percent == 1){
            notice.SetActive(true);
        }
        else notice.SetActive(false);
    }
}