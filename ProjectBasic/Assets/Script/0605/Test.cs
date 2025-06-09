using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLife : MonoBehaviour
{
    public new string name = "이강민";
    public int age = 25;
    public float height = 170f;
    public float weight = 70.5f;
    public string gender = "남성";
    public string mbti = "ISTP";
    public bool DriversLicense = true;
    public string[] hobbies = { "게임", "유튜브시청", "인터넷 방송 보기"};
    public int sleepHours = 8;
    public string home = "서울특별시 마포구 창전동";

    void PrintPersonInfo()
    {
        Debug.Log("자기소개");
        Debug.Log("이름: " + name);
        Debug.Log("나이: " + age + "세");
        Debug.Log("키: " + height + "cm");
        Debug.Log("몸무게: " + weight + "kg");
        Debug.Log("성별: " + gender);
        Debug.Log("MBTI: " + mbti);
        Debug.Log("운전면허 보유 여부: " + (DriversLicense ? "있음" : "없음"));
        Debug.Log("취미: " + string.Join(", ", hobbies));
        Debug.Log("평균 수면 시간: " + sleepHours + "시간");
        Debug.Log("집 위치: " + home);
    }

    void Start()
    {
        PrintPersonInfo();
    }
}