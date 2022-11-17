using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    private BallModel _ballModel;
    private Rigidbody2D _ballRigibody;

    void Start() {
        _ballModel = GetComponent<BallModel>();
        _ballRigibody = GetComponent<Rigidbody2D>();

        SetRigibodyVelocity();
    }

    public void AngleChange(Vector2 direction) {
        _ballModel.Direction = direction;
        SetRigibodyVelocity();
    }

    private void SetRigibodyVelocity() {
        _ballRigibody.velocity = _ballModel.Direction * _ballModel.Speed * _ballModel.Power;
    }

    public void PerfectAngleReflect(Collision2D collision) {
        Vector2 direction = Vector2.Reflect(_ballModel.Direction, collision.contacts[0].normal);
        AngleChange(direction);
    }

    public void CalcBallAngleReflect(Collision2D collision) {
        float playerPixels = 120f;

        float unitScaleHalfPlayerPixels = playerPixels / 2 / 100;

        float scaleFactorPut1Dot180range = 180 / playerPixels;

        float angleDegUnityScale = ((collision.transform.position.x - transform.position.x) 
        + unitScaleHalfPlayerPixels) * scaleFactorPut1Dot180range;
    }
}
