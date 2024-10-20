using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGame : MonoBehaviour
{
    [SerializeField] protected int heart = 3;
    [SerializeField] protected int coin = 0;
    [SerializeField] protected int key = 1;
    [SerializeField] protected TextMeshProUGUI heartText;
    [SerializeField] protected TextMeshProUGUI coinText;
    [SerializeField] protected TextMeshProUGUI keyText;
    public GameObject gameOverObject;
    public static bool isGameOver = false;

    public AudioManager audioManager5;
    protected bool isRunning = false;

    private void Awake()
    {
        audioManager5 = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void Start()
    {
        heartText.SetText(heart.ToString());
        coinText.SetText(coin.ToString());
        keyText.SetText(key.ToString());
        isGameOver = false; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.MakeTextHeart(collision);
    }

    protected virtual void MakeTextHeart(Collider2D collision)
    {
        if (collision.CompareTag("House") || collision.CompareTag("!House") || 
            collision.CompareTag("Rock") || collision.CompareTag("People"))
        {
            Destroy(collision.gameObject);
            heart--;
            heartText.SetText(heart.ToString());
            if (heart == 0)
            {
                audioManager5.PlaySFX(audioManager5.gameoverClip);
                gameOverObject.SetActive(true);
                isGameOver = true;
            }
        }
        if (collision.CompareTag("Coin"))
        {
            coin++;
            Destroy(collision.gameObject);
            coinText.SetText(coin.ToString());
        }
        if (collision.CompareTag("Key"))
        {
            key--;
            Destroy(collision.gameObject);
            keyText.SetText(key.ToString());
        }
        if (coin == 10 || coin == 20 || coin == 30 || coin == 40 || coin == 50)
        {
            heart++;
            heartText.SetText(heart.ToString());
        }
        if (collision.CompareTag("Bomp"))
        {
            heart = 0;
            heartText.SetText(heart.ToString());
            gameOverObject.SetActive(true);
            audioManager5.PlaySFX(audioManager5.gameoverClip);
            isGameOver = true ;
        }
    }

}
