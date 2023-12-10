using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using FactoryFramework;
public class TechTreeUI : MonoBehaviour
{
    public GameObject[] lockImg;
    public GameObject unlockBtn;
    public GameObject nextPlanet;
    public GameObject unlockRocketUI;
    public GameObject techTreeUI;
    int techNumber = 0;
    public TextMeshProUGUI[] techListText01;
    public TextMeshProUGUI[] techListText02;
    public TextMeshProUGUI[] techListText03;
    public TextMeshProUGUI[] techListTextRequire;

    private void Start() {
        for (int i = 0; i < 36; i++){
            techListTextRequire[i].text = GameManager.instance.techBaseData[i].ToString();
        }

        InvStorage.SetTech(GameManager.instance.GameTechUnlocked);
    }
    private void Update() {
        UpdateUnlocked();

        if(GameManager.instance.GameTechUnlocked == 4 && GameManager.instance.GamePlanetUnlocked == 1){
            NextPlanetActive();
        }

        if(GameManager.instance.GameTechUnlocked == 8 && GameManager.instance.GamePlanetUnlocked == 2){
            NextPlanetActive();
        }

        if(GameManager.instance.GameTechUnlocked == 12 && GameManager.instance.GamePlanetUnlocked == 3){
            NextPlanetActive();
        }

        if (GameManager.instance.GameTechUnlocked == 0){
                techListText01[0].text = GameManager.instance.tech01[0].ToString();
                techListText01[1].text = GameManager.instance.tech01[1].ToString();
                techListText01[2].text = GameManager.instance.tech01[2].ToString();

                if(GameManager.instance.tech01[0] == 50 && GameManager.instance.tech01[1] == 50 && GameManager.instance.tech01[2] == 50){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 1){
                techListText01[3].text = GameManager.instance.tech02[0].ToString();
                techListText01[4].text = GameManager.instance.tech02[1].ToString();
                techListText01[5].text = GameManager.instance.tech02[2].ToString();
                if(GameManager.instance.tech02[0] == 100 && GameManager.instance.tech02[1] == 50 && GameManager.instance.tech02[2] == 50){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 2){
                techListText01[6].text = GameManager.instance.tech03[0].ToString();
                techListText01[7].text = GameManager.instance.tech03[1].ToString();
                techListText01[8].text = GameManager.instance.tech03[2].ToString();
                if(GameManager.instance.tech03[0] == 150 && GameManager.instance.tech03[1] == 100 && GameManager.instance.tech03[2] == 100){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 3){
                techListText01[9].text = GameManager.instance.tech04[0].ToString();
                techListText01[10].text = GameManager.instance.tech04[1].ToString();
                techListText01[11].text = GameManager.instance.tech04[2].ToString();
                if(GameManager.instance.tech04[0] == 200 && GameManager.instance.tech04[1] == 200 && GameManager.instance.tech04[2] == 200){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 4){
                techListText02[0].text = GameManager.instance.tech05[0].ToString();
                techListText02[1].text = GameManager.instance.tech05[1].ToString();
                techListText02[2].text = GameManager.instance.tech05[2].ToString();
                if(GameManager.instance.tech05[0] == 50 && GameManager.instance.tech05[1] == 50 && GameManager.instance.tech05[2] == 50){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 5){
                techListText02[3].text = GameManager.instance.tech06[0].ToString();
                techListText02[4].text = GameManager.instance.tech06[1].ToString();
                techListText02[5].text = GameManager.instance.tech06[2].ToString();
                if(GameManager.instance.tech06[0] == 100 && GameManager.instance.tech06[1] == 50 && GameManager.instance.tech06[2] == 100){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 6){
                techListText02[6].text = GameManager.instance.tech07[0].ToString();
                techListText02[7].text = GameManager.instance.tech07[1].ToString();
                techListText02[8].text = GameManager.instance.tech07[2].ToString();
                if(GameManager.instance.tech07[0] == 150 && GameManager.instance.tech07[1] == 100 && GameManager.instance.tech07[2] == 100){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 7){
                techListText02[9].text = GameManager.instance.tech08[0].ToString();
                techListText02[10].text = GameManager.instance.tech08[1].ToString();
                techListText02[11].text = GameManager.instance.tech08[2].ToString();
                if(GameManager.instance.tech08[0] == 200 && GameManager.instance.tech08[1] == 200 && GameManager.instance.tech08[2] == 200){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 8){
                techListText03[0].text = GameManager.instance.tech09[0].ToString();
                techListText03[1].text = GameManager.instance.tech09[1].ToString();
                techListText03[2].text = GameManager.instance.tech09[2].ToString();
                if(GameManager.instance.tech09[0] == 50 && GameManager.instance.tech09[1] == 100 && GameManager.instance.tech09[2] == 100){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 9){
                techListText03[3].text = GameManager.instance.tech10[0].ToString();
                techListText03[4].text = GameManager.instance.tech10[1].ToString();
                techListText03[5].text = GameManager.instance.tech10[2].ToString();
                if(GameManager.instance.tech10[0] == 100 && GameManager.instance.tech10[1] == 100 && GameManager.instance.tech10[2] == 0){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 10){
                techListText03[6].text = GameManager.instance.tech11[0].ToString();
                techListText03[7].text = GameManager.instance.tech11[1].ToString();
                techListText03[8].text = GameManager.instance.tech11[2].ToString();
                if(GameManager.instance.tech11[0] == 150 && GameManager.instance.tech11[1] == 150 && GameManager.instance.tech11[2] == 0){
                    unlockBtn.SetActive(true);
                }
        }
        else if(GameManager.instance.GameTechUnlocked == 11){
                techListText03[9].text = GameManager.instance.tech12[0].ToString();
                techListText03[10].text = GameManager.instance.tech12[1].ToString();
                techListText03[11].text = GameManager.instance.tech12[2].ToString();
                if(GameManager.instance.tech12[0] == 200 && GameManager.instance.tech12[1] == 200 && GameManager.instance.tech12[2] == 200){
                    unlockBtn.SetActive(true);
                }
        }

        
    }

    public void UpdateUnlocked(){
        techNumber = GameManager.instance.GameTechUnlocked;

        if(GameManager.instance.GamePlanetUnlocked == 1){
            for(int i = 0; i < techNumber; i++){
                if(techNumber >= 4){
                    GameManager.instance.GameTechUnlocked = 4;
                    techNumber = 4;
                }

                else if(techNumber >= 8){
                    GameManager.instance.GameTechUnlocked = 8;
                    techNumber = 8;
                }

                else if(techNumber >= 12){
                    GameManager.instance.GameTechUnlocked = 12;
                    techNumber = 12;
                }
                lockImg[i].SetActive(true);
            }
        }
        for (int i = 0; i < techNumber; i++){
            lockImg[i].SetActive(true);
        }

        if(techNumber == 12){
            unlockBtn.SetActive(false);
        }
    }

    public void UnlockNextTech(){
        if(GameManager.instance.GamePlanetUnlocked == 1 && GameManager.instance.GameTechUnlocked >=4){
            GameManager.instance.GameTechUnlocked = 4;
        }
        else if(GameManager.instance.GamePlanetUnlocked == 2 && GameManager.instance.GameTechUnlocked >=8){
            GameManager.instance.GameTechUnlocked = 8;
        }
        else if(GameManager.instance.GamePlanetUnlocked == 3 && GameManager.instance.GameTechUnlocked >=12){
            GameManager.instance.GameTechUnlocked = 12;
        }
        else if(GameManager.instance.GameTechUnlocked <= 11){
            GameManager.instance.GameTechUnlocked += 1;
        }

        unlockBtn.SetActive(false);
        InvStorage.SetTech(GameManager.instance.GameTechUnlocked);
    }

    public void NextPlanetActive(){
        nextPlanet.SetActive(true);
    }
    public void UnlockRocketUI(){
        unlockRocketUI.SetActive(true);
        techTreeUI.SetActive(false);
    }

}
