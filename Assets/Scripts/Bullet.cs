using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 target = Vector3.zero;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target == Vector3.zero) return;
        transform.position += target.normalized * Time.deltaTime * speed;
        

    }
}
