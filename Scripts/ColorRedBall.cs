using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRedBall : MonoBehaviour
{
    private Renderer rend;
    
    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        
        rend = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_player._coins >= 75)
        {
            rend.material.SetColor("_Color", Color.white);
        }
        if (_player._coins >= 125)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 165)
        {
            rend.material.SetColor("_Color", Color.green);
        }
        if (_player._coins >= 234)
        {
            rend.material.SetColor("_Color", Color.red);
        }
        if (_player._coins >= 431)
        {
            rend.material.SetColor("_Color", Color.blue);

        }
        if (_player._coins >= 501)
        {
            rend.material.SetColor("_Color", Color.green);
        }
    }
}
