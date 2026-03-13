using UnityEngine;
using UnityEngine.UI;

public class TabSwitcher : MonoBehaviour
{
    [SerializeField] private Image background;

    //[SerializeField] private Sprite playBg;
    //[SerializeField] private Sprite playTogetherBg;

    public void OnPlay()
    {
        background.color = new Color(0f, 0f, 0f, 0.75f);
    }

    public void OnPlayTogether()
    {
        background.color = new Color(0.7f, 0.1f, 0.8f);
    }
}