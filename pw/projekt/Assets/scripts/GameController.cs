using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
	public GameObject target;
    public float minX = 20f;
    public float maxX = 980f;
    public float minZ = 20f;
    public float maxZ = 980f;
    public int tohit = 25;
    public Text counter;
    public Text startCountdown;
    public Text timer;
    public Text win;
    public GameObject restartButton;
    private Boolean gameStarted = false;
    private static List<GameObject> targets = new List<GameObject>();
    private float seconds = 0f;
    private float minutes = 0f;
    private float hours = 0f;
    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        for (int i = 0; i < tohit; i++)
        {
            GameObject newtarget = Instantiate(target, new Vector3(UnityEngine.Random.Range(minX,maxX),15f,UnityEngine.Random.Range(minZ,maxZ)), Quaternion.identity);
            newtarget.GetComponent<Transform>().parent = transform;
            targets.Add(newtarget);
        }
        win.enabled = false;

        counter.text = (tohit - targets.Count) + " / " + tohit;
        timer.text = UpdateTimer();
        restartButton.SetActive(false);
        StartCoroutine(StartCountdownCoroutine());
    }

    // Update is called once per frame
    void Update () {
        if (gameStarted)
        {
            seconds += Time.deltaTime;
            timer.text = UpdateTimer();
        }
	}

    IEnumerator StartCountdownCoroutine()
    {
        startCountdown.enabled = true;
        for(int i = 3; i > 0; i--)
        {
            startCountdown.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
        startCountdown.text = "Start!";
        yield return new WaitForSeconds(0.5f);
        startCountdown.enabled = false;
        gameStarted = true;
    }

	public void hit(GameObject hitted)
    {
        targets.Remove(hitted);
        Destroy(hitted);
        counter.text = (tohit - targets.Count) + " / " + tohit;
        if (targets.Count < 1)
        {
            EndOfGame();
        }
    }
    public Boolean IsGameStarted()
    {
        return gameStarted;
    }
    private String UpdateTimer()
    {
        if (seconds >= 60f)
        {
            seconds -= 60f;
            minutes += 1f;
        }
        if (minutes >= 60f)
        {
            minutes -= 60f;
            hours += 1f;
        }
        return String.Format("{0:00.}", hours) + ":"+String.Format("{0:00.}", minutes)+":" +String.Format("{0:00.00}", seconds);
    }
    private void EndOfGame()
    {
        gameStarted = false;
        win.enabled = true;
        win.text = "Gratulacje!\nWygrałeś!\nTwój czas: " + UpdateTimer();
        Cursor.lockState = CursorLockMode.None;
        restartButton.GetComponentInChildren<Text>().text = "Zagraj ponownie";
        restartButton.SetActive(true);
        GetComponent<AudioSource>().Play();
    }
}
