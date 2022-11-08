using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI UIScore;
    [SerializeField] private TextMeshProUGUI UITime;
    private float hp = 3;
    private float score = 0;
    private float time = 5;
    public float HP => hp;
    public float Score => score;
    public float Time => time;
    void Start()
    {
        UIScore.text = Score.ToString("Score: " + Score);
        UITime.text = Time.ToString("0:00 " + time);
    }

    public void IncreaseScore(float plus)
    {
        score += plus;
        UIScore.text = Score.ToString("Score: " + Score);
    }

    public void IncreaseTime(float plus)
    {
        time += plus;
        UITime.text = time.ToString("0:00 " + time);
    }
}
