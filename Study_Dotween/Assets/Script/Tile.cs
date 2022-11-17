using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tile : MonoBehaviour
{
    void OnMouseDown()
    {
        Player.instance.transform.DOMove(transform.position,0.5f).SetEase(Ease.InOutQuad);
    }

    void ArriveOnTile()
    {
        Player.instance.transform.DOShakeScale(5f);
    }

}
