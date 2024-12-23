using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Game Manager
    public static GameManager Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    #endregion

    public PauseMenu pauseMenu;

    public void Start()
    {
        Resume();
        // Memastikan EnemySpawner tidak ada di scene utama (scene index 0)
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            DestroyEnemySpawner();
        }        
    }
    
    public bool isPaused;
    
    public void ChangeScene(int sceneIndex)
    {   
        SceneManager.LoadScene(sceneIndex);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

    private void DestroyEnemySpawner()
    {
        // Mencari semua objek EnemySpawner di scene dan menghancurkannya
        EnemySpawner[] enemySpawners = FindObjectsOfType<EnemySpawner>();
        foreach (EnemySpawner spawner in enemySpawners)
        {
            Destroy(spawner.gameObject);
        }
    }
}