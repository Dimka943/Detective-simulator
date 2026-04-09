using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject[] screens;
    private GameObject lastScreen;
    public static UIManager instance;

    private void Start()
    {
        instance = this;
        ShowScreen(0);
    }

    public void ShowScreen(int index)
    {
        if (lastScreen != null)
        {
            lastScreen.SetActive(false);
        }
        lastScreen = screens[index];
        screens[index].SetActive(true);
    }

    private void OnDestroy()
    {
        instance = null;
    }
}