using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score = 0;
    public int targetScore = 4; // Score to reach before changing scenes

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
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional

            /*
            The dont destroy on load will make sure that the game manager 
            stays active between scene loading.
            */
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("Score: " + score);

        if(score >= targetScore)
        {
            LoadNewScene();
        }
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene("VictoryScene 1"); // Use your new scene's name
    }
}
