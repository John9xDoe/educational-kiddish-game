using UnityEngine;

public class GameSelectUIController : MonoBehaviour
{
    [SerializeField] private GameObject profilePanelRoot;

    public void OpenProfilePanel()
    {
        profilePanelRoot.SetActive(true);
    }

    public void CloseProfilePanel()
    {
        profilePanelRoot.SetActive(false);
    }
}