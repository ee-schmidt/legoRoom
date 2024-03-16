using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;
using TMPro;
using System.Threading;


public class isBuilt : MonoBehaviour
{
    //deleting the floor variable declaration
    [SerializeField] GameObject Floor;
  


    //timer variable declaration
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if(remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            SceneManager.LoadScene(0);
        }
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    
}
