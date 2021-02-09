using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class aktoji : MonoBehaviour
{

    public Ease Ease_Type;
    RectTransform rect;



    void Start()
    {

        rect = GetComponent<RectTransform>();
        Sequence seq = DOTween.Sequence();
        
        seq.Append(
            rect.DOScale(new Vector3(0, 0, 0),
            1.5f)
            .SetEase(Ease_Type));


        seq.Append(
           rect.DOScale(new Vector3(2, 2, 0),
           1.5f)
           .SetEase(Ease_Type)
        .SetDelay(2.0f));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
