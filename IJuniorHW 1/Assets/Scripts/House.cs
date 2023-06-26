using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class House : MonoBehaviour
{
    public UnityAction<bool> StateChanged;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player))
        {
            StateChanged?.Invoke(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            StateChanged?.Invoke(false);
        }
    }
}
