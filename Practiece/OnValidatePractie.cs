using UnityEngine;

class OnValidatePractie : MonoBehaviour
{
    [SerializeField] int intSetting;
    [SerializeField] float floatSetting;
    [SerializeField] string stringSetting;
    [SerializeField] bool canJump;
    [SerializeField] int startAmmo = 34;

    [Space(15)]
    [SerializeField] float num1;
    [SerializeField] float num2;
    [SerializeField] float sum;

    int filedVariable = 55;   // Field / Tagvaltozo

    void OnValidate()
    {
        sum = num1 + num2;
    }

    void Start()
    {
        int localVariable = 66;
        int summa = localVariable + filedVariable + intSetting;

        Debug.Log(summa);
    }
}