using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfElse : MonoBehaviour
{
    public InputField input;
    public Text result;

    // Start is called before the first frame update
    public void AnalyzeInput()
    {
        // Get input from the Input Field
        string inputString = input.text;

        // Try to parse the input as a float
        if (float.TryParse(inputString, out float number))
        {
            // Check if the number is even or odd
            string parity = (number % 2 == 0) ? "짝수" : "홀수";

            // Check if the number is negative or positive
            string sign = (number < 0) ? "음수" : "양수";

            // Display the result in the UI Text element
            result.text = $"입력하신 숫자 {number}는 {parity}, {sign}입니다.";
        }
        else
        {
            // Display an error message if the input is not a valid number
            result.text = "Invalid input. Please enter a valid number.";
        }
    }
}
