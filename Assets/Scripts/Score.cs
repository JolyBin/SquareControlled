using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreValue = 0;
    public Text Text;
    public List<Enemy> AllEnemies;

    public delegate void DelegateOnEndingEnemys();
    public static event DelegateOnEndingEnemys OnEndingEnemys;
    public static Score Instance;
    


    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }

    public void AddEnemy(Enemy enemy)
    {
        AllEnemies.Add(enemy);
    }

    public void RemoveEnemy(Enemy enemy)
    {
        AllEnemies.Remove(enemy);
        if(AllEnemies.Count == 0)
        {
            OnEndingEnemys?.Invoke();
        }
    }

    private void Start()
    {
        UpdateInfo();
    }

    public void SetScore(int value)
    {
        ScoreValue += value;
        UpdateInfo();
    }
    void UpdateInfo()
    {
        Text.text = ScoreValue.ToString();
    }
}
