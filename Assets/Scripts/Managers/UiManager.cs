using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{

    [Header("Character Manager UI Elements")]
    [SerializeField] CharacterManager _characterManager;

    [SerializeField]GameManager _gameManager;

    [SerializeField] Animator _introMessagePanelAnimator;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _introMessagePanelAnimator.SetBool("isOn", _gameManager.GetisPanelOn());
        
    }
}
