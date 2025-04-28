using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int Sco = 0;
    public GameObject score_object = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("main");
        }
    }

    public void AddScore(int value)
    {
        Sco += value;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        TextMeshProUGUI score_text = score_object.GetComponent<TextMeshProUGUI>();
        score_text.text = "SCORE" + Sco.ToString();

    }
    public static int getscore()
    {
        return Sco;
    }
}

