using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

public class SelectSaves : MonoBehaviour
{
    public GameObject newGameCanvas;
    public GameObject enterSlotName;	// 플레이어 닉네임 입력UI
    public TextMeshProUGUI[] slotText;		// 슬롯버튼 아래에 존재하는 Text들
    public TextMeshProUGUI newPlayerName;	// 새로 입력된 플레이어의 닉네임
    bool[] savefile = new bool[3];	// 세이브파일 존재유무 저장

    void Start()
    {
        // 슬롯별로 저장된 데이터가 존재하는지 판단.
        for (int i = 0; i < 3; i++)
        {
            if (File.Exists(SaveManager.instance.path + $"{i}"))	// 데이터가 있는 경우
            {
                savefile[i] = true;			// 해당 슬롯 번호의 bool배열 true로 변환
                SaveManager.instance.slotNum = i;	// 선택한 슬롯 번호 저장
                SaveManager.instance.LoadData();	// 해당 슬롯 데이터 불러옴
                slotText[i].text = SaveManager.instance.nowData.saveName;	// 버튼에 닉네임 표시
            }
            else	// 데이터가 없는 경우
            {
                slotText[i].text = "비어있음";
            }
        }
        // 불러온 데이터를 초기화시킴.(버튼에 닉네임을 표현하기위함이었기 때문)
        SaveManager.instance.DeleteData();	
    }

    public void Slot(int number)	// 슬롯의 기능 구현
    {
        SaveManager.instance.slotNum = number;	// 슬롯의 번호를 슬롯번호로 입력함.

        if (savefile[number])	// bool 배열에서 현재 슬롯번호가 true라면 = 데이터 존재한다는 뜻
        {
            SaveManager.instance.LoadData();	// 데이터를 로드하고
            GoGame();	// 게임씬으로 이동
        }
        else	// bool 배열에서 현재 슬롯번호가 false라면 데이터가 없다는 뜻
        {
            Creat();	// 플레이어 닉네임 입력 UI 활성화
        }
    }

    public void Creat()	// 플레이어 닉네임 입력 UI를 활성화하는 메소드
    {
        enterSlotName.gameObject.SetActive(true);
    }

    public void GoGame()	// 게임씬으로 이동
    {
        if (!savefile[SaveManager.instance.slotNum])	// 현재 슬롯번호의 데이터가 없다면
        {
            SaveManager.instance.nowData.saveName = newPlayerName.text; // 입력한 이름을 복사해옴
            SaveManager.instance.SaveData(); // 현재 정보를 저장함.
        }
        newGameCanvas.SetActive(false);
    }
}
