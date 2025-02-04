using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
private float speed = 15;
    // Update is called once per frame
    void Update()
    {
      transform.Translate(speed * Time.deltaTime * Vector3.left);  
    }
}
