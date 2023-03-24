using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagers : MonoBehaviour
{
    [SerializeField]CinemachineVirtualCamera _introCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _introCamera.Priority = 0;
            _introCamera.gameObject.SetActive(false);
        }
    }
}
