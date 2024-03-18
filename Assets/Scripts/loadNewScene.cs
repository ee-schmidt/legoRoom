using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNewScene : MonoBehaviour
{
    public GameObject source;
    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(4);
    }
}
