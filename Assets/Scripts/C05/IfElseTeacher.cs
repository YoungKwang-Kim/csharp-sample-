using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IfElseTeacher : MonoBehaviour
{
    // ����ڿ��� �Է��� ���� Input Field
    public TMP_InputField inputField;
    // ȭ�鿡 ����� ����� Text
    public TMP_Text text;

    // ��ư�� Ŭ�� �Ǿ��� �� ������ �Լ�
    public void ButtonClicked()
    {
        string input = inputField.text;
        int number = int.Parse(input);

        if (number < 0)
        {
            text.text = "����";
        }
        else if (number > 0)
        {
            text.text = "���";
        }
        else
        {
            text.text = "0";
        }

        if (number % 2 == 0)
        {
            text.text += " ¦��";
        }
        else
        {
            text.text += " Ȧ��";
        }

        
    }
}
