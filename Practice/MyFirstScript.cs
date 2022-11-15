using UnityEngine;

class MyFirstScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("Hello " + name);

        // Comment        
        /* Ez is egy comment */

        int myFirstVariable;
        myFirstVariable = 9;
        Debug.Log(myFirstVariable);


        int aaa = 456;

        int x, y, z;

        int integerNumber = 231;
        float myFloatingPointNumber = 123.67f;
        string myFirstString = "sdfghjk";
        bool myFirstBool = true;
        myFirstBool = false;



        int a = 3, b = -1, c = 90;
        int summa = a + b;
        Debug.Log(summa);           // 2

        int dif = c - 55;           // 35
        dif = dif - 5;              // 30
        dif -= 5;                   // 25

        int num = 6;
        num = num + 1;
        num += 1;
        num++;
        Debug.Log(num);             // 9

        int product = a * 5;        // 15
        float ratio = a / 5;          // 0

        int modulo = 33 % a;        // 0

        var iii = 3456;
        var sss = "erty";

        int xxx = 3 + 2 * 4;        // 11
        xxx = (3 + 2) * 4;          // 20

        string s1 = "Hello";
        string s2 = "World";

        string s3 = s1 + " " + s2;  // Hello World

        int i1 = 3, i2 =7;
        string s4 = s1 + i1;        // Hello3
        string s5 = s1 + i1 + i2;   // Hello37
        string s6 = i2.ToString();
        string s7 = i1 + i2 + s1;   // 10Hello

        float ff1 = 3.5f;
        int ii1 = 4;

        int ii2 = (int)ff1;
        float ff2 = ii1;

        string numberText = "567";
        int ii3 = int.Parse(numberText);
    }
}