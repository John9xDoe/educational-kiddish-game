using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadGameSelect()
    {
        SceneManager.LoadScene("GameSelect");
    }

    public void LoadMiniGameTest()
    {
        SceneManager.LoadScene("MiniGame_Test");
    }
}
