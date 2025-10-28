using UnityEngine;
using TMPro;
using System.Collections;

public class CountdownManager : MonoBehaviour
{
    public GameObject countdownPanel;
    public TMP_Text countdownText;
    public float countInterval = 1f;

    void Start()
    {
        // 게임 멈춤
        Time.timeScale = 0f;

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

            // 숫자가 표시된 상태로 1초 대기
            yield return new WaitForSecondsRealtime(countInterval);

            count--; // 1초가 지난 뒤 감소
        }

        // "Go!" 표시
        countdownText.text = "Go!";
        yield return new WaitForSecondsRealtime(countInterval);

        countdownPanel.SetActive(false);

        // 게임 재개
        Time.timeScale = 1f;

        Debug.Log("게임 시작!");
    }
}
