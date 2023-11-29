using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ToLowerString("Hello!"));
        Debug.Log(ToLowerString("Good Morning."));
        Debug.Log(ToLowerString("This is C#"));

    }

    static string ToLowerString(string input)
    {
        var arr = input.ToCharArray();
        for(int i=0; i<arr.Length; i++)
        {
            arr[i] = ToLowerChar(i);
        }

        char ToLowerChar(int i)
        {
            if (arr[i] < 65 || arr[i] > 90) // A ~ Z의 ASC|| 값 : 65 ~ 90
                return arr[i];
            else // a ~ z의 ASC|| 값 : 97 ~ 122
                return (char)(arr[i] + 32);
        }

        return new string(arr);
    }
}
