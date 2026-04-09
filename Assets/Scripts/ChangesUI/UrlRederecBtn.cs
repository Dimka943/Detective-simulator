using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UrlRederecBtn : MonoBehaviour
{
    public Button btn;
    public string url;
    void Start()
    {
        btn.onClick.AddListener(() =>
        {
            Application.OpenURL(url);
        });
    }
}