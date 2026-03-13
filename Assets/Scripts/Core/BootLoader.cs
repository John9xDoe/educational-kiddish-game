using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BootLoader : MonoBehaviour
{
    [SerializeField] private float delay = 2f;
    [SerializeField] private string nextSceneName = "MainMenu";

    private void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    private IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(delay);

        AsyncOperation operation = SceneManager.LoadSceneAsync(nextSceneName);

        while (!operation.isDone)
        {
            yield return null;
        }
    }
}