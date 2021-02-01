using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int score = 0;
    public Text points;

    SpriteRenderer sr;
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sr.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sr.enabled = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        score++;
        points.text = score.ToString();
    }
}
