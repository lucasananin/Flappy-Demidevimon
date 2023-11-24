using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiMenuManager : MonoBehaviour
{
    [SerializeField] Button _startButton = null;
    [SerializeField] Button _retryButton = null;
    [Space]
    [SerializeField] TextMeshProUGUI _scoreText = null;

    private void Start()
    {
        _startButton.gameObject.SetActive(true);
        _retryButton.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        _startButton.onClick.AddListener(StartGame);
        _retryButton.onClick.AddListener(GameManager.Instance.RestartGame);
    }

    private void OnDisable()
    {
        _startButton.onClick.RemoveAllListeners();
        _retryButton.onClick.RemoveAllListeners();
    }

    private void StartGame()
    {
        _startButton.gameObject.SetActive(false);
        GameManager.Instance.StartGame();
    }

    public void ShowRetryButton()
    {
        _retryButton.gameObject.SetActive(true);
    }

    public void UpdateScoreText()
    {
        _scoreText.SetText($"{GameManager.Instance.GetScore()}");
    }
}
