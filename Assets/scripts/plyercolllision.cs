using UnityEngine;

public class plyercollision : MonoBehaviour
{
    public playermovement movement;
    void OnCollisionEnter(Collision collisionInfo)
        
    {
        if(collisionInfo.collider.name == "obstacle")
        {
            movement.enabled = false;
        }

    }
}
