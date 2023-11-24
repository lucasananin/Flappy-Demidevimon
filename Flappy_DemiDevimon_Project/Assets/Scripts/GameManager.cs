using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [Space]
    [SerializeField] UiMenuManager _uiMenuManager = null;
    [SerializeField] float _pipeSpeedMultiplier = 1f;
    [SerializeField] bool _isPlaying = false;
    [Space]
    [SerializeField] int _playerScore = 0;
    [SerializeField] float _timeScale = 1;

    public float PipeSpeedMultiplier { get => _pipeSpeedMultiplier; private set => _pipeSpeedMultiplier = value; }

    public static Action onGameOver = null;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (_isPlaying)
        {
            _timeScale += Time.deltaTime * 0.01f;
            Time.timeScale = _timeScale;
        }
    }

    public void StartGame()
    {
        _isPlaying = true;
        AudioManager.Instance.PlayMusic();
    }

    public void EndGame()
    {
        _isPlaying = false;
        _pipeSpeedMultiplier = 0;
        _uiMenuManager.ShowRetryButton();
        AudioManager.Instance.StopMusic();
        AudioManager.Instance.PlayGameOverSfx();

        onGameOver?.Invoke();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        AudioManager.Instance.StopGameOverSfx();
    }

    public void IncreaseScore()
    {
        _playerScore++;
        _uiMenuManager.UpdateScoreText();
        AudioManager.Instance.PlayScoreSfx();
    }

    public int GetScore()
    {
        return _playerScore;
    }

    public bool IsPlaying()
    {
        return _isPlaying;
    }
}
