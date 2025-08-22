using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    void Loop()
    {
        int[] scores = { 90, 85, 70, 100, 60 };

        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log("score " + i + ": " + scores[i]);
        }

        foreach (int score in scores)
        {
            Debug.Log("score: " + score);
        }

        int index = 0;
        while (index < scores.Length)
        {
            Debug.Log("while¹® : scores[" + index + "] =" + scores[index]);
            index++;
        }
    }
}
