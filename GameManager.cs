using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    public static GameManager Instance;

    // Game state
    private bool isGamePaused = false;

    private void Awake()
    {
        // Ensure only one instance of GameManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Toggle pause when P is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isGamePaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        isGamePaused = true;
        Time.timeScale = 0f; // Stop the game time
        // Additional pause logic (e.g., show pause menu)
    }

    public void ResumeGame()
    {
        isGamePaused = false;
        Time.timeScale = 1f; // Resume the game time
        // Additional resume logic (e.g., hide pause menu)
    }

    // Additional game flow management methods can be added here
}