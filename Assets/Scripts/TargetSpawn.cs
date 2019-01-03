using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    GameObject uicamera;
    public Text win;
    public Text lose;
    AudioSource audioSource;

    void Start()
    {
        uicamera = GameObject.Find("UICamera");
        audioSource = GetComponent<AudioSource>();
        int distance = Random.Range(200, 300);
        Vector3 position = new Vector3(distance % 2 == 0 ? distance*1 : distance*-1, 0, Random.Range(0, 2) == 0 ? distance*1 : distance*-1);
        Debug.Log(position);
        transform.position = position;
    }

    void OnCollisionEnter(Collision col)
    {
        transform.position = new Vector3(transform.position.x, 10, transform.position.z);
        RenderSettings.fog = false;
        win.gameObject.SetActive(true);
        uicamera.GetComponent<Countdown>().enabled = false;
        audioSource.mute = true;
    }
}
