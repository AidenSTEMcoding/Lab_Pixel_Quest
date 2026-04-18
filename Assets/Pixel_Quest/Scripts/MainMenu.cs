using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string startScene;

    public string StartScene;

    public void LoadLevel()
    {
        SceneManager.LoadScene(startScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
