using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int collectedCoins;
    public TextMeshProUGUI coinText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinText.text = collectedCoins.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddCoin()
    {
        this.collectedCoins++;
        coinText.text = collectedCoins.ToString();

        if (this.collectedCoins >= 4)
        {
            Winner();
        }
    }

    private void Winner()
    {
        SceneManager.LoadScene(2);
    }
}
