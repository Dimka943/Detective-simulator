using UnityEngine;

public class UIEvidencesScreen : MonoBehaviour
{
    public UISlot[] mergeSlots;
    public UIItem itemPrefab;

    private void Start()
    {
        EvidencesManager.instanse.evidencesAdd += AddEvidence;
        EvidencesManager.instanse.evidencesRemove += RemoveEvidence;
    }

    public void AddEvidence(Evidence evidence)
    {
        foreach (var slot in mergeSlots)
        {
            UIItem item = slot.GetComponentInChildren<UIItem>();
            if (item == null)
            {
                Instantiate(itemPrefab, slot.transform);
                break;
            }
        }
    }

    public void RemoveEvidence(Evidence evidence)
    {
        
    }

    private void OnDestroy()
    {
        EvidencesManager.instanse.evidencesAdd -= AddEvidence;
        EvidencesManager.instanse.evidencesRemove -= RemoveEvidence;
    }
}