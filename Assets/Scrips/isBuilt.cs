using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class isBuilt : MonoBehaviour
{
    [SerializeField] GameObject Floor;
    [SerializeField] GameObject redSocket;
    void Update()
    {
        Transform redTransform = null;
        if (redSocket.GetComponent<XRSocketInteractor>().attachTransform == redTransform)
        {
            Floor.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}