using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    int[] numbers = new int[3];
    List<int> numberList = new List<int>();

    void Start()
    {
        numbers[0] = 100;
        numbers[1] = 200;
        numbers[2] = 300;

        numberList.Add(100);
        numberList.Add(200);
        numberList.Add(300);
        numberList.Add(400);
        numberList.Add(500);

        Debug.Log(numbers[0]);
        Debug.Log(numberList[4]);
    }
}
