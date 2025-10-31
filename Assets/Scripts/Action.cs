using UnityEngine;

public class Action : MonoBehaviour, IInteractable
{
    public void Interact() 
    {
        Debug.Log(Random.Range(0, 100));
    }
}
