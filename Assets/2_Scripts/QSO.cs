using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]

public class QSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField]string question = "Áú¹®";
}
