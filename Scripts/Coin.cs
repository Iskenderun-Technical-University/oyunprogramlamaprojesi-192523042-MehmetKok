using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(60* Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
             FindObjectOfType<SesYonetim>().PlaySound("PickUpCoin");
            PlayerMenu.numberOfCoins++;
            Debug.Log("Coins:"+PlayerMenu.numberOfCoins);
            Destroy(gameObject);
        }
    }
}
