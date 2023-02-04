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

    public GameObject Player1Won, Player2Won;

    public bool player1;

    public RandomPassword passwordHolder;

    void Update()
    {

        if (player1)
        {
            if (input.text == passwordHolder.player1Pass)
            {
                prevSeq.SetActive(false);
                WhoWon.SetActive(true);
                Player1Won.SetActive(true);
            }
        }
        else
        {
            if (input.text == passwordHolder.player2Pass)
            {
                prevSeq.SetActive(false);
                WhoWon.SetActive(true);
                Player2Won.SetActive(true);
            }
        }
    }
}
