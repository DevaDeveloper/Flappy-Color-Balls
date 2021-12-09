using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject thisObject;
    public CharacterController2D controller;
    [SerializeField] private int _health = 10;
    [SerializeField]
    private float _speed = 5.0f;
    public int _coins;
    private UIManager _uiManager;
    [SerializeField]
    private int _lives = 3;
    private AudioSource _audioSource;
    [SerializeField]
    private GameObject _ContinueAd;
    private SpawnManager _spawnManager;
    
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        _spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        _audioSource = GetComponent<AudioSource>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        if(_uiManager == null)
        {
            Debug.Log("UIManager is NULL.");
        }
        _uiManager.UpdateLives(_lives);
        

    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(Level2());
        float horizInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizInput * _speed * Time.deltaTime);

        if (transform.position.x >= 4.52f)
        {
            transform.position = new Vector3(4.52f, transform.position.y, 0);
        }
        if (transform.position.x <= -4.45f)
        {
            transform.position = new Vector3(-4.4f, transform.position.y, 0);
        }

    }
   // IEnumerator Level2()
   // {
   //     if (_coins >= 10)
   //     {
   //         yield return new WaitForSeconds(1.0f);
   //         SceneManager.LoadScene(2);
   //     }
   // }
   
    

    public void Damage()
    {
        _lives--;
        _uiManager.UpdateLives(_lives);

        if(_lives < 1)
        {
            _uiManager.CheckBestScore();
            thisObject.SetActive(false);
           // Destroy(this.gameObject);
            Time.timeScale = 0;
            _ContinueAd.SetActive(true);
            


            
            
        }
        _uiManager.UpdateLives(_lives);
    }
    public void AddCoins()
    {
        _audioSource.Play();
        _coins++;
        _uiManager.UpdateCoinDisplay(_coins);
        

    }
    public void ContinueWithAd()
    {

        Time.timeScale = 1;
        _lives = 4;
        _uiManager.UpdateLives(_lives);
        thisObject.SetActive(true);
        _ContinueAd.SetActive(false);

    }
    public void SafeContinue()
    {
        _lives = 4;
        _uiManager.UpdateLives(_lives);
        thisObject.SetActive(true);
        _ContinueAd.SetActive(false);
    }
    //public void  SafestContinue()
    //{
    //    Time.timeScale = 1;
    //    
    //    _spawnManager.onPlayerAwake();
    //    _lives = 3;
    //    _uiManager.UpdateLives(_lives);
    //    thisObject.SetActive(true);
    //    _ContinueAd.SetActive(false);
    //
    //}
    //public void ActivatingPlayer()
    //{
    //    _lives = 3;
    //    _uiManager.UpdateLives(_lives);
    //    thisObject.SetActive(true);
    //    _ContinueAd.SetActive(false);
    //}


}
