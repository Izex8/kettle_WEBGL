using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class one_to_hundred : MonoBehaviour
{
    [SerializeField] private TextMeshPro _TextMeshPro;
    private int numb = 0;


    private void OnMouseUpAsButton()
    {
        while (numb <= 99)
        {
            StartCoroutine(ZeroToHundred());
        }
    }

    IEnumerator ZeroToHundred()
    {
        _TextMeshPro.text = numb.ToString();
        yield return StartCoroutine(WaitFor.Frames(10));
        numb++;
        Debug.Log(numb);
    }
   
    
}
