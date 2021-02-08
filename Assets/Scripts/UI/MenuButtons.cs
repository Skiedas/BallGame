using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class MenuButtons : MonoBehaviour
{
    private string Game = "Game";

    [SerializeField] private Button _playButton;
    [SerializeField] private Button _aboutButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _backButton;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _playButton.onClick.AddListener(OnPlayButtonClcik);
        _aboutButton.onClick.AddListener(OnAboutButtonClcik);
        _exitButton.onClick.AddListener(OnExitButtonClcik);
        _backButton.onClick.AddListener(OnBackButtonClick);
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(OnPlayButtonClcik);
        _aboutButton.onClick.RemoveListener(OnAboutButtonClcik);
        _exitButton.onClick.RemoveListener(OnExitButtonClcik);
        _backButton.onClick.RemoveListener(OnBackButtonClick);
    }

    private void OnPlayButtonClcik()
    {
        SceneManager.LoadScene(Game);
    }

    private void OnAboutButtonClcik()
    {
        _animator.Play(AnimatorUIController.States.AboutButtonClick);
    }

    private void OnExitButtonClcik()
    {
        Application.Quit();
    }

    private void OnBackButtonClick()
    {
        _animator.Play(AnimatorUIController.States.BackButtonClick);
    }
}

public static class AnimatorUIController
{
    public static class States
    {
        public const string AboutButtonClick = nameof(AboutButtonClick);
        public const string BackButtonClick = nameof(BackButtonClick);
    }
}
