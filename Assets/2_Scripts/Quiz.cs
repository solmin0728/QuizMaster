using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QSO question;
    [SerializeField] TextMeshProUGUI[] answerTextArr;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    void Start()
    {
        questionText.text = question.GetQuestion();

        for (int i = 0; i < answerTextArr.Length; i++)
        {
            TextMeshProUGUI buttenText = answerTextArr[i].GetComponentInChildren<TextMeshProUGUI>();
            buttenText.text = question.GetAnswers(i);
        }
    }

    public void OnAnswerButtenClicked(int index)
    {
        //answerButtons[question.GetCorrectAnswerIndex()].GetComponent<Image>().sprite = correctAnswerSprite;

        if (index == question.GetCorrectAnswerIndexInt())
        {
            questionText.text = "정답입니다!";
        }
        else
        {
            questionText.text = "틀렸습니다! 정답은 " + question.GetCorrectAnswerIndex() + "입니다.";
        }
    }
}
