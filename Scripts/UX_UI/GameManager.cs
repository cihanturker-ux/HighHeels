using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Diamond Counter
    public static int _currentDiamond;
    public Text _diamondText;
    //Diamond Counter
    
    //Level Counter
    public static int _currentLevel;
    public Text _levelText;
    //Level Counter
    
    //Settings Button
    [SerializeField] private GameObject _settingsPanel;
    //Settings Button
    
    
    //Settings Materials
    [SerializeField] private GameObject[] _vibration;
    [SerializeField] private GameObject[] _sounds;
    [SerializeField] private GameObject[] _music;
    //Settings Materials

    public void AddItem(int itemToAdd)
    {
        _currentDiamond += itemToAdd;
        _diamondText.text = "Diamond: " + _currentDiamond;
    }
    
    public void ManageLevel(int levelUp)
    {
        _currentLevel += levelUp;
        _levelText.text = "Level: " + _currentLevel;
    }

    //Settings Button START
    public void OpenSettingsBtn()
    {
        if (_settingsPanel != null)
        {
            _settingsPanel.SetActive(true);
        }
    }
    public void CloseSettingsPanelBtn()
    {
        if (_settingsPanel != null)
        {
            _settingsPanel.SetActive(false);
        }
    }
    //Settings Button END
    
    //Settings Materials START
    public void MaterialsOpen(int value)
    {
        if (value == 1)
        {
            //Vibration Active Function Here
            _vibration[0].SetActive(false);
            _vibration[1].SetActive(false);
            _vibration[2].SetActive(true);
            _vibration[3].SetActive(true);
        }
        if (value == 2)
        {
            //Sound Active Function Here
            _sounds[0].SetActive(false);
            _sounds[1].SetActive(false);
            _sounds[2].SetActive(true);
            _sounds[3].SetActive(true);
        }
        if (value == 3)
        {
            //Music Active Function Here
            _music[0].SetActive(false);
            _music[1].SetActive(false);
            _music[2].SetActive(true);
            _music[3].SetActive(true);
        }
    }
    public void MaterialsClose(int value)
    {
        if (value == 1)
        {
            //Vibration Deactive Function Here
            _vibration[0].SetActive(true);
            _vibration[1].SetActive(true);
            _vibration[2].SetActive(false);
            _vibration[3].SetActive(false);
        }
        if (value == 2)
        {
            //Sound Deactive Function Here
            _sounds[0].SetActive(true);
            _sounds[1].SetActive(true);
            _sounds[2].SetActive(false);
            _sounds[3].SetActive(false);
        }
        if (value == 3)
        {
            //Music Deactive Function Here
            _music[0].SetActive(true);
            _music[1].SetActive(true);
            _music[2].SetActive(false);
            _music[3].SetActive(false);
        }
    }
    //Settings Materials END
    
    //Game Over
    public void GameOver()
    {
        //when game is over this line will work
    }

    public void RetryButton()
    {
        //when game is over and player click the retry button this line will work
    }
    //Game Over
    
    
}
