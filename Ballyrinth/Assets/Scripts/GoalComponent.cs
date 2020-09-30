using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalComponent : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public AudioSource MainMusic;
    public GameObject canvas;
    public Button playAgainBtn;
    public GameObject player1;
    public GameObject player2;
    public Text text;

    void Awake()
    {
        canvas.SetActive(false);
    }

    void OnEnable()
    {
        playAgainBtn.onClick.AddListener(() => { BtnClicked(); });
    }

    void OnTriggerEnter(Collider c)
    {
        Time.timeScale = 0;
        MusicSource.Play();
        MainMusic.Pause();
        Debug.Log(c.name);
        text.text = c.name + " won!";
        canvas.SetActive(true);             
    }

    private void BtnClicked()
    {
        Time.timeScale = 1;
        player2.transform.position = new Vector3(203.78f, 20.5f, 200.89f);
        player1.transform.position = new Vector3(204.05f, 20.5f, 223f);
        player2.transform.rotation = new Quaternion(0, 0, 0, 0);
        player1.transform.rotation = new Quaternion(0, 180, 0, 0);
        canvas.SetActive(false);
        MainMusic.Play();
        MusicSource.Stop();
    }
}
