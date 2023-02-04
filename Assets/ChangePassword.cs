using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangePassword : MonoBehaviour
{
    public TextMeshProUGUI passwordtext;

    public RandomPassword randomPassword;

    public bool player1;

    void Update()
    {
        if (player1)
        {
            passwordtext.text = randomPassword.player1Pass.ToString();
        }
        else
        {
            passwordtext.text = randomPassword.player2Pass.ToString();
        }
    }
}
