using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string day = "월";

        switch (day) 
        {
            case "일":
                Debug.Log("Sunday");
                break;
            case "월":
                Debug.Log("Monday");
                break;
            case "화":
                Debug.Log("Tuesday");
                break;
            case "수":
                Debug.Log("Wednesday");
                break;
            case "목":
                Debug.Log("Thursday");
                break;
            case "금":
                Debug.Log("Friday");
                break;
            case "토":
                Debug.Log("Saturday");
                break;
            default:
                Debug.Log($"{day}는(은) 요일이 아닙니다.");
                break;
        }
    }
}
