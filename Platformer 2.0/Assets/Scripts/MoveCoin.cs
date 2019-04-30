using UnityEngine;

public class MoveCoin : MonoBehaviour
{
    public float coinSpeed = 5f;

    //public Side side = Side.Left;

    /*public enum Side{
        Left=1,
        Right,
        Up,
        Down
    }*/

    void Start()
    {
        /*if (transform.position.x == -3)
        {
            side = Side.Left;
        }
        else
        {
            side = Side.Right;
        }
        if (transform.position.y == 6)
        {
            side = Side.Up;
        }*/
    }

    private void Update()
    {
        /*if (transform.position.x < -3.5f)
            Destroy(gameObject);
        if (transform.position.x > 3.5f)
            Destroy(gameObject);*/
        if (transform.position.y < -6f)
            Destroy(gameObject);
        /*switch (side)
        {
            case Side.Left: transform.position += new Vector3(coinSpeed * Time.deltaTime, 0, 0);  break;
            case Side.Right: transform.position -= new Vector3(coinSpeed * Time.deltaTime, 0, 0); break;
            case Side.Up: transform.position -= new Vector3(0, coinSpeed * Time.deltaTime,0); break; 
        }*/
        transform.position -= new Vector3(0, coinSpeed * Time.deltaTime, 0);
    }
}
