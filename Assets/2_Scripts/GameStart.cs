using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void OnStartGame()
    {
        SceneManager.LoadScene("Select");
    }
}
