using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class one_to_hundred : MonoBehaviour
{
    [SerializeField] private TextMeshPro _TextMeshPro;
    


    private void OnMouseUpAsButton()
    {
        StartCoroutine(ZeroToHundred());        
    }

    IEnumerator ZeroToHundred()
    {

        for (int numb = 0; numb <= 100; numb++)
        {
            yield return new WaitForSeconds(0.2f);
            _TextMeshPro.text = numb.ToString();
        }
        yield return new WaitForSeconds(5);
        for (int numb = 100; numb >= 0; numb--)
        {
            yield return new WaitForSeconds(0.2f);
            _TextMeshPro.text = numb.ToString();
        }
    }


}
