using UnityEngine;
using Image = UnityEngine.UI.Image;

public class Card : MonoBehaviour
{
    public Attack AttackValue;
    public Player player;
    public Vector2 OriginalPosition;
    Vector2 OriginalScale;
    Color originalColor;


    //
    bool isClickable = true;
    private void Start()
    {
        OriginalPosition = this.transform.position;
        OriginalScale = this.transform.localScale;
        originalColor = GetComponent<Image>().color;
    }


    //onlick card
    public void onClick()
    {
        if (isClickable)
        {
            OriginalPosition = this.transform.position;
            player.SetChosenCard(this);
            
            
            Debug.Log("Player memilih card!");
        }
    }

    //reset game.
    public void Reset()
    {
        transform.position = OriginalPosition;
        transform.localScale = OriginalScale;
        GetComponent<Image>().color = originalColor;
    }

    //
    public void SetClickable(bool value)
    {
        isClickable = value;
    }

}
