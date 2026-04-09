using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneBtn : MonoBehaviour
{
    public Button button;
    public int scene;

    void Start()
    {
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(scene);
        });
    }
}