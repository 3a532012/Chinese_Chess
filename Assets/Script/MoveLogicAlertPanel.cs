using UnityEngine;
using UnityEngine.UI;

public class MoveLogicAlertPanel : MonoBehaviour
{
    public Image _moveLogicAlertPanel;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMoveLogicOnClick()
    {
        _moveLogicAlertPanel.gameObject.SetActive(true);
    }
    public void HideRedFirstAlertOnClick()
    {
        _moveLogicAlertPanel.gameObject.SetActive(false);
    }
}
