using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public GameObject timeText;
    public string nextSceneName;
    public float transitionTime = 10f;
    private bool StartGame = false;
    private float elapsedTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGame = true;
        }
        if (StartGame)
        {
            elapsedTime += Time.deltaTime;
            UpdatetimeText();
            if (elapsedTime >= transitionTime)
            {
                GameManager.Instance.EndGame();
            }
        }
    }

    private void UpdatetimeText()
    {
        this.timeText.GetComponent<TextMeshProUGUI>().text = "Time:" + elapsedTime.ToString("F2") + " Sec";
    }
}
