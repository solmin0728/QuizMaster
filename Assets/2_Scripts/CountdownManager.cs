using UnityEngine;
using TMPro;
using System.Collections;

public class CountdownManager : MonoBehaviour
{
    public GameObject countdownPanel; // UI 패널
    public TMP_Text countdownText;    // 텍스트
    public float countInterval = 1f;  // 1초 간격

    void Start()
    {
        // UI 카운트다운 시작
        StartCoroutine(UICountdownRoutine());
    }

    IEnumerator UICountdownRoutine()
    {
        countdownPanel.SetActive(true);

        int count = 3;
        while (count > 0)
        {
            countdownText.text = count.ToString();
            yield return new WaitForSeconds(countInterval);
            count--;
        }

        countdownText.text = "Go!";
        yield return new WaitForSeconds(countInterval);

        countdownPanel.SetActive(false);

        // UI 카운트다운 끝난 후 게임 카운트다운 시작
        yield return StartCoroutine(GameCountdownRoutine());
    }

    IEnumerator GameCountdownRoutine()
    {
        // 게임 안에서 3,2,1 카운트다운
        int gameCount = 3;
        while (gameCount > 0)
        {
            Debug.Log("게임 시작까지: " + gameCount);
            yield return new WaitForSeconds(1f);
            gameCount--;
        }

        Debug.Log("게임 시작!");
        // 여기서 실제 게임 로직 시작
        // 예: player.CanMove = true;
        yield return null;
    }
}
