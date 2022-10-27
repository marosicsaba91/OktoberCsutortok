using UnityEngine;

class BoolPractice : MonoBehaviour
{
    void Start()
    {
        bool b = true;
        b = false;

        int i1 = 23;
        int i2 = 30;

        bool areTheInsEqual = i1 + 7 == i2;
        Debug.Log(areTheInsEqual);

        string s1 = "AAA";
        string s2 = "AAA";

        bool areTheStringsEqual = s1 == s2;
        Debug.Log(areTheStringsEqual);

        int i3 = 4, i4 = 78;
        bool areTheInsNotEqual = i3 != i4;


        bool isTheFirstHigher = i3 > i4;
        bool isTheFirstSmaller = i3 < 4;
        bool isTheFirstHigherOrEqual = i3 >= i4;
        bool isTheFirstSmallerOrEqual = i3 <= 4;

        // ----------------------

        bool isGrounded = true; // Foldon allunk-e?
        int airJumpCount = 1;   // Hanyat tudunk meg a levegoben ugrani?

        bool canJump = isGrounded || (airJumpCount > 0);

        int ammo = 23;
        float timeLeftSinceLastShot = 3.4f;
        float cooldown = 1;

        bool coolDownOver = timeLeftSinceLastShot >= cooldown;
        bool haveAmmo = ammo > 0;
        bool canShoot = haveAmmo && coolDownOver;

        bool canNotShot = !canShoot;


        // XOR
        bool xor = true ^ true;  // Kizaro vagy
    }
}
