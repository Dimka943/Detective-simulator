using Sirenix.OdinInspector;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class EvidenceObject : MonoBehaviour
{
    [SerializeField] private string name;
    [SerializeField] private string description;
    [SerializeField] int mergeIndex;
    [SerializeField] private Sprite icon;


    [Button]
    public void Take()
    {
        Evidence evidence = new Evidence(name,description,icon,mergeIndex);
        EvidencesManager.instanse.AddEvidence(evidence);
    }
}