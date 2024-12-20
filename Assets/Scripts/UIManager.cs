using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] Animator menuAnim;
    [SerializeField] GameObject gameUI;

    public void CloseMenu()
    {
        menuAnim.SetTrigger("Close");
        gameUI.SetActive(true);
    }
}
