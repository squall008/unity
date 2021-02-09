using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Dotween1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMove(new Vector3(10f, 0f, 0f), 5f)
            .SetLoops(3, LoopType.Yoyo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
