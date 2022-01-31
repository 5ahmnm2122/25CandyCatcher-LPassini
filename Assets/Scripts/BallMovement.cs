using UnityEngine;

public class BallMovement : MonoBehaviour
{
    
    public float ballSpeed = 2f;

    private void Update ()
    {
        Vector2 movement = new Vector2 (UnityEngine.Random.Range(0, -1), UnityEngine.Random.Range(-2, -5));
        transform.Translate(movement * ballSpeed * Time.deltaTime);
    }
}
