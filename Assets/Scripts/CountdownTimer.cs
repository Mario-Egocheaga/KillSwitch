using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public int countDownTime;
    public TextMeshProUGUI countDownText;

    public GameObject whoWon;
    public GameObject prevSection;
    public GameObject firstSection;

    public void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countDownTime > 0)
        {
            countDownText.text = countDownTime.ToString();
            yield return new WaitForSeconds(1f);
            countDownTime--;
        }

        countDownText.text = "GO!";

        whoWon.SetActive(true);
        prevSection.SetActive(false);

        yield return new WaitForSeconds(1f);

        countDownText.gameObject.SetActive(false);
        
    }
}
