using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static float MinCount;
    static float MaxCount;
    private int minute;     //　制限時間(分)
    private float second;   //　制限時間(秒)
    public Text timerText;


    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
        MaxCount = 10;
        MinCount = 0;

        minute = 0;
        second = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (MaxCount >= MinCount)
        {
            MaxCount -= Time.deltaTime;
        }
        timerText.text = MaxCount.ToString("f0");

       
    }
}
