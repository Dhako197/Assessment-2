using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class info : MonoBehaviour
{
    [SerializeField] private Image infoimage;
    [SerializeField] private TMP_Text infoText;
    public static info Instance { get; private set; }
    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
    
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    public void SetInfo(int damage,int defense, Sprite icon)
    {
        infoimage.sprite = icon;
        
        infoText.text = "Ataque= " +  damage + " \nDefensa= " + defense ;

    }

    public void CleanInfo()
    {
        infoimage.sprite = null;
        infoText.text = " ";

    }
    
    
}
