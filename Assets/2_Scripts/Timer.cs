using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]float problemTime = 10f; //문제 푸는 시간
    [SerializeField]float solutionTime = 3f; //정답 확인하는 시간
    float time = 0f;

    [HideInInspector] public bool isProblemTime = true;
    [HideInInspector] public float fillAmount;
    [HideInInspector] public bool LoadNextQuestion;

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

            Debug.Log("시간초과!");
        }
    }

    public void CancelTimer()
    {
        time = 0;
    }
}