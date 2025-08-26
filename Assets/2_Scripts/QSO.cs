using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]

public class QSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField]string question = "Áú¹®";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }

    public string GetAnswers(int i)
    {
        return answers[i];
    }

    public string GetCorrectAnswer()
    {
        return answers [correctAnswerIndex];
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
}
