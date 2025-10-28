using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanagaer : MonoBehaviour
{
    bool gamehasended = false;
    public float restartDelay = 1f;
    public GameObject completelevelUI;
    
    public void completelevel()
    {
        completelevelUI.SetActive(true);
        
    }
     public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("game over");
            Invoke("restart",restartDelay);
        }
       
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}