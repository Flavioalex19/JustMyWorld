using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    //If the panel is on
    public bool _panelIsOn = false;
    public Animator ui_animator;
    [SerializeField] TextMeshProUGUI _lineText;

    public void Dialogue(List<string> list, int index)
    {
        //verify if the dialogue painel is on
        if (_panelIsOn)
        {
            //call the animation
            //Verify if the list has ended
            if (index < list.Count)
            {
                StartCoroutine(TypeSentence(list[index], _lineText));
            }
            else
            {
                //animator.SetBool("on", false);
                _panelIsOn = false;
            }
        }
        else
        {
            //animator.SetBool("on", false);
            _panelIsOn = false;
        }



    }

    //function for dialogue - create the effect of typing the sentence
    IEnumerator TypeSentence(string sentence, TextMeshProUGUI GUItext)
    {
        GUItext.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            GUItext.text += letter;
            yield return new WaitForSeconds(.01f);
        }
    }

    public bool GetPanelIsOn()
    {
        return _panelIsOn;
    }
    public void SetPanelIsOne(bool isOn)
    {
        _panelIsOn = isOn;
    }
}
