using UnityEngine;
using TMPro;

public class EventsUI : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private TextMeshProUGUI distanceText;
    private string defaultText = "Distance to Enemy";

    #endregion

    private void Awake()
    {
        InitializeText();
    }

    private void InitializeText()
    {
        EventsGameManager.OnEnterKeyPressed += (distanceText.text = defaultText);
    }

    private void UpdateText()
    {
        EventsGameManager.OnEscapeKeyPressed +=()
        {
            float distance = EventsPlayerController.Instance.DistanceToEnemy();
            distanceText.text = distance.ToString("F2");
        }
    }
}
