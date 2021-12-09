using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _blueBall;
    [SerializeField]
    private GameObject _redBall;
    [SerializeField] private GameObject _blackBall;
    [SerializeField] private GameObject _orangeBall;
    [SerializeField] private GameObject _greenBall;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnRoutine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(2.0f);
        Vector3 blueposition = new Vector3(-3.6f, 7, 0);
        Vector3 redposition = new Vector3(0, 7, 0);
        Vector3 blackposition = new Vector3(3.6f, 7, 0);
        Vector3 orangeposition = new Vector3(-1.8f, 7, 0);
        Vector3 greenposition = new Vector3(1.8f, 7, 0);
        while (true)
        {
            
            //1
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //2
            Instantiate(_blueBall, redposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //3
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, blueposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //4
            Instantiate(_blueBall, redposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //5
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, greenposition, Quaternion.identity);
            Instantiate(_greenBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //6
            Instantiate(_blueBall, greenposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //7
            Instantiate(_blueBall, orangeposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_orangeBall, greenposition, Quaternion.identity);
            Instantiate(_greenBall, blueposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //8
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, blueposition, Quaternion.identity);
            Instantiate(_blackBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            Instantiate(_greenBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //9
            Instantiate(_blueBall, greenposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            Instantiate(_greenBall, blueposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //10
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, greenposition, Quaternion.identity);
            Instantiate(_greenBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //11
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, greenposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //12
            Instantiate(_blueBall, greenposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //13
            Instantiate(_blueBall, orangeposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, greenposition, Quaternion.identity);
            Instantiate(_greenBall, blueposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //14
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, greenposition, Quaternion.identity);
            Instantiate(_greenBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //15
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, blueposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, greenposition, Quaternion.identity);
            Instantiate(_greenBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //16
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, blackposition, Quaternion.identity);
            Instantiate(_blackBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, greenposition, Quaternion.identity);
            Instantiate(_greenBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //17
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //18
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //19
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //20
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //21
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //22
            Instantiate(_blueBall, greenposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, blueposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //23
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //23
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //24
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, greenposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, redposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //25
            Instantiate(_blueBall, orangeposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, blueposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //26
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //27
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //28
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //29
            Instantiate(_blueBall, greenposition, Quaternion.identity);
            Instantiate(_redBall, redposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, blueposition, Quaternion.identity);
            Instantiate(_orangeBall, orangeposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //30
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //31
            Instantiate(_blueBall, orangeposition, Quaternion.identity);
            Instantiate(_redBall, blueposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //32
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //33
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //34
            Instantiate(_blueBall, greenposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, blueposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //35
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //36
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //37
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //38
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //39
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //40
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //41
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //42
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //43
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //44
            Instantiate(_blueBall, orangeposition, Quaternion.identity);
            Instantiate(_redBall, blueposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //45
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //46
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //47
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //48
            Instantiate(_blueBall, greenposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, blueposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //49
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //50
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //51
            Instantiate(_blueBall, blueposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blackposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            //52
            Instantiate(_blueBall, blackposition, Quaternion.identity);
            Instantiate(_redBall, orangeposition, Quaternion.identity);
            Instantiate(_blackBall, blueposition, Quaternion.identity);
            Instantiate(_greenBall, greenposition, Quaternion.identity);
            Instantiate(_orangeBall, redposition, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            






        }
    }
    public void onPlayerDeath()
    {
        StopCoroutine("SpawnRoutine");
    }
    public void onPlayerAwake()
    {
        StartCoroutine("SpawnRoutine");
    }
}
