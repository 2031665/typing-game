using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text time;
    public static float currentTime;
    public bool countUp;
    public bool isThereLimit;
    public float Limit;
    public static bool isLimitExceeded;

    // Update is called once per frame
    void Update()
    {
        TimeLimit();
    }

    public static void resetTimer(){
        currentTime = 0;
    }

    private void TimeLimit(){
        
        currentTime = countUp ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if(isThereLimit && ((countUp && currentTime <= Limit) || (!countUp && currentTime >= Limit))){
            currentTime = Limit;
            time.text = currentTime.ToString();
            time.color = Color.red;
            isLimitExceeded = true;

        }else{
            time.text = currentTime.ToString();
            time.color = Color.white;
            isLimitExceeded = false;
        }
         
    }

}
