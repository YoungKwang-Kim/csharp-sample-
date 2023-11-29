using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calcurator : MonoBehaviour
{
    public TMP_Text displayText;
    private string currentInput = ""; // Current user input
    private string currentOperator = ""; // Current operator (+, -, *, /)
    private double result = 0.0; // Result of the calculation

    // Method to handle button clicks
    public void OnButtonClick(string value)
    {
        switch (value)
        {
            case "C": // Clear input
                currentInput = "";
                currentOperator = "";
                result = 0.0;
                break;

            case "=": // Perform calculation
                PerformCalculation();
                currentOperator = "";
                break;

            case "+":
            case "-":
            case "*":
            case "/":
                SetOperator(value);
                break;

            default: // Handle numeric input
                currentInput += value;
                break;
        }

        UpdateDisplay();
    }

    // Method to update the display text
    private void UpdateDisplay()
    {
        displayText.text = currentInput;
    }

    // Method to set the current operator
    private void SetOperator(string op)
    {
        if (!string.IsNullOrEmpty(currentInput))
        {
            if (!string.IsNullOrEmpty(currentOperator))
            {
                PerformCalculation();
            }

            result = double.Parse(currentInput);
            currentInput = "";
            currentOperator = op;
        }
    }

    // Method to perform the calculation
    private void PerformCalculation()
    {
        if (!string.IsNullOrEmpty(currentInput))
        {
            double input = double.Parse(currentInput);

            switch (currentOperator)
            {
                case "+":
                    result += input;
                    break;
                case "-":
                    result -= input;
                    break;
                case "*":
                    result *= input;
                    break;
                case "/":
                    if (input != 0)
                    {
                        result /= input;
                    }
                    else
                    {
                        // Handle division by zero
                        Debug.LogError("Cannot divide by zero!");
                    }
                    break;
            }

            currentInput = result.ToString();
        }
    }

}
