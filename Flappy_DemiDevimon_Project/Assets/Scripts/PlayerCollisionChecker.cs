using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PipeScore"))
        {
            GameManager.Instance.IncreaseScore();
        }
        else
        {
            GetComponent<PlayerAnimator>().TriggerTakeDamage();
            GameManager.Instance.EndGame();
        }
    }
}
