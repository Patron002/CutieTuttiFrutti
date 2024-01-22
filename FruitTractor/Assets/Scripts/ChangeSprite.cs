using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    [SerializeField] private Sprite[] sprite;
    private SpriteRenderer spriteRenderer;
    private int scoreSprite;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeSpriteDirection(int i) 
    {
        scoreSprite += i;
        if (scoreSprite == sprite.Length) 
        {
            scoreSprite = 0;
        }
        if (scoreSprite < 0) 
        {
            scoreSprite = sprite.Length - 1;
        }
        spriteRenderer.sprite = sprite[scoreSprite];
    }
}
