using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeController : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    [SerializeField] private PlayerMove playermove;
    [SerializeField] private ChangeSprite changesprite;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (eventData.delta.x > 0)
        {
            playermove.ChangeMoveRigthe();
            changesprite.ChangeSpriteDirection(1);
        }
        else 
        {
            playermove.ChangeMoveLeft();
            changesprite.ChangeSpriteDirection(-1);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }
}
