using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : DialogueManager
{

    [SerializeField]List<string> _dialogueList = new List<string>();
    int _dialogueIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartFirstDialogue());
    }

    // Update is called once per frame
    void Update()
    {
        ui_animator.SetBool("isOn", _panelIsOn);
        
    }

    public int IndexUp()
    {
        if (_dialogueIndex > _dialogueList.Count)
        {
            _dialogueIndex++;
            SetPanelIsOne(true);
            return _dialogueIndex;
        }
        else
        {
            _dialogueIndex = 0;
            SetPanelIsOne(false);
            return _dialogueIndex;
        }

        
    }
    IEnumerator StartFirstDialogue()
    {
        if (!_panelIsOn)
        {
            _panelIsOn = true;
            
        }
        Dialogue(_dialogueList, _dialogueIndex);
        yield return new WaitForSeconds(1);
        _dialogueIndex++;

    }
}
