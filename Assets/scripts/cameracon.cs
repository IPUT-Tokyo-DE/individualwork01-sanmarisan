using UnityEngine;

public class cameracon : MonoBehaviour
{
    [SerializeField] Transform player;
    public float zpoz = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = new Vector3(player.position.x, player.position.y, zpoz);
        }
        
    }
}
