using UnityEngine;

public class PlatformerCameraControl : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float maxVericalDistance;

    void Update()
    {
        Vector3 playerPos = player.position;


        float y = transform.position.y;

        if (y < playerPos.y - maxVericalDistance) 
        {
            y = playerPos.y - maxVericalDistance;
        }

        if(y > playerPos.y + maxVericalDistance)
        {
            y = playerPos.y + maxVericalDistance;
        }

        transform.position = 
            new Vector3(playerPos.x, y, transform.position.z);
    }
}
