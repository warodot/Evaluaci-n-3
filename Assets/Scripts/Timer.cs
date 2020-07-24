using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer = 60;
    public TextMeshProUGUI timerText;
    public GameObject gameOverScreen;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer > 0)
        {
            timerText.SetText(timer.ToString("000"));
        }
        else
        {
            Debug.Log("game over");
            gameOverScreen.SetActive(true);
            if(Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
