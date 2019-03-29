using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Transform player;
    public float speed = 10f;

    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
            mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;

            mousePos.y = mousePos.y > 4.5f ? 4.5f : mousePos.y;
            mousePos.y = mousePos.y < -4.5f ? -4.5f : mousePos.y;

            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, mousePos.y), speed * Time.deltaTime);
        }
    }


}
