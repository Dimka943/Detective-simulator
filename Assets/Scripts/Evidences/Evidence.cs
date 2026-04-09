using UnityEngine;

[System.Serializable]
public class Evidence
{
    public string name;
    public string description;
    public Sprite icon;
    public int mergeIndex;

    public Evidence(string name, string description, Sprite icon, int mergeIndex)
    {
        this.name = name;
        this.description = description;
        this.icon = icon;
        this.mergeIndex = mergeIndex;
    }
}