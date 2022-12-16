using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject CardCanvas;
    public GameObject Canvas;
    public GameObject Card;
    public GameObject Deck;
    public SpriteRenderer deck;
    public Sprite card1;
    public Sprite card2;
    public Sprite card3;
    public Sprite card4;
    // Start is called before the first frame update
    void Start()
    {
        //deck = Deck.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame() {
        SceneManager.LoadScene("SolitaireGame");
    }

    public void ChooseCards() {
        CardCanvas.SetActive(true);
        Canvas.SetActive(false);
    }

    public void Card1() {
        CardCanvas.SetActive(false);
        Canvas.SetActive(true);
        Card.GetComponent<UpdateSprite>().cardBack = card1;
        //deck.sprite = card1;
    }
    public void Card2() {
        CardCanvas.SetActive(false);
        Canvas.SetActive(true);
        Card.GetComponent<UpdateSprite>().cardBack = card2;
        //deck.sprite = card2;
    }
    public void Card3() {
        CardCanvas.SetActive(false);
        Canvas.SetActive(true);
        Card.GetComponent<UpdateSprite>().cardBack = card3;
        //deck.sprite = card3;
    }
    public void Card4() {
        CardCanvas.SetActive(false);
        Canvas.SetActive(true);
        Card.GetComponent<UpdateSprite>().cardBack = card4;
        //deck.sprite = card4;
    }

}
