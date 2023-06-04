using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] public GameObject MainMenu;
    [SerializeField] public GameObject Autorization;
    [SerializeField] public GameObject Scenes;
    [SerializeField] public GameObject Modes;
    [SerializeField] public GameObject PLAYGAME;
    [SerializeField] public GameObject complexity;
    [SerializeField] public TMP_Text text;


    public void Start()
    {
        //PLAYGAME.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void LevelSelection()
    {
        MainMenu.SetActive(false);
        Autorization.SetActive(true);
    }
    public void LevelSelectionON()
    {
        MainMenu.SetActive(true);
        Modes.SetActive(false);
    }
    public void LevelSelectionTrainingMode()
    {
        Modes.SetActive(false);
        Scenes.SetActive(true);
        complexity.SetActive(false);
    }
    public void LevelSelectionTrainingModeON()
    {
        Modes.SetActive(true);
        Autorization.SetActive(false);
        Scenes.SetActive(false);
        PLAYGAME.SetActive(false);
        text.text = "";
    }
    public void DescriptionOfTheLevel()
    {
        text.text = "Тренировочный запуск самолета. Вы должны запустить два двигателя";
        PLAYGAME.SetActive(true);
        complexity.SetActive(true);
    }
}
