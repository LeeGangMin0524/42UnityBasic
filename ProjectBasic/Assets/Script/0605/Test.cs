using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLife : MonoBehaviour
{
    public new string name = "�̰���";
    public int age = 25;
    public float height = 170f;
    public float weight = 70.5f;
    public string gender = "����";
    public string mbti = "ISTP";
    public bool DriversLicense = true;
    public string[] hobbies = { "����", "��Ʃ���û", "���ͳ� ��� ����"};
    public int sleepHours = 8;
    public string home = "����Ư���� ������ â����";

    void PrintPersonInfo()
    {
        Debug.Log("�ڱ�Ұ�");
        Debug.Log("�̸�: " + name);
        Debug.Log("����: " + age + "��");
        Debug.Log("Ű: " + height + "cm");
        Debug.Log("������: " + weight + "kg");
        Debug.Log("����: " + gender);
        Debug.Log("MBTI: " + mbti);
        Debug.Log("�������� ���� ����: " + (DriversLicense ? "����" : "����"));
        Debug.Log("���: " + string.Join(", ", hobbies));
        Debug.Log("��� ���� �ð�: " + sleepHours + "�ð�");
        Debug.Log("�� ��ġ: " + home);
    }

    void Start()
    {
        PrintPersonInfo();
    }
}