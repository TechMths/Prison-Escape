using UnityEngine;
using UnityEngine.InputSystem;

public class Interector : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        { 
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange)) 
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) 
                {
                    interactObj.Interact();
                }            
            }
        }
    }
}
