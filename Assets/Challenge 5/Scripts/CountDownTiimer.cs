using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTiimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        UpdateTimer();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString();
    }

    public void UpdateTimer()
    {
        countdownText.text = "Time: " + currentTime;
    }
}
