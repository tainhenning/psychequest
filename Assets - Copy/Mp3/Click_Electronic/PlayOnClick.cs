using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayOnClick : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(play);
    }
    void play()
    {
        GetComponent<AudioSource>().Play();
    }
}
