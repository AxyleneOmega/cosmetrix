using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class materialChanger : MonoBehaviour
{
    public GameObject [] faces;
    [SerializeField]private ARFaceManager faceManager;
    [SerializeField]private int faceMaterialIndex = 0;
    void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
    }

    public void SwitchFace()
    {
        
        Debug.Log("1");
        faceManager.ChangeFace(faces[faceMaterialIndex]);
        Debug.Log("2");
        faceMaterialIndex++;
        if (faceMaterialIndex > faces.Length)
        {
            faceMaterialIndex = 0;
        }
    }
}
