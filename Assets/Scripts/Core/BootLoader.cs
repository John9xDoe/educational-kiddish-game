using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BootLoader : MonoBehaviour
{
    [SerializeField] private float delay = 2f;
    [SerializeField] private string nextSceneName = SceneNames.GameSelect;

    private bool isLoading;

    private void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    private IEnumerator LoadNextScene()
    {
        if (isLoading) yield break;
        isLoading = true;

        yield return new WaitForSeconds(delay);

        yield return SceneManager.LoadSceneAsync(nextSceneName);
    }
}