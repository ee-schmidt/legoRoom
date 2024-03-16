/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;


public class isBuilt : MonoBehaviour
{
    [SerializeField] GameObject Floor;
    [SerializeField] GameObject redSocket;
    [SerializeField] int nextScene;

    void Update()
    {
        Transform redTransform = null;
        if (redSocket.GetComponent<XRSocketInteractor>().attachTransform == redTransform)
        {
            Floor.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == goFreeBuild)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}

*/