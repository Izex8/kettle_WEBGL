using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Close : MonoBehaviour
{
    [SerializeField] private Animator press_button;
    [SerializeField] private Animator cap;
    // Update is called once per frame
    
    private void OnMouseUpAsButton()
    {
        press_button.SetTrigger("Active");
        cap.SetTrigger("Active");
        
    }
}
