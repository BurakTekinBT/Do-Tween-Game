using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenManager : MonoBehaviour
{
    public Transform cube;
    public Transform sphere;
    public Transform capsule;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             // Move to releated location in 3 sec
             cube.DOMove(new Vector3(4, 3, 24), 2f);

            //Move for only one direction
            cube.DOMoveX(2.4f, 2f);
            cube.DOLocalMoveY(2.4f, 2f);
            cube.DOMoveZ(2.4f, 2f);

            //Rotating the releated Vector3 in 3 sec
            capsule.DORotate(new Vector3(0, 0, -100), 3f);

            //Scale to releated scale in 5 sec
            sphere.DOScale(new Vector3(3, 3, 3), 5f);

            //Using local transform instead of global transform
            cube.DOLocalMove(new Vector3(4, 3, 24), 2f);
            capsule.DOLocalRotate(new Vector3(0, 0, -100), 2.0f).SetEase(Ease.Linear);

            capsule.DOLocalRotate(capsule.localRotation.eulerAngles + new Vector3(0, 0, -100), 2.0f).SetEase(Ease.Linear);
        }
    }
}
