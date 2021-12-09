using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : MonoBehaviour
{
    private Player _player;
    [SerializeField] private float _speed = 5f;
    
    
    void Start()
    {
        
        _player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if(transform.position.y <= -7)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            

            if (_player != null)
            {
                _player.AddCoins();
                
            }
            

            Destroy(this.gameObject);

        }
    }
    

}

