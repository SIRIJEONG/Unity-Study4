using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI = default;
    public GameObject timeText = default;
    public GameObject recordText = default;

    private float surviveTime = default;
    private bool isGameOver = default;
    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0f;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            surviveTime += Time.deltaTime;
            timeText.SetText(string.Format("Score : {0} ", (int)surviveTime));
            //timeText.text = string.Format("Time : {0} ", (int)surviveTime);
        }
        //else
        {
            if (Input.GetKeyUp(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void Endgame()
    {
        isGameOver = true;
        gameOverUI.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestRecord");

        if (bestTime < surviveTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestRecord", bestTime);
        }

        recordText.SetText(string.Format("BestRecord : {0}", (int)bestTime));
        //recordText.text = string.Format("Best Time : {0}" , (int)bestTime);
    }
}
