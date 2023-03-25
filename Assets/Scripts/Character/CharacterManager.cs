using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{

    
    public List<Material> MaterialsList = new List<Material>();//list of materials

    //private Variables
    MeshRenderer _my_renderer;
    Material _my_material;

    // Start is called before the first frame update
    void Start()
    {
        _my_renderer = transform.GetChild(0).GetComponent<MeshRenderer>();
        _my_material = _my_renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Change material of the children(the red rectangle)
    public void ChangeMaterial(int materialIndex)
    {
        
        //transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().material.mainTexture = MaterialsList[materialIndex].mainTexture;
        _my_renderer.material = MaterialsList[materialIndex];
        
    }
}
