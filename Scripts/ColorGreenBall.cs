using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGreenBall : MonoBehaviour
{
    private Renderer rend;
    private GreenBall _greenball;
    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        _greenball = GetComponent<GreenBall>();
        rend = GetComponent<Renderer>();
        if (_greenball == null)
        {
            Debug.Log("_Green Ball is NULL.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_player._coins >= 50)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 100)
        {
            rend.material.SetColor("_Color", Color.red);
        }
        if (_player._coins >= 217)
        {
            rend.material.SetColor("_Color", Color.blue);

        }
        if (_player._coins >= 271)
        {
            rend.material.SetColor("_Color", Color.white);

        }
        if (_player._coins >= 289)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 301)
        {
            rend.material.SetColor("_Color", Color.white);
        }
        if (_player._coins >= 351)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
        if (_player._coins >= 401)
        {
            rend.material.SetColor("_Color", Color.green);
        }
        if (_player._coins >= 471)
        {
            rend.material.SetColor("_Color", Color.red);
        }
    }
}
