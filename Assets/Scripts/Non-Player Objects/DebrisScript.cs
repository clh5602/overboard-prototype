using UnityEngine;

/* Andrew Black
 * 2/16
 * DebrisScript handles the behavior for the Debris. Notably this is the bobbing effect to emulate
 * the sensation of the ocean
 */

public class DebrisScript : MonoBehaviour
{

    private int frameSwitchCount = 500;
    private float increment = 0.000085f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % frameSwitchCount != 0)
        {
            
            Vector3 currentPosition = this.transform.position;
            currentPosition.y += increment;
            this.transform.position = currentPosition;
        }
        else
        {
            increment *= -1;
        }
    }

    public void FrameSwitchIncrement(double incrementer)
    {
        this.frameSwitchCount += 50 * (int)incrementer;
    }
}
