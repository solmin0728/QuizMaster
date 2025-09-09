using UnityEngine;

public class test : MonoBehaviour
{
    // Unity 메시지|참조 0개
    void Start()
    {
        Debug.Log("Hello, World!");
        Publisher publisher = new Publisher();
        publisher.msg += ResultProcess;
        publisher.msg += OtherProcess;

        publisher.SendMessage("추가");

        Debug.Log("작업 완료!");
    }

    // 참조 1개
    void ResultProcess(string msg)
    {
        Debug.Log($"메시지 수신: {msg}");
    }

    // 참조 1개
    void OtherProcess(string text)
    {
        Debug.Log($"다른 처리: {text}");
    }
}

// 참조 2개
public class Publisher
{
    public delegate void OnMessage(string msg);
    public event OnMessage msg;

    // 참조 1개
    public void SendMessage(string text)
    {
        Debug.Log($"ChatGPT API와 통신합니다.(로딩중)... {text}");

        msg?.Invoke(text);
    }
}
