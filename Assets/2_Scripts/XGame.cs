using UnityEngine;
using UnityEngine.SceneManagement;

public class XGame : MonoBehaviour
{
    public void OnExidGame()
    {
        SceneManager.LoadScene("Select");
    }
}