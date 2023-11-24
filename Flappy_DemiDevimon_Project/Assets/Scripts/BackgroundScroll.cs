using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] RawImage _rawImage = null;
    [SerializeField] float _x = -1f;
    [SerializeField] bool _canMove = true;

    private void OnEnable()
    {
        GameManager.onGameOver += StopMoving;
    }

    private void OnDisable()
    {
        GameManager.onGameOver -= StopMoving;
    }

    private void StopMoving()
    {
        _canMove = false;
    }

    private void Update()
    {
        if (!_canMove) return;

        _rawImage.uvRect = new Rect(_rawImage.uvRect.position + new Vector2(_x, 0) * Time.deltaTime, _rawImage.uvRect.size);
    }
}
