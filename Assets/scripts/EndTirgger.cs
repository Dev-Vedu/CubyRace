using UnityEngine;

public class EndTirgger : MonoBehaviour
{
    public gamemanagaer gamemanagaer;
     void OnTriggerEnter()
    {
        gamemanagaer.completelevel();
    }
}
