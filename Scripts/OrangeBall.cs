using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeBall : MonoBehaviour
{
    [SerializeField]private float _speed = 5.0f;
    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y <= -7)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
            if(_player != null)
            {
                _player.Damage();
            }
        }
    }

}
