using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverPanel : MonoBehaviour
{
    private const string Menu = "Menu";

    [SerializeField] private Ball _ball;
    [SerializeField] private Button _againButton;
    [SerializeField] private Button _menuButton;

    private CanvasGroup _group;

    private void Start()
    {
        _group = GetComponent<CanvasGroup>();
    }

    private void OnEnable()
    {
        _againButton.onClick.AddListener(OnAgainButtonClick);
        _menuButton.onClick.AddListener(OnMenuButtonClick);
    }

    private void OnDisable()
    {
        _againButton.onClick.RemoveListener(OnAgainButtonClick);
        _menuButton.onClick.RemoveListener(OnMenuButtonClick);
    }

    public void SetActive(bool state)
    {
        if(state == true)
        {
            _group.alpha = 1;
            _group.interactable = true;
            _group.blocksRaycasts = true;
            Time.timeScale = 0;
        }
        else if (state == false)
        {
            _group.alpha =0;
            _group.interactable = false;
            _group.blocksRaycasts = false;
            Time.timeScale = 1;
        }
    }

    private void OnAgainButtonClick()
    {
        _ball.ResetBall();
        SetActive(false);
    }

    private void OnMenuButtonClick()
    {
        SceneManager.LoadScene(Menu);
        SetActive(false);
    }
}
