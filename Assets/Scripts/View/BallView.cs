using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallView : MonoBehaviour {
    private BallController _ballController;
    private BrickController _brickController;

    void Start() {
        _ballController = GetComponent<BallController>();
        _brickController = GetComponent<BrickController>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        string tag = collision.gameObject.tag;

        if (tag == "Enemy") {
            BrickView _brickView = collision.gameObject.GetComponent<BrickView>();
            _brickView.PerformTakeDamage(1f);
        }
        
        if (tag == "Player") {
            _ballController.PerfectAngleReflect(collision);
        } else {
            _ballController.PerfectAngleReflect(collision);
        }
    }

}
