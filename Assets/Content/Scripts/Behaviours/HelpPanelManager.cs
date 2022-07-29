using UnityEngine;

public class HelpPanelManager : MonoBehaviour
{
    void Update()
    {
        var getCanvasGroup = this.gameObject.GetComponent<CanvasGroup>();
        if (Input.GetKey(KeyCode.H) || Input.GetKey(KeyCode.F1))
        {
            getCanvasGroup.alpha = 1;
            getCanvasGroup.interactable = true;
        }
        else
        {
            getCanvasGroup.alpha = 0;
            getCanvasGroup.interactable = false;
        }
    }
}
