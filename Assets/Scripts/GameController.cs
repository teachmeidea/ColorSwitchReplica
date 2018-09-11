using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public Transform panel;

    public Transform prevCircle;
    public GameObject circlePrefab;
    public GameObject colChangePrefab;

    public static bool isPlaying = false;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        isPlaying = true;
    }

    public void PassCircle()
    {
        Vector2 newPos = prevCircle.position;
        newPos.y += 5f;
        Vector2 newColPos = newPos;
        newColPos.y += 2.5f;
        GameObject newCircle = Instantiate(circlePrefab, newPos, Quaternion.identity);
        GameObject newColChange = Instantiate(colChangePrefab, newColPos, Quaternion.identity);
        prevCircle = newCircle.transform;
    }

    public void GameOver()
    {
        panel.gameObject.SetActive(true);
        isPlaying = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
