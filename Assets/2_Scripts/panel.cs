using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class panel : MonoBehaviour
{
    public GameObject Panel;
    public TMP_Text Text;

    public void OnCategoryButtonClick(string categoryName)
    {
        Panel.SetActive(true);   // 패널 보이기
        Text.text = $"{categoryName}을(를) 선택하시겠습니까?"; // 문구 변경
    }

    public void OnConfirmYes()
    {
        Debug.Log("카테고리 선택 완료!");
        Panel.SetActive(false);
        // 여기에 해당 카테고리로 넘어가는 코드 추가 가능
    }

    public void OnConfirmNo()
    {
        Panel.SetActive(false);
    }
}
