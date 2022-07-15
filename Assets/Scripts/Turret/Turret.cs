using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject Player;
    public float TimeRange = 1.0f;
    public float AimRange = 15f;
    public float MinCosRange = 0f;
    public float MaxCosRange = Mathf.Sqrt(3) * 0.5f;
    public float RotationSpeed = 0.2f;
    
    private Transform _muzzle;
    private Vector3 _front;
    private Vector3 _distance;
    private float _disMag;
    private float _elapsedTime;
    private float _cos;
    private Vector3 _cross;

    private void Start()
    {
        _front = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        _distance = Player.transform.position - transform.position;
        _disMag = _distance.magnitude;
        _cos = Vector3.Dot(_front, _distance.normalized);
        _cross = Vector3.Cross(_front, _distance.normalized);
        
        if (!Player.activeSelf)
        {
            transform.Rotate(Vector3.up * RotationSpeed);
            return;
        }

        if (_disMag > AimRange)
        {
            transform.Rotate(Vector3.up * RotationSpeed);
            return;
        }

        if (_cos > MaxCosRange)
        {
            transform.Rotate(Vector3.up * RotationSpeed);
            return;
        }

        if (_cos < MinCosRange)
        {
            transform.Rotate(Vector3.up * RotationSpeed);
            return;
        }

        if (_cross.y > 0)
        {
            transform.Rotate(Vector3.up * RotationSpeed);
            return;
        }

        transform.LookAt(Player.transform);
        _muzzle = transform;
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= TimeRange)
        {
            _elapsedTime = 0f;

            GameObject bullet = Instantiate(BulletPrefab, _muzzle.position, _muzzle.rotation);
        }
    }
}
