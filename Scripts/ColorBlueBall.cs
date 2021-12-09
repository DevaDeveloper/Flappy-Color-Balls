using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlueBall : MonoBehaviour
{
    private Renderer rend;
    private BlueBall _blueball;
    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        _blueball = GetComponent<BlueBall>();
        rend = GetComponent<Renderer>();
        if (_blueball == null)
        {
            Debug.Log("_Blue Ball is NULL.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_player._coins >= 25)
        {
            rend.material.SetColor("_Color", Color.white);
        }
        if (_player._coins >= 50)
        {
            rend.material.SetColor("_Color", Color.green);
        }
        if (_player._coins >= 75)
        {
            rend.material.SetColor("_Color", Color.red);
        }
        if (_player._coins >= 100)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 125)
        {
            rend.material.SetColor("_Color", Color.white);
        }
        if (_player._coins >= 145)
        {
            rend.material.SetColor("_Color", Color.green);
        }
        if (_player._coins >= 165)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 185)
        {
            rend.material.SetColor("_Color", Color.white);
        }
        if (_player._coins >= 201)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 217)
        {
            rend.material.SetColor("_Color", Color.red);
        }
        if (_player._coins >= 234)
        {
            rend.material.SetColor("_Color", Color.green);
        }
        if (_player._coins >= 253)
        {
            rend.material.SetColor("_Color", Color.white);
        }
        if (_player._coins >= 271)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 289)
        {
            rend.material.SetColor("_Color", Color.white);
        }
        if (_player._coins >= 301)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 327)
        {
            rend.material.SetColor("_Color", Color.green);
        }
        if (_player._coins >= 337)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 351)
        {
            rend.material.SetColor("_Color", Color.white);
        }
        if (_player._coins >= 376)
        {
            rend.material.SetColor("_Color", Color.green);
        }
        if (_player._coins >= 401)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 431)
        {
            rend.material.SetColor("_Color", Color.red);
        }
        if (_player._coins >= 471)
        {
            rend.material.SetColor("_Color", Color.green);
        }
        if (_player._coins >= 501)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 551)
        {
            rend.material.SetColor("_Color", Color.white);
        }
    }
}
