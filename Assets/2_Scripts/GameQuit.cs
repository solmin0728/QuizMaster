using UnityEngine;

public class GameQuit : MonoBehaviour
{
    // 게임 종료 버튼에 연결
    public void OnQuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // 에디터에서 테스트 시 종료
#endif
    }
}
