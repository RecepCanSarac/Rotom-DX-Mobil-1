using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{

    private PlayerMove _playerMove;

    private void Start()
    {
        _playerMove = GetComponent<PlayerMove>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);

            if (parmak.phase == TouchPhase.Stationary)
            {
                if (parmak.position.x > 0)
                {
                    _playerMove.Move(_playerMove.speed);
                }
                else if(parmak.position.x < 0)
                {
                    _playerMove.Move(-_playerMove.speed);
                }
            }
        }
    }
}
