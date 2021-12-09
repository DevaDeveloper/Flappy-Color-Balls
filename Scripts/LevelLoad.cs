using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    private Player _player;
    private UIManager _uiManager;
   
    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _player = GameObject.Find("Player").GetComponent<Player>();
        if (_player == null)
        {
            Debug.Log("Player is NULL.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Level2());
        
    }
    IEnumerator Level2()
   {
       if (_player._coins >= 50)
       {
           yield return new WaitForSeconds(1.0f);
           SceneManager.LoadScene(2);
            
            Destroy(this.gameObject);
       }
   }
    

}
