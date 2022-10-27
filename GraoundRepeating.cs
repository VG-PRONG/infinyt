using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraoundRepeating : MonoBehaviour
{

    private Controller _controller;
    
    public bool _floorinstanciado = false;

    // Start is called before the first frame update
    void Start()
    {
        _Controller = FindObjectOfType(typeof(Controller)) as Controller;
    }

    // Update is called once per frame
    void Update()
    {
        if(_floorinstanciado == false)
        {
            if(transform.position.x <= 0)
            {
                _floorinstanciado = true;
                GameObject ObjectTemporaryFloor = Instantiate(_Controller._floorPrefab);
                ObjectTemporaryFloor.transform.position = new vector3(transform.position.x + _Controller._floorsize, transform.position.y, 0);

                Debug.Log("O floor was instanciado!");
            }
        }

        if(transform.position.x < _Controller.floordestroyed) // -38
        {
           Destroy(this.GameObject);
        }
    }

    private void FixedUpdate()
    {
        MoveChao();
    }

    void MoveChao()
    {
        transform.Translate(vector2.left * _Controller._floorspeed * Time.deltaTime);
    }
}
