using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //Intro Sequence
    [SerializeField]List<string> _introLines = new List<string>();
    int _introIndex = 0;
    [SerializeField] TextMeshProUGUI _introLines_Text;
    public bool _isIntroPanelOn=false;
    public Animator _animator;

    CharacterInput _characterInput;//Reference to the player input
    public CameraManagers _cameraManager;

    private void Awake()
    {
        _characterInput = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterInput>();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IntroSequence());
    }

    // Update is called once per frame
    void Update()
    {
        //_animator.SetBool("isOn", _isIntroPanelOn);
    }

    //Get &Set
    public bool GetisPanelOn()
    {
        return _isIntroPanelOn;
    }
    public void SetIsPanelOn(bool isOn)
    {
        _isIntroPanelOn = isOn;
    }

    IEnumerator IntroSequence()
    {
        yield return new WaitForSeconds(2);
        if (!_isIntroPanelOn)
        {
            _isIntroPanelOn = true;
        }


        while (_introIndex < _introLines.Count)
        {
            StartCoroutine(TypeSentence(_introLines[_introIndex]));
            yield return new WaitForSeconds(2);
            _introIndex++;
        }
        _isIntroPanelOn = false;
        _characterInput.SetIsAllowToMove(true);
        yield return new WaitForSeconds(1);
        _cameraManager.ChangeToMainCharacterCamera();
    }

    IEnumerator TypeSentence(string sentence)
    {
        _introLines_Text.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            _introLines_Text.text += letter;
            yield return new WaitForSeconds(.05f);
        }
    }
}
