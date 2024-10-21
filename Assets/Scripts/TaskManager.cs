using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskManager : MonoBehaviour
{
    //=================
    //===Vars
    //=================

    [Header("Goal")]
    [SerializeField] private int goalRequiredCount = 3;
    private int goalCurrentCount;

    [Header("UI")]
    [SerializeField] private GameObject uiHintPanel;
    [SerializeField] private GameObject uiVictoryPanel;
    [SerializeField] private TMP_Text   uiGoalsText;

    //=================
    //===MonoBehaviour
    //=================

    private static TaskManager _instance;
    public static TaskManager Instance => _instance;

    private void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        ResetUI();
    }

    //=================
    //===Task
    //=================

    public void RestartTask()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResetUI()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(goalCurrentCount.ToString());
        builder.Append("/");
        builder.Append(goalRequiredCount.ToString());
        uiGoalsText.text = builder.ToString();
    }

    //=================
    //===Goals
    //=================

    public void IncGoal()
    {
        //Counter
        goalCurrentCount++;

        //UI
        ResetUI();
        if (goalCurrentCount == goalRequiredCount)
        {
            uiHintPanel.SetActive(false);
            uiVictoryPanel.SetActive(true);
        }
    }

    public void DecGoal()
    {
        //Counter
        goalCurrentCount--;

        //UI
        ResetUI();
    }
}
