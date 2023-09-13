using UnityEngine;
using UnityEngine.UI;       // Unity-UI�� ����ϱ� ���� ������ ���ӽ����̽�
using UnityEngine.Events;   // UnityEvent ���� API�� ����ϱ� ���� ������ ���ӽ����̽�

public class UIManager : MonoBehaviour
{
    // ��ư�� ������ ����
    public Button startButton;
    public Button optionButton;
    public Button shopButton;

    private UnityAction action;

    void Start()
    {
        // UnityAction�� ����� �̺�Ʈ ���� ���
        action = () => OnButtonClick(startButton.name);
        startButton.onClick.AddListener(action);

        // ���� �޼��带 Ȱ���� �̺�Ʈ ���� ���
        optionButton.onClick.AddListener(delegate { OnButtonClick(optionButton.name); });

        // ���ٽ��� Ȱ���� �̺�Ʈ ���� ���
        shopButton.onClick.AddListener(() => OnButtonClick(shopButton.name));
    }

    public void OnButtonClick(string msg)
    {
        Debug.Log($"Click Button : {msg}");
    }
}