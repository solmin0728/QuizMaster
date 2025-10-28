using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class math : MonoBehaviour
{
    public GameObject Panel;

    public void OnMathGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void NoMathGame()
    {
        Panel.SetActive(false);
    }
}

