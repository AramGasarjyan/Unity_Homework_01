using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Transform shapeToMove;
    float speed = 0.1f;
    private Vector2 shapeToMoveInitial;

    private void Start()
    {
        shapeToMoveInitial = shapeToMove.position;
    }

    void Update()
    {
        //1.
        if (Vector2.Distance(transform.position, shapeToMove.position) <= 0.001)
        {
            return;
        }
        else
            transform.position = Vector2.Lerp(transform.position, shapeToMoveInitial, speed * Time.deltaTime);

        //2. Es depqum qani vor inchqan motenum ein irar etqan aveli er pakasum deltan arel em verevi tarberakov.
        //transform.position = Vector2.Lerp(transform.position, shapeToMove.position, speed * Time.deltaTime);
    }
}
