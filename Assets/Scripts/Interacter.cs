using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Interacter : MonoBehaviour 
{
   
    public Transform InteracterSource;
    public float InteractRange;
    
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Ray r = new Ray(InteracterSource.position, InteracterSource.forward);
            if(Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
          {
                if(hitInfo.collider.gameObject.TryGetComponent<IInteractable>(out IInteractable interactable))
                {
                 interactable.Interact();
                }
          }
       
        }
    }
}
