using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Start()
    {
        Score.Instance.AddEnemy(this);
    }
    public void Die()
    {
        Destroy(gameObject, 0.1f);
        Score.Instance.RemoveEnemy(this);
    }
}
