using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private PlayerModel _playerModel;
    private Transform _playerTransform;

    void Start() {
        _playerModel = GetComponent<PlayerModel>();
        _playerTransform = GetComponent<Transform>();
    }

    public void Move(float horizontal) {
        float positionHorizontal = _playerTransform.position.x;
        if ((positionHorizontal < 1.38f && horizontal > 0f) || (positionHorizontal > -1.38f && horizontal < 0f)) {
            _playerTransform.Translate(horizontal * _playerModel.Speed, 0f, 0f);
        }

        if (positionHorizontal < -1.38f) {
            _playerTransform.Translate(0.05f * _playerModel.Speed, 0f, 0f);
        }
    }
}
