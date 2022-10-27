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
        _controller = FindObjectOfType(typeof(Controller)) as Controller;
    }

    // Update is called once per frame
    void Update()
    {
        if (_floorinstanciado == false)
        {
            if (transform.position.x <= 0)
            {
                _floorinstanciado = true;
                GameObject ObjectTemporaryFloor = Instantiate(_controller._floorPrefab);
                ObjectTemporaryFloor.transform.position = new Vector3(transform.position.x + _controller._floorsize, transform.position.y, 0);

                Debug.Log("O floor was instanciado!");
            }
        }

        if (transform.position.x < _controller._floordestroyed) // -38
        {
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        MoveChao();
    }

    void MoveChao()
    {
        transform.Translate(Vector2.left * _controller._floorspeed * Time.deltaTime);
    }
}
