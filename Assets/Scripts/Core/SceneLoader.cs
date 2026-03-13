using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneNames
{
    public const string Boot = "Boot";
    public const string MainMenu = "MainMenu";
    public const string GameSelect = "GameSelect";
    public const string MiniGameTest = "MiniGame_Test";
}

public class SceneLoader : MonoBehaviour
{
    private bool isLoading;
    public void LoadScene(string sceneName)
    {
        if (isLoading) return;
        isLoading = true;
        SceneManager.LoadScene(sceneName);
    }

    public void LoadGameSelect() => SceneManager.LoadScene(SceneNames.GameSelect);

    public void LoadMiniGameTest() => SceneManager.LoadScene(SceneNames.MiniGameTest);
}
