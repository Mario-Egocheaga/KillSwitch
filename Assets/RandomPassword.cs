using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPassword : MonoBehaviour
{
    public string [] passwords;

    static public RandomPassword randomPassword;

    public int player1int, player2int;

    public string player1Pass, player2Pass;

    private void Start()
    {
        randomPassword = this;

        player1int = Random.Range(0, passwords.Length);
        player2int = Random.Range(0, passwords.Length);

        player1Pass = passwords[player1int];
        player2Pass = passwords[player2int];

        Debug.Log(player1Pass);
        Debug.Log(player2Pass);
    }



}
