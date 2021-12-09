using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Player _player;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void WhiteColor()
    {
        if (_player._coins >= 10)
        {
            rend.material.SetColor("_Color", Color.white);
        }
    }
    
}
