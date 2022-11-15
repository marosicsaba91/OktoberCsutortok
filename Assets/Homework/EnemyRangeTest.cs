using UnityEngine;

class EnemyRangeTest : MonoBehaviour
{
    [SerializeField] float minRange, maxRange;
    [SerializeField] float rangeMultiplier = 1;
    [SerializeField] float enemyDistance;

    [SerializeField] bool canHitEnemy;


    void OnValidate()
    {
        canHitEnemy =
            (enemyDistance > minRange) &&
            (enemyDistance <= rangeMultiplier * maxRange);
    }
}
