using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public LayerMask mask;
    public Transform obj;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 15, Color.red);
        if (Physics.Raycast(ray, out hit, 15, mask))
        {
            obj = hit.transform;
            obj.GetComponent<Outline>().enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Взаимодействуем");
            }
        }
        else
        {
            obj.GetComponent<Outline>().enabled = false;
        }
    }
}