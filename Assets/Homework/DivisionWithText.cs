using UnityEngine;

class DivisionWithText : MonoBehaviour
{
    [SerializeField] int number1, number2;
    [SerializeField] string text;

    void OnValidate()
    {
        if (number2 == 0)
        {
            text = "Nullaval nem tudunk osztani.";
        }
        else
        {
            int wholes = number1 / number2;
            int remainder = number1 % number2;

            text = $"{number1}-ben a {number2} megvan {wholes}-szor.  Maradek a {remainder}";
            // text = number1 + "-ben a " + number2 + " megvan ";
        }
    }

    void Start()
    {
        Debug.Log("Pi: " + Mathf.PI);
    }
}
