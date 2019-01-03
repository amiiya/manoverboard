using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour
{
    AudioSource audioSource;
    GameObject arrow;
    public float timeLeft = 10.0f;
    public Text text;
    public Text lose;
    public Text win;
    bool gameOver = false;

    void Start()
    {
        arrow = GameObject.Find("arrow");
        audioSource = arrow.GetComponent<AudioSource>();
    }
    void Update()
    {
        if(!gameOver)
        {
            timeLeft -= Time.deltaTime;
            text.text = "Time Left: " + Mathf.Round(timeLeft);
            if (timeLeft < 0)
            {
                gameOver = true;
                lose.gameObject.SetActive(true);
                win.gameObject.SetActive(false);
                arrow.gameObject.SetActive(false);
                audioSource.mute = true;
            }
        }
      
    }
}