using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject gameOverPannel;

    private void Start()
    {
        gameOverPannel.SetActive(true);
        ResetAll();
    }

    public static void ResetAll()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
