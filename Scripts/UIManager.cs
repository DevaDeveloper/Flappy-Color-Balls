using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject playerObject;
    [SerializeField]
    private GameObject _panelMenu;
    [SerializeField] public Text _textCoin;
    [SerializeField] public Text _livesText;
    public Text _highScore;
    public int bestScore;
    private Monetization _monetization;
    
    
    
    private Player _player;
    // Start is called before the first frame update
    void Start()
    {

        _monetization = GameObject.Find("AdManager").GetComponent<Monetization>();
        bestScore = PlayerPrefs.GetInt("HighScore", defaultValue: 0);
        _player = GameObject.Find("Player").GetComponent<Player>();
        _highScore.text = "Highest: " + bestScore;
        if (_player == null)
        {
            Debug.Log("Player is NULL.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCoinDisplay(int coin)
    {
        _textCoin.text = "Balls: " + coin.ToString();

    }
    public void UpdateLives(int lives)
    {
        _livesText.text = "Lives: " + lives.ToString();
    }
    public void CheckBestScore()
    {
        if (_player._coins > bestScore)
        {
            bestScore = _player._coins;
            PlayerPrefs.SetInt("HighScore", bestScore);
            _highScore.text = "Highest: " + bestScore;
        }
    
    } 
    
    public void nextLevel()
    {
        if (_player._coins >= 50)
        {
            PlayerPrefs.SetInt("nextLevel", _player._coins);
        }
    }

    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void PauseMenu()
    {

        Time.timeScale = 0;
        _panelMenu.SetActive(true);
    }
    public void ResumePlay()
    {
        Time.timeScale = 1;
        _panelMenu.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void BacktoMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void ContinueAd()
    {
        _monetization.DisplayVideoAd();
         _player.SafeContinue();
        
    }
}
