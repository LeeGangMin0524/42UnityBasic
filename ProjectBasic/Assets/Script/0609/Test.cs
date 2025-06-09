using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    // 5성 캐릭터
    private List<string> fiveStars = new List<string> { "각청 (픽업!)", "유라", "모나", "다이루크" };

    // 4성 캐릭터
    private List<string> fourStars = new List<string> { "노엘", "피슬", "베넷", "엠버", "리사", "케이아", "신염" };

    void Start()
    {
        DoTenDraws();
    }

    public void DoTenDraws()
    {
        Debug.Log("10연차 결과!");
        for (int i = 0; i < 10; i++)
        {
            string result = DrawCharacter();
            Debug.Log($"{i + 1}회차: {result}");
        }
    }

    private string DrawCharacter()
    {
        int roll = Random.Range(1, 101); // 1~100

        if (roll <= 10) // 10% 확률로 5성
        {
            return $"[5성] {GetFiveStar()}";
        }
        else
        {
            return $"[4성] {fourStars[Random.Range(0, fourStars.Count)]}";
        }
    }

    private string GetFiveStar()
    {
        // 5성 뽑았을 경우 픽업 각청 확률 50%
        int pickupRoll = Random.Range(0, 100);
        if (pickupRoll < 50)
        {
            return "각청 (픽업!)";
        }

        // 픽업 제외 나머지 5성에서 랜덤
        List<string> nonPickup = new List<string>(fiveStars);
        nonPickup.Remove("각청 (픽업!)");
        return nonPickup[Random.Range(0, nonPickup.Count)];
    }
}
