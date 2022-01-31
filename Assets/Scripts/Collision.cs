using UnityEngine;

public class Collision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Debug.Log("With Ground Collided");
            Destroy(collision.gameObject);
        } 
    }
}
