using UnityEngine;
using UnityEngine.UI;

public class ChangeScreenBtn : MonoBehaviour
{
    public Button button;
    public int screen;

    void Start()
    {
        button.onClick.AddListener(() =>
        {
            UIManager.instance.ShowScreen(screen);
        });
    }
}