using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySorting : MonoBehaviour
{
    public EnemyManager enemyManager;
    List<EnemyAbstract> sortEnemies = new();

    protected void Start()
    {
        Invoke(nameof(this.Sorting), 2f);

    }

    protected void Sorting()
    {
        this.sortEnemies = new List<EnemyAbstract>(this.enemyManager.GetEnemies());
        this.PrintEnemiesList(this.sortEnemies);
        this.SelectionSort(this.sortEnemies);
        Debug.Log("=====dd=========");
        this.PrintEnemiesList(this.sortEnemies);
    }
    void SelectionSort(List<EnemyAbstract> enemies)
    {



        for (int i = 0; i < enemies.Count - 1; i++)
        {

            int minIndex = i;
            for (int j = i + 1; j < enemies.Count; j++)
            {
                if (enemies[j].Health < enemies[minIndex].Health)
                {
                    minIndex = j;
                }
            }

            EnemyAbstract temp = enemies[minIndex];
            enemies[minIndex] = enemies[i];
            enemies[i] = temp;
        }
    }

    void PrintEnemiesList(List<EnemyAbstract> enemies)
    {
        foreach (EnemyAbstract enemy in enemies)
        {
            Debug.Log(enemy.name + "- HP " + enemy.Health);
        }
    }
}
