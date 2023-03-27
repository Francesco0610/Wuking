using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        

    }


 
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
         
        Vector2 pos = transform.position;
       
        pos.x += speed * h * Time.deltaTime;
        pos.y += speed * v * Time.deltaTime;

        transform.position = pos;
        
    }
}
