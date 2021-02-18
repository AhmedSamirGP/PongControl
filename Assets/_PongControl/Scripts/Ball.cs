using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballBody;
    private PhysicsMaterial2D bouncy;
    private CircleCollider2D ballCollider;
    private TrailRenderer ballTrail;
    private Vector2 velocity;
    private int x_direction;
    [SerializeField] private EventSO ballCollisionLeft;
    [SerializeField] private EventSO ballCollisionRight;
    
    private void Awake()
    {
        SetBody();
        SetBouncy();
        SetCollider();
        SetTrail();
       
        
       
        x_direction = -1;
        var y_direction = Random.Range(0, 2) * 2 - 1;
        velocity = new Vector2(x_direction * Random.Range(10, 15), y_direction * Random.Range(5, 15));
        
    }

    
    void Start()
    {
        Spawn();
    }

   
    void Update()
    {
        
    }


    public async void Spawn()
    {
        ballTrail.emitting = false;
        ballBody.position = Vector2.zero;
        ballBody.velocity = Vector2.zero;
        await Task.Delay(500);
        var y_direction = Random.Range(0, 2) * 2 - 1;
        velocity = new Vector2(x_direction * Random.Range(10, 15), y_direction * Random.Range(5, 15));
        ballBody.velocity = velocity;
        ballTrail.emitting = true;
    }

    void SetBody()
    {
        ballBody = gameObject.AddComponent<Rigidbody2D>();
        ballBody.gravityScale = 0;

    }

    void SetBouncy()
    {
        bouncy = new PhysicsMaterial2D();
        bouncy.bounciness = 1;
        bouncy.friction = 0;
    }

    void SetCollider()
    {
        ballCollider = gameObject.AddComponent<CircleCollider2D>();
        ballCollider.sharedMaterial = bouncy;
    }

    void SetTrail()
    {
        ballTrail = gameObject.AddComponent<TrailRenderer>();
        ballTrail.startWidth = 0.5f;
        ballTrail.endWidth = 0;
        ballTrail.time = 0.07f;
        ballTrail.startColor = Color.cyan;
        ballTrail.endColor = Color.cyan;
        ballTrail.numCornerVertices = 10;
        ballTrail.numCapVertices = 10;
        ballTrail.alignment = LineAlignment.View;
        ballTrail.emitting = true;
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Left"))
        {
            ballCollisionLeft.raise();
            x_direction = 1;
            Spawn();
        }
        if (other.gameObject.CompareTag("Right"))
        {
            ballCollisionRight.raise();
            x_direction = -1;
            Spawn();
        }
    }
}
