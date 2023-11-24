using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : TimeUpdater
{
    [Space]
    [SerializeField] PipeBehaviour _pipePrefab = null;
    [SerializeField] float _yMinRange = -2f;
    [SerializeField] float _yMaxRange = 2f;

    public override void UpdateValues()
    {
        if (!GameManager.Instance.IsPlaying()) return;

        var _viewportRightLimit = Camera.main.ViewportToWorldPoint(Vector3.right);
        Vector2 _position = _viewportRightLimit;
        _position.x += 1;
        _position.y = Random.Range(_yMinRange, _yMaxRange);
        Instantiate(_pipePrefab, _position, Quaternion.identity, null);
    }
}
