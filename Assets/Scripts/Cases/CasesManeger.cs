using UnityEngine;

public class CasesManeger : MonoBehaviour
{
    public Case[] cases;
    public static CasesManeger instanse;

    private void OnEnable()
    {
        instanse = this;
    }

    private void OnDisable()
    {
        instanse = null;
    }
}