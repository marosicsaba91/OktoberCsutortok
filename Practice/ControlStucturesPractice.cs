using UnityEngine;

class ControlStucturesPractice : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string parity;
    [SerializeField] string domain;
    [SerializeField] string danger;
    [SerializeField] string divideableBy3;

    void OnValidate()
    {
        // ELAGAZASOK

        bool isEven = number % 2 == 0;

        if (isEven)
        {
            parity = "PAROS";
        }
        else
        {
            parity = "PARATLAN";
        }

        // ---------------------

        if (number > 0)
        {
            domain = "POZITIV";
        }
        else if (number < 0)
        {
            domain = "NEGATIV";
        }
        else 
        {
            domain = "NULLA";
        }

        // ---------------------

        if (number < 5)
        {
            danger = "Very Low";
        }
        else if (number < 10)
        {
            danger = "Low";
        }
        else if (number < 35)
        {
            danger = "Medium";
        }
        else if (number < 50)
        {
            danger = "High";
        }
        else
        {
            danger = "Very High";
        }

        // ----------------------------
        divideableBy3 = number % 3 == 0 ? "OSZTHATO" : "NEM OSZTHATO";
    }

    void Start()
    {
        // CIKLUSOK -------------------

        int i = 1;
        while (i <= 5)
        {
            Debug.Log(i);
            i++;
        }

        for (i = 1; i <= 5; i++)
        {
            Debug.Log(i);
        }

        for (int j = 10; j >= 1; j--)
        {
            Debug.Log(j);
        }

        for (i = 1; i <= 100; i+=3)
        {
            Debug.Log(i);
        }

        //Írjuk ki a szémokat 1 és 100 közt, amik oszthatók 3-mal és 7-tel is!
        for (i = 7; i < 100; i+=7)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
