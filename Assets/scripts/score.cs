using UnityEngine;
using TMPro;   // ✅ Needed for TextMeshPro

public class Score : MonoBehaviour
{
    public Transform player;     // Reference to player
    public TMP_Text scoreText;   // Reference to TMP Text UI

    void Update()
    {
        // Update score based on player's Z position
        scoreText.text = player.position.z.ToString("0");
    }
}
