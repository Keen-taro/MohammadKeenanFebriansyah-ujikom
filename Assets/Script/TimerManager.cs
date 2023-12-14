using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    private float playTime;
    private bool isFinished;

    public TextMeshProUGUI timeText;
    public GameObject finished;

    // Start is called before the first frame update
    void Start()
    {
        playTime = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(playTime >= 0)
        {
            DecreaseTime();
        }

        timeText.text = "Timer : " + playTime.ToString("N0");

        if(playTime == 0)
        {
            finished.SetActive(true);
        }
    }

    void DecreaseTime()
    {
        playTime -= Time.deltaTime;
    }
}
