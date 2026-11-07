using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject controlsPanel;
    [SerializeField] private Button controlsButton;
    [SerializeField] private Button backButton;

    private void Update()
    {
        if (controlsPanel.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            ShowMainMenu();
        }
    }

    public void ShowControls()
    {
        mainPanel.SetActive(false);
        controlsPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(backButton.gameObject);
    }

    public void ShowMainMenu()
    {
        controlsPanel.SetActive(false);
        mainPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(controlsButton.gameObject);
    }
}
