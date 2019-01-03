using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour
{
    public float timeLeft = 10.0f;
    public Text text;
    public Text lose;
    bool gameOver = false;

    void Update()
    {
        if(!gameOver)
        {
            timeLeft -= Time.deltaTime;
            text.text = "Time Left: " + Mathf.Round(timeLeft);
            if (timeLeft < 0)
            {
                Debug.Log("Mission ended!");
                gameOver = true;
                lose.enabled = true;
            }
        }
      
    }
}