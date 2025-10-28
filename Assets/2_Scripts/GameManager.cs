using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private Quiz quiz;
    [SerializeField] private GameObject loadingCanvas;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //ShowQuizScreen();
    }

    public void ShowQuizScreen()
    {
        quiz.gameObject.SetActive(true);
    }

    public void ShowLoadingScreen()
    {
        loadingCanvas.SetActive(true);
    }

    public void OnReplayLeve()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    internal void StartGame()
    {
        throw new NotImplementedException();
    }
}
