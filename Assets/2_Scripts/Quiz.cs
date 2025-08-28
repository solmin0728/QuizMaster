using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [Header("질문")]
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QSO question;

    [Header("보기")]
    [SerializeField] GameObject[] answerButtons;

    [Header("버튼 색")]
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    [Header("타이머")]
    [SerializeField] Image TimerImage;
    [SerializeField] Sprite problemTimeSprite;
    [SerializeField] Sprite solutionTimeSprite;
    Timer timer;
    bool chooseAnswer = false;

    void Start()
    {
        timer = FindFirstObjectByType<Timer>();
        GetNextQuestion();
    }

    private void Update()
    {
        //타이머 이미지 업데이트
        if (timer.isProblemTime)
            TimerImage.sprite = problemTimeSprite;
        else
            TimerImage.sprite = solutionTimeSprite;

        TimerImage.fillAmount = timer.fillAmount;

        //다음 문제 불러오기
        if (timer.LoadNextQuestion)
        {
            timer.LoadNextQuestion = false;
            GetNextQuestion();
        }

        //문제 시간에 답을 선택하지 않았을 때
        if (timer.isProblemTime == false && chooseAnswer == false)
        {
            DisplaySolution(-1);
        }
    }

    private void GetNextQuestion()
    {
        chooseAnswer = false;
        SetButtonState(true);
        SetDefaultButtonSprites();
        OnDisplayQuestion();
    }

    private void OnDisplayQuestion()
    {
        questionText.text = question.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = question.GetAnswers(i);
        }
    }

    public void OnAnswerButtonClicked(int index)
    {
        chooseAnswer = true;
        DisplaySolution(index);
        timer.CancelTimer();
    }

    private void DisplaySolution(int index)
    {
        if (index == question.GetCorrectAnswerIndex())
        {
            questionText.text = "정답입니다!";
            answerButtons[index].GetComponent<Image>().sprite = correctAnswerSprite;
        }
        else
        {
            questionText.text = "틀렸습니다! 정답은" + question.GetCorrectAnswer() + "입니다!";
        }
        SetButtonState(false);
    }

    private void SetDefaultButtonSprites()
    {
        foreach (GameObject obj in answerButtons)
        {
            obj.GetComponent<Image>().sprite = defaultAnswerSprite;
        }
    }

    private void SetButtonState(bool state)
    {
        foreach (GameObject obj in answerButtons)
        {
            obj.GetComponent<Button>().interactable = state;
        }
    }
}
