using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenuScript : MonoCache
{
    public bool isOpened = true; //Открыто ли меню
    public bool isOpened1 = true; //Виден ли курсор
    public bool isFullscreen = true; //Полноэкранный режим
    public AudioMixer audioMixer; //Регулятор громкости
    public Slider MusicVolume;
    public Dropdown resolutionDropdown; //Список с разрешениями для игры
    private int countFrame = 0;
    private int countFrame1 = 0;
    


    public void ShowHideMenu()
    {
        isOpened = !isOpened;
        GetComponent<Canvas>().enabled = isOpened; //Включение или отключение Canvas.

    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 45;
    }

    // Update is called once per frame
    public override void OnTick()
    {
        countFrame1++;
        if (Input.GetKey(KeyCode.Escape))
        {
            if (countFrame == 0)
            {
                isOpened1 = !isOpened1;
                Cursor.visible = isOpened1;
                ShowHideMenu();
                countFrame++;
                countFrame1 = 0;
            }
            
        }
        if (countFrame1 == 10)
        {
            countFrame = 0;
        }        
    }

    

    public void ChangeResolution(int index) //Изменение разрешения
    {
        if (resolutionDropdown.value == 0)
        {
            Screen.SetResolution(1920, 1080, true);
        }

        if (resolutionDropdown.value == 1)
        {
            Screen.SetResolution(1280, 1024, true);
        }

        if (resolutionDropdown.value == 2)
        {
            Screen.SetResolution(800, 600, true);
        }
    }

    public void ChangeFullscreenMode(bool val) //Включение или отключение полноэкранного режима
    {
        isFullscreen = val;
        Screen.fullScreen = isFullscreen; //Включение или отключение полноэкранного режима
    }


    /*public void SaveSettings()
    {
        audioMixer.SetFloat("MasterVolume", MusicVolume.value); //Изменение уровня громкости
        Screen.fullScreen = isFullscreen; //Включение или отключение полноэкранного режима
        Screen.SetResolution(Screen.resolutions[currResolutionIndex].width, Screen.resolutions[currResolutionIndex].height, isFullscreen); //Изменения разрешения
    }*/
}
