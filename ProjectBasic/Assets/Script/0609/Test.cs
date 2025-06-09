using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    // 5�� ĳ����
    private List<string> fiveStars = new List<string> { "��û (�Ⱦ�!)", "����", "��", "���̷�ũ" };

    // 4�� ĳ����
    private List<string> fourStars = new List<string> { "�뿤", "�ǽ�", "����", "����", "����", "���̾�", "�ſ�" };

    void Start()
    {
        DoTenDraws();
    }

    public void DoTenDraws()
    {
        Debug.Log("10���� ���!");
        for (int i = 0; i < 10; i++)
        {
            string result = DrawCharacter();
            Debug.Log($"{i + 1}ȸ��: {result}");
        }
    }

    private string DrawCharacter()
    {
        int roll = Random.Range(1, 101); // 1~100

        if (roll <= 10) // 10% Ȯ���� 5��
        {
            return $"[5��] {GetFiveStar()}";
        }
        else
        {
            return $"[4��] {fourStars[Random.Range(0, fourStars.Count)]}";
        }
    }

    private string GetFiveStar()
    {
        // 5�� �̾��� ��� �Ⱦ� ��û Ȯ�� 50%
        int pickupRoll = Random.Range(0, 100);
        if (pickupRoll < 50)
        {
            return "��û (�Ⱦ�!)";
        }

        // �Ⱦ� ���� ������ 5������ ����
        List<string> nonPickup = new List<string>(fiveStars);
        nonPickup.Remove("��û (�Ⱦ�!)");
        return nonPickup[Random.Range(0, nonPickup.Count)];
    }
}
