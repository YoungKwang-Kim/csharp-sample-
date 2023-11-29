using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchExp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = Convert.ToInt32("30");

        string line = "y";

        bool repeated = line == "y" ? true : false;

        string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
        {
            90 when repeated == true => "B+",
            90 => "A",
            80 => "B",
            70 => "C",
            60 => "D",
            _ => "F",
        };

        Debug.Log($"ÇÐÁ¡: {grade}");
    }
}
