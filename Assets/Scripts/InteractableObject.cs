using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    [TextArea]
    public string interactionText;

    public void Interact()
    {
        InteractionUI.Instance.ShowText(interactionText);
    }
}

