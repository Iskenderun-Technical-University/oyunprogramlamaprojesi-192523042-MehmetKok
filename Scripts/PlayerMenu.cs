using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenu : MonoBehaviour
{
    public static bool isGameStarted;
    public static bool gameOver;    
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameOver=false;
        Time.timeScale=1;
    }
    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);  
        }
        if(SwipeManager.tap)
            isGameStarted = true;
    }
}
