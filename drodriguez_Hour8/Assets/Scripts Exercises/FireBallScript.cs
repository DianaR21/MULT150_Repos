using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireBall();
        print("Player health:" + x);

        int y = TakeDamageFromFireball(25);
        print ("Player health: " + y)

        int z = TakeDamageFromFireball(30, 50);
        print ("Player health: " + z)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
