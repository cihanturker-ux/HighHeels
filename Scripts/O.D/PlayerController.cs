using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    
    public static PlayerController instance;
    public Animator _animator;
    
    [SerializeField] float horizontalConstantSpeed = 0.05f;

    float xPosition;
    Rigidbody rb;
    float distanceBetweenTouches = 0;
    [SerializeField] float borderOfRoad = 2.14f;
    
    
    //mobil
    public bool _isRight;
    public bool _isLeft;
    public bool _isFirstMove;
    public bool _planeMove;
    private float _touchCount;
    private Touch _isTouch;
    public float _touchXPosTwo;
    public float _touchXPosFirst;

    private void Awake()
    {
        instance = this;
        _isRight = false;
        _isFirstMove = false;
        _isLeft = false;
        rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        MoveHorizontalWithPc();
        MoveHorizontalMobile();
    }

    private void MoveHorizontalMobile()
    {
        _touchCount = Input.touchCount;
        if (_touchCount > 0)
        {
            _isTouch = Input.GetTouch(0);
            if (_isTouch.phase == TouchPhase.Began)
            {
                _touchXPosFirst = Input.mousePosition.x;
                _isFirstMove = true;
            }
            else if (_isTouch.phase == TouchPhase.Moved)
            {
                // Dokunma Devam ediyor parmagını hareket ettiriyor.
                // X konumunu algıla
                _touchXPosTwo = Input.mousePosition.x;
                if (_touchXPosFirst > _touchXPosTwo)
                {
                    // Sola gidiyor.
                    _isRight = false;
                    _isLeft = true;
                    transform.position -= new Vector3(horizontalConstantSpeed, 0, 0);
                }
                else if (_touchXPosFirst < _touchXPosTwo)
                {
                    // Saga gidiyor.
                    _isLeft = false;
                    _isRight = true;
                    transform.position += new Vector3(horizontalConstantSpeed, 0, 0);
                }
            }
            else if (_isTouch.phase == TouchPhase.Ended)
            {
                // Elini çekti
                _isLeft = false;
                _isRight = false;
            }
        } 
    }
    
    
    private void MoveHorizontalWithPc()
    {
        xPosition = transform.localPosition.x;
       // print(xPosition);
        distanceBetweenTouches = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(xPosition > -borderOfRoad)
            {
                transform.position -= new Vector3(horizontalConstantSpeed, 0, 0);
            }
        } 
        else if(Input.GetKey(KeyCode.RightArrow)){
            if(xPosition < borderOfRoad)
            {
                transform.position += new Vector3(horizontalConstantSpeed, 0, 0);
            }
           
        }
    }
    

}
