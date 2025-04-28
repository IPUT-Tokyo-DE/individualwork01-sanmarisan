using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour
{
    public float countdown = 5.0f;
    public TextMeshProUGUI timeText;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        timeText.text = countdown.ToString("f1");

        if (countdown <= 0)
        {
            timeText.text = "0";
            SceneManager.LoadScene("result");
        }
    }
}
