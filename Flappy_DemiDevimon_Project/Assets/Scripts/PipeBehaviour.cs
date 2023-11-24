using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.left * GameManager.Instance.PipeSpeedMultiplier * Time.deltaTime);
    }
}
