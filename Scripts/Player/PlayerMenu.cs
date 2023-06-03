using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour
{
    public static bool isGameStarted;
    public GameObject startingText;
    public static bool gameOver;       
    public GameObject gameOverPanel;
    public Text coinsText;
    
    public static int numberOfCoins;
    // Start is called before the first frame update
    void Start()
    {   
         FindObjectOfType<SesYonetim>().PlaySound("galaxytheme");
        isGameStarted=false;
        gameOver=false;
        Time.timeScale=1;
        numberOfCoins = 0 ;
    }
    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            gameOverPanel.SetActive(true);  
            Time.timeScale = 0;
             
        }
        coinsText.text= "Coins: " + numberOfCoins;
         
        {
        if(SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(startingText);
            
        }
    }
} }
