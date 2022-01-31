using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
   
    [SerializeField]
    private GameObject[] ball;

 
    public float xMin = -7.48f;
    public float xMax = 7.5f;

    public float posY = 5;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Ball());
    }
    
    IEnumerator Ball ()
    {
        yield return new WaitForSeconds(1);

        while (true)
        {
            Vector3 ballPos = new Vector3(Random.Range(xMin, xMax), posY, gameObject.transform.position.z);
            GameObject.Instantiate(ball[Random.Range(0, ball.Length)], ballPos, Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(0f, 1f));
        }
    }
}
