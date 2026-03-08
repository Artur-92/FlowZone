using System;
using System.Collections.Generic;
using UnityEngine;

public class S_Module : MonoBehaviour
{
    [SerializeField] private GameObject basePlane;
    public GameObject BasePlane => basePlane;

    private List<GameObject> interactables = new List<GameObject>();

    private void GetAllInteractables()
    {
        var allInteractables = GetComponentsInChildren<S_Interactable>(true);
        foreach (var interactable in allInteractables)
        {
            var go = interactable.gameObject;
            interactables.Add(go);
        }
        
        var allPickups = GetComponentsInChildren<S_Pickup>(true);
        foreach (var pickup in allPickups)
        {
            var go = pickup.gameObject;
            interactables.Add(go);
        }
    }

    public void ResetModule()
    { 
        interactables.Clear();
        GetAllInteractables();
        foreach (var interactable in interactables)
        {
            if (!interactable.activeInHierarchy)
            {
                interactable.SetActive(true);
                Debug.Log($"[RESET] Resetting {interactable.name}");
            }
        }
    }
}