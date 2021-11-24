using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float timeRemaining = 1.0f;

    private void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining = timeRemaining + Time.deltaTime;

        }
    }

}
