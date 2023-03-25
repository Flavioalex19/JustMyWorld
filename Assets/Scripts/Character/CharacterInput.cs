using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    //Private Variables
    #region Movement Variables
    [SerializeField]Transform _cam;// A reference to the main camera in the scenes transform
    Vector3 _camForward;// The current forward direction of the camera
    public bool _isAllowToMove = false;//If the player can move around//TODO save this variable!!!
    Vector3 _move;
    #endregion

    int _dice;//Dice for the materials

    //Components
    CharacterManager _characterManager;
    CharacterMovement _characterMovement;

    // Start is called before the first frame update
    void Start()
    {
        _characterManager = GetComponent<CharacterManager>();
        _characterMovement = GetComponent<CharacterMovement>();


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
    private void FixedUpdate()
    {
        if (_isAllowToMove)
        {
            // read inputs
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            
            // calculate move direction to pass to character
            if (_cam != null)
            {
                // calculate camera relative direction to move:
                _camForward = Vector3.Scale(_cam.forward, new Vector3(1, 0, 1)).normalized;
                _move = v * _camForward + h * _cam.right;
            }
            else
            {
                // we use world-relative directions in the case of no main camera
                _move = v * Vector3.forward + h * Vector3.right;
            }
            

            // pass all parameters to the Movement script
            _characterMovement.Move(_move);
        }
    }
    public bool GetIsAllowToMove()
    {
        return _isAllowToMove;
    }
    public void SetIsAllowToMove(bool isAllwoToMove)
    {
        _isAllowToMove=isAllwoToMove;
    }
    //Just Roll the Dice!!!!!
    private void DiceRoll()
    {
        _dice = Random.Range(0, _characterManager.MaterialsList.Count);
    }
}
