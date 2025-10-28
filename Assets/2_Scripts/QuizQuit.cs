using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizQuit : MonoBehaviour
{
    public GameObject QuizQuitPanel;
    public void OpenQuizQuitPanel()
    {
        QuizQuitPanel.SetActive(true);
    }

    public void QuizStartButton()
    {
        QuizQuitPanel.SetActive(false);
    }

    public void QuizQuitButton()
    {
        SceneManager.LoadScene("Select");
    }

    public void QuizRestartButton()
    {
        SceneManager.LoadScene("Game");
    }
}
