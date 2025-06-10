using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    string star;
    int phaseCounter = 1;

    // 버튼 클릭 시 하나 씩 호출하는 방식
    public void OnClickButton()
    {
        switch (phaseCounter)
        {
            case 1: Phase1(); break;
            case 2: Phase2(); break;
            case 3: Phase3(); break;
            case 4: Phase4(); break;
            case 5: Phase5(); break;
            default: Debug.Log("모든 Phase 완료"); return;
        }

        phaseCounter++;
    }

    // Phase1
    public void Phase1()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
                if (j < i - 1) star += "　";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    // Phase2
    public void Phase2()
    {
        star = string.Empty;

        for (int i = 0; i < 5; i++)
        {
         
            for (int s = 0; s < i * 2; s++)
            {
                star += "　";
            }

            for (int j = 0; j < 5 - i; j++)
            {
                star += "★";
                if (j < 5 - i - 1) star += "　"; 
            }

            star += "\n";
        }

        Debug.Log(star);
    }


    // Phase3
    public void Phase3()
    {
        star = string.Empty;

        // 위
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
                if (j < i - 1) star += "　";
            }
            star += "\n";
        }

        // 아래
        for (int i = 4; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
                if (j < i - 1) star += "　";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    // Phase4
    public void Phase4()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
           
            for (int s = 0; s < (5 - i) * 2; s++)
            {
                star += "　";
            }

            for (int j = 0; j < i; j++)
            {
                star += "★";
                if (j < i - 1) star += "　";
            }

            star += "\n";
        }

        for (int i = 4; i >= 1; i--)
        {
            for (int s = 0; s < (5 - i) * 2; s++)
            {
                star += "　";
            }

            for (int j = 0; j < i; j++)
            {
                star += "★";
                if (j < i - 1) star += "　";
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    // Phase5 
    public void Phase5()
    {
        star = string.Empty;

        int max = 5;

        for (int i = 1; i <= max; i++)
        {
            for (int s = 0; s < (max - i) * 2; s++)
            {
                star += "　";
            }

            for (int j = 0; j < i * 2 - 1; j++)
            {
                star += "★";
                if (j < i * 2 - 2) star += "　";
            }

            star += "\n";
        }

        for (int i = max - 1; i >= 1; i--)
        {
            for (int s = 0; s < (max - i) * 2; s++)
            {
                star += "　";
            }

            for (int j = 0; j < i * 2 - 1; j++)
            {
                star += "★";
                if (j < i * 2 - 2) star += "　";
            }

            star += "\n";
        }

        Debug.Log(star);
    }
}
