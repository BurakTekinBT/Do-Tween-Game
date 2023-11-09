using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenManager : MonoBehaviour
{
    public Transform cube;
    public Transform sphere;
    public Transform capsule;
    public Ease moveEase;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            #region DOTween Transform

            #region Move
            //Move cube to Vector zero on Global transformm in 3 seconds
            cube.DOMove(Vector3.zero, 3f);
            //Move cube to x: 9, y:3, z: -11 on local transformm in 2 seconds
            cube.DOLocalMove(new Vector3(9, 3, -11), 2f);
            //Move cube to only releated position for 2.4 in 2 seconds
            cube.DOMoveX(2.4f,2f);
            cube.DOLocalMoveX(2.4f, 2f);
            cube.DOMoveY(2.4f, 2f);
            cube.DOLocalMoveY(2.4f, 2f);
            cube.DOMoveZ(2.4f, 2f);
            cube.DOLocalMoveZ(2.4f, 2f);
            #endregion

            #region Rotate
            //Rotate capsule to x: 0, y: 0, z: -100 on global rotate in 3 seconds
            capsule.DORotate(new Vector3(0, 0, -100), 3f);
            //Rotate capsule to x: 0, y: 0, z: -100 on local rotate in 3 seconds
            capsule.DOLocalRotate(new Vector3(0, 0, -100), 3f);
            #endregion

            #region Scale
            //Scale sphere to x:3, y:3, z:3 scale in 5 sec
            sphere.DOScale(new Vector3(3, 3, 3), 5f);
            //Scale sphere to only releated scale in 4 sec
            sphere.DOScaleX(3f, 4f);
            sphere.DOScaleY(3f, 4f);
            sphere.DOScaleZ(3f, 4f);
            #endregion

            #endregion Transform Section



            #region DOTWeen Behaviours

            #region From
            //Scale to current scale from zero scale in 2 sec. Current is the target scale.
            sphere.DOScale(Vector3.zero, 2f).From();
            cube.DOMove(Vector3.zero, 3f).From();
            capsule.DORotate(new Vector3(0, 0, -100), 3f).From();

            #endregion

            #region Ease

            cube.DOMoveX(3.31f, 1f).SetEase(moveEase);
            capsule.DOLocalRotate(new Vector3(0, 0, -100), 2.0f).SetEase(Ease.Linear);

            #endregion

            #region Loop

            #endregion

            #endregion

            /*
            //3.behavior loop
            cube.DOMoveX(0f,1f).SetLoops(2);
            cube.DOMoveX(2f,2f).SetLoops(-1, LoopType.Incremental);
            cube.DOMoveX(2f, 2f).SetLoops(-1, LoopType.Yoyo);
            cube.DOMoveX(2f, 2f).SetLoops(-1, LoopType.Restart);

            */

        }
    }
}
