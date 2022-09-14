using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spritechange : MonoBehaviour
{
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    public int currentSprite;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeTheDamnSprite();
           
        }
    }

    public void ChangeTheDamnSprite()
    {
        spriteRenderer.sprite = spriteArray[currentSprite];
        currentSprite++;
        if (currentSprite >= spriteArray.Length)
        {
            currentSprite = 0;
        }
    }
    

   
}

        
