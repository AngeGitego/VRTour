using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RoomManager : MonoBehaviour
{
    [Header("Rooms Setup")]
    public GameObject[] rooms;
    private int currentRoomIndex = 0;

    [Header("UI Elements")]
    public Text roomText;
    public Button nextButton;
    public Button previousButton;

    [Header("Room Descriptions")]
    [TextArea(2, 5)]
    public string[] roomDescriptions;

    [Header("Outro Scene")]
    public string outroSceneName = "OutroScene";

    [Header("Fade Settings")]
    public FadeController fadeController;

    void Start()
    {
        nextButton.onClick.AddListener(NextRoom);
        previousButton.onClick.AddListener(PreviousRoom);

        ShowRoom(currentRoomIndex);
    }

    public void ShowRoom(int index)
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i].SetActive(false);
        }

        rooms[index].SetActive(true);

        if (roomText != null && roomDescriptions.Length > index)
            roomText.text = roomDescriptions[index];

        previousButton.gameObject.SetActive(index > 0);

        if (index == rooms.Length - 1)
            nextButton.GetComponentInChildren<Text>().text = "End Tour";
        else
            nextButton.GetComponentInChildren<Text>().text = "Next Room";
    }

    public void NextRoom()
    {
        if (currentRoomIndex < rooms.Length - 1)
        {
            StartCoroutine(SwitchRoomWithFade(currentRoomIndex + 1));
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(outroSceneName);
        }
    }

    public void PreviousRoom()
    {
        if (currentRoomIndex > 0)
        {
            StartCoroutine(SwitchRoomWithFade(currentRoomIndex - 1));
        }
    }

    private IEnumerator SwitchRoomWithFade(int newIndex)
    {
        yield return StartCoroutine(fadeController.FadeOut());

        currentRoomIndex = newIndex;
        ShowRoom(currentRoomIndex);

        yield return StartCoroutine(fadeController.FadeIn());
    }
}
