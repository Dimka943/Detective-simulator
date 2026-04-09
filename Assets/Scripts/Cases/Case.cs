using UnityEngine;

[System.Serializable]
public class Case
{
    public string nameCase;
    public string descriptionCase;
    public string difficulteCase;

    public Case(string nameCase, string descriptionCase, string difficulteCase)
    {
        this.nameCase = nameCase;
        this.descriptionCase = descriptionCase;
        this.difficulteCase = difficulteCase;
    }
}