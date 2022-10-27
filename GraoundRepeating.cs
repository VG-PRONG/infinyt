using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraoundRepeating : MonoBehaviour
{

    private Controller _controller;

    // Start is called before the first frame update
    void Start()
    {
        _controller = FindObjectOfType(typeof(Controller)) as Controller;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MoveChao();
    }

    void MoveChao()
    {

    }
}
