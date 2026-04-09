using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EvidencesManager : MonoBehaviour
{
    [SerializeField] private List<Evidence> evidences;
    public static EvidencesManager instanse;
    public Action<Evidence> evidencesAdd;
    public Action<Evidence> evidencesRemove;

    public void OnEnable()
    {
        instanse = this;
    }

    [Button]
    public void AddEvidence(Evidence evidence)
    {
        evidences.Add(evidence);
        evidencesAdd?.Invoke(evidence);
        print("Взяли улику");
    }

    public void RemoveEvidence(Evidence evidence)
    {
        evidences.Remove(evidence);
        evidencesRemove?.Invoke(evidence);
    }

    private void OnDestroy()
    {
        instanse = null;
    }
}