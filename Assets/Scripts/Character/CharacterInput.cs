using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    //Private Variables
    int _dice;

    //Components
    CharacterManager _characterManager;

    // Start is called before the first frame update
    void Start()
    {
        _characterManager = GetComponent<CharacterManager>();


    }

    // Update is called once per frame
    void Update()
    {
        //Change the color of the cube
        if (Input.GetButtonDown("ChangeColor"))
        {
            //Debug.Log("Testing!!!!");
            DiceRoll();
            _characterManager.ChangeMaterial(_dice);
        }
    }

    //Just Roll the Dice!!!!!
    private void DiceRoll()
    {
        _dice = Random.Range(0, _characterManager.MaterialsList.Count);
    }
}
