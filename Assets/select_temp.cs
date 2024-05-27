using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class select_temp : MonoBehaviour
{
    [SerializeField] private TextMeshPro _textMeshPro;
    private int _nbm = 0;

    private void OnMouseUpAsButton()
    {
        
        if (_nbm == 0)
        {
            _textMeshPro.text = "20";
            _nbm = 20;
        }
       else if (_nbm == 20)
        {
            _textMeshPro.text = "40";
            _nbm = 40;
        }
        else if (_nbm == 40)
        {
            _textMeshPro.text = "60";
            _nbm = 60;
        }
        else if (_nbm == 60)
        {
            _textMeshPro.text = "80";
            _nbm = 80;
        }
        else if (_nbm == 80)
        {
            _textMeshPro.text = "100";
            _nbm = 100;
        }
        else if (_nbm == 100)
        {
            _textMeshPro.text = "0";
            _nbm = 0;
        }
    }
}
