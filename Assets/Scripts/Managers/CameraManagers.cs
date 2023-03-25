using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagers : MonoBehaviour
{
    [SerializeField]CinemachineVirtualCamera _introCamera;
    [SerializeField] CinemachineVirtualCamera _characterCamera;

    [SerializeField] Transform _mainCharacter;

    private void Awake()
    {
        _characterCamera.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
        _introCamera.Priority = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _introCamera.Priority = 10;
            _characterCamera.gameObject.SetActive(true);
            _introCamera.gameObject.SetActive(false);
        }
    }

    public void ChangeToMainCharacterCamera()
    {
        _introCamera.Priority = 0;
        _characterCamera.gameObject.SetActive(true);
        _introCamera.gameObject.SetActive(false);
        //_characterCamera.Follow = _mainCharacter;
    }
}
