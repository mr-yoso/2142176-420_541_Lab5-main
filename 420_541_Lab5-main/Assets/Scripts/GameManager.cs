using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int maxScore = 0;
    public static GameManager Instance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("Score : " + score);
        if (score > maxScore)
        {
            LoadNewScene();
        }
    }

    public void LoadNewScene()
    {
/*        SceneManager.LoadScene("VictoryScene");
*/    }
}
