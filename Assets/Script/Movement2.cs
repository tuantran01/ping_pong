using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    private void playerMove()
    {
        float y = Input.GetAxis("Vertical2");
        Vector3 movement = new Vector3(0f, y , 0f);
        transform.position += movement * speed * Time.deltaTime;
    }
}
