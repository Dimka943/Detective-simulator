using UnityEditor.Rendering;
using UnityEngine;

public class UIMerges : MonoBehaviour
{
    public UISlot[] mergeSlots;

    private void OnEnable()
    {
        foreach (var slot in mergeSlots)
        {
            slot.onItemChange += Merge;
        }
    }

    private void OnDisable()
    {
        foreach (var slot in mergeSlots)
        {
            slot.onItemChange -= Merge;
        }
    }

    private void Merge()
    {
        int currentMergeIndex = -1;
        bool mergeSucessful = true;
        foreach (var slot in mergeSlots)
        {
            UIItem item = slot.GetComponentInChildren<UIItem>();
            if (item == null)
            {
                mergeSucessful = false;
                print("Слот пустой");
                break;
            }
            if (currentMergeIndex == -1)
            {
                currentMergeIndex = item.mergeIndex;
            }
            if (item.mergeIndex != currentMergeIndex)
            {
                mergeSucessful = false;
                print("Не совмещается");
                break;
            }
        }
        if (mergeSucessful == true)
        {
            print("Совмещаем");
        }
    }
}