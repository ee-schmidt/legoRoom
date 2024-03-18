using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour
{
    public GameObject source;
    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(0);
    }
}
