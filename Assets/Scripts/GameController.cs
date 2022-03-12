using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject ManeagedObject;

    private void OnEnable()
    {
        Score.OnEndingEnemys += ActivateManagedObject;
    }

    private void OnDisable()
    {
        Score.OnEndingEnemys -= ActivateManagedObject;
    }

    public void ActivateManagedObject()
    {
        ManeagedObject.SetActive(true);
    }
}
