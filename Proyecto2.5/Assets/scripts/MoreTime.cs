using UnityEngine;

public class MoreTime : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ball"))
        {
            TimeCounter.Instance.IncreaseTime(1);
        }
    }
}
