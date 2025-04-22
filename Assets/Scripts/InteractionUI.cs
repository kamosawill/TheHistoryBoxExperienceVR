using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractionUI : MonoBehaviour
{
    
    public static InteractionUI Instance;
    public GameObject popupPanel;
    
    
    public TextMeshProUGUI textMeshPro;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            popupPanel.SetActive(false);
        }
        else
        {
            Destroy(textMeshPro);
        }
    }

    public void ShowText(string text)
    {
        textMeshPro.text = text;
        popupPanel.SetActive(true);
    }

    public void HideText()
    {
        popupPanel.SetActive(false);
    }
    void Update()
{
    if (popupPanel.activeSelf && Input.GetKeyDown(KeyCode.Escape))
    {
        HideText();
    }
}
}
