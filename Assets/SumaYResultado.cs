using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SumaYResultado : MonoBehaviour
{
    public TMP_InputField InputNum1;
    public TMP_InputField InputNum2;
    public TextMeshProUGUI TxtResultado;
    int num1;
    int num2;

    // Start is called before the first frame update
    void Start()
    {
        TxtResultado.text = "";
    }

    public void SumarYMostrar()
    {
        num1 = int.Parse(InputNum1.text);
        num2 = int.Parse(InputNum2.text);
        TxtResultado.text = (num1 + num2).ToString();
    }   
}
