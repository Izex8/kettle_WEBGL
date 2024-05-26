using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Close : MonoBehaviour
{
    [SerializeField] private Animator Animator;
    // Update is called once per frame
    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
    

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Animator.SetTrigger("Active");
        }
    }
}
