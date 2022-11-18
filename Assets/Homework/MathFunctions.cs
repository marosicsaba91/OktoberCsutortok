using UnityEngine;

class MathFunctions : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int exponent;

    [SerializeField] int abs;
    [SerializeField] int sign;
    [SerializeField] float power;

    void OnValidate()
    {
        abs = AbsoluteValue(number);
        sign = (int) Sign(number);

        power = Power(number, exponent);
        float other = Power(5, 12);
    }

    int AbsoluteValue(int num) 
    {
        if (num >= 0)
        {
            return num;
        }
        else 
        {
            return -num;
        }
    }

    float Sign(float num) 
    {
        if (num >= 0) 
        {
            return 1;
        }

        return -1;
    }

    float Floor(float num) 
    {
        float remainder = num % 1;
        return num - remainder;

        // return (int)num;    
    }

    float Ceil(float num)
    {
        float remainder = num % 1;

        if (remainder == 0)
        {
            return num;
        }
        else
        {
            return num + 1 - remainder;
        }
    }

    float Round(float num)
    {
        float remainder = num % 1;

        if (remainder < 0.5f)
        {
            return Floor(num);
        }
        else 
        {
            return Ceil(num);
        }
    }

    float Power(float baseNum, int exponent) 
    {
        float result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }
        return result;
    }

    float Clamp(float number, float min, float max) 
    {
        if (number > max)
        {
            return max;
        }
        else if (number < min)
        {
            return min;
        }
        else 
        {
            return number;        
        }
    }

    float Clamp01(float number) 
    {
        return Clamp(number, 0, 1);
    }

    Vector3 DirectionVec(Vector3 start, Vector3 end) 
    {
        return (end - start).normalized;
    }
}
