using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;

    public TMP_Text collectiblesNumberText;
    public TMP_Text totalCollectiblesNumberText;

    private int collectiblesNumber;
    private int totalCollectiblesNumber;

    void Start()
    {
        totalCollectiblesNumber = transform.childCount;
        totalCollectiblesNumberText.text = totalCollectiblesNumber.ToString();
    }


    void Update()
    {
        if (transform.childCount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void addCollectible()
    {
        audioSource.Play();
        collectiblesNumber++;
        collectiblesNumberText.text = collectiblesNumber.ToString();
    }

}
