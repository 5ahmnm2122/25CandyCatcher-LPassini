using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketMovement: MonoBehaviour
{
    
    public PlayerData playerdata;
    public int lifes = 3;

  
    public GameObject ThreeL;
    public GameObject TwoL;
    public GameObject OneL;

    public Camera cam;
    private float maxWidth;


    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        
        float hatWidth = GetComponent<Renderer>().bounds.extents.x;
        maxWidth = targetWidth.x - hatWidth;
        
    }

    
    void FixedUpdate()
    {
        Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPosition = new Vector3(rawPosition.x, -4f, 0.0f);
        float targetWidth = Mathf.Clamp(targetPosition.x, -maxWidth, maxWidth);
        targetPosition = new Vector3(targetWidth, targetPosition.y, targetPosition.z);
        Rigidbody2D rigidbody2D = new Rigidbody2D();
        GetComponent<Rigidbody2D>().MovePosition(targetPosition);
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.gameObject.tag == "GoodBall")
        {
            playerdata.playerScore += 1;
            Destroy(collision.gameObject);

        } else if (collision.gameObject.tag == "BadBall")
        {
            
            if (lifes > 0)
            {
                lifes -= 1;
                if (lifes == 2)
                {
                    ThreeL.SetActive(false);
                }
                else if (lifes == 1)
                {
                    TwoL.SetActive(false);
                } else
                {
                    ThreeL.SetActive(false);
                    TwoL.SetActive(false);
                    OneL.SetActive(false);

                    SceneManager.LoadScene("EndScene");
                }
            }
            Destroy(collision.gameObject);
        }
    }
}
