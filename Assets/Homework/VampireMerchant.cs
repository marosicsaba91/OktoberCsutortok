using UnityEngine;

class VampireMerchant : MonoBehaviour
{
    [SerializeField] int myGold;
    [SerializeField] int myHp;

    [SerializeField] bool canBuyMace;
    [SerializeField] bool canBuyDagger;
    [SerializeField] bool canBuyTeeth;

    private void OnValidate()
    {
        const int goldToHP = 5;

        int macePrice = 10;
        canBuyMace = macePrice <= myGold || macePrice * goldToHP < myHp;


        int daggerPrice = 4;
        canBuyDagger = (daggerPrice - myGold) * goldToHP < myHp;
    }
}
