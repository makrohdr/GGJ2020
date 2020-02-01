using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float Velocidad = 2.5f;

    private Rigidbody2D _rigidbody;
    private Animator _animator;

    public Vector2 _movimiento;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float MovX = Input.GetAxis("Horizontal");
        //_movimiento = new Vector2(MovX, 0f);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 vector = new Vector2(h, v);

        GetComponent<Rigidbody>().AddForce(vector * Velocidad * Time.deltaTime);
    }
}
