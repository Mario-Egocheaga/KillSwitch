using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDetection : MonoBehaviour
{
    public TMP_InputField input;

    public GameObject prevSeq;
    public GameObject WhoWon;

    void Update()
    {
        if (input.text == "1234")
        {
            prevSeq.SetActive(false);
            WhoWon.SetActive(true);
        }
    }
}
