using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{
    [SerializeField] float problemTime = 10f; //문제 푸는 시간
    [SerializeField] float solutionTime = 3f; //정답 확인하는 시간
    float time = 0f;

    [HideInInspector] public bool isProblemTime = true;
    [HideInInspector] public float fillAmount;
    [HideInInspector] public bool LoadNextQuestion;

    public TextMeshProUGUI timerText; // 숫자 표시용
    public Color fastColor = Color.white;
    public Color midColor = Color.yellow;
    public Color slowColor = Color.red;


    private void Start()
    {
        time = problemTime;
        LoadNextQuestion = true;
    }

    private void Update()
    {
        TimerCountDown();
        UpdateFillAmount();
    }

    private void UpdateFillAmount()
    {
        if (isProblemTime)
        {
            fillAmount = time / problemTime;
        }
        else
        {
            fillAmount = time / solutionTime;
        }
    }

    private void TimerCountDown()
    {
        time -= Time.deltaTime;
        if (time <= 0f)
        {
            if (isProblemTime)
            {
                isProblemTime = false;
                time = solutionTime;
            }
            else
            {
                isProblemTime = true;
                time = problemTime;
                LoadNextQuestion = true;
            }
        }

        //숫자 타이머 표시
        if (timerText != null)
        {
            int seconds = Mathf.CeilToInt(time);
            timerText.text = seconds.ToString();

            float totalTime = isProblemTime ? problemTime : solutionTime;
            float t = time / totalTime;

            if (t > 0.5f)
                timerText.color = fastColor;
            else if (t > 0.3f)
                timerText.color = midColor;
            else
                timerText.color = slowColor;
        }
    }

    public void CancelTimer()
    {
        time = 0;
    }
}