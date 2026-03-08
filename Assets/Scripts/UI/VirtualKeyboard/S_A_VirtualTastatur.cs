using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class S_A_VirtualTastatur : S_A_BaseWindow
{
    [SerializeField]
    private TextMeshProUGUI nameView;

    [SerializeField]
    private TMP_InputField inputName;

    [SerializeField]
    private TMP_InputField leaderBoardInputField;

    [SerializeField]
    private S_A_LeaderBoardWindow lbw;

    private string name;
    private string letter;

    EventSystem eventSystem;

    [SerializeField]
    private GameObject firstSelectedButton;

    private void Awake()
    {
        eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(firstSelectedButton);
    }

    public void OnEnterButtonClicked()
    {
        leaderBoardInputField.text = name;
        this.Hide();
        lbw.Show();
    }

    public void OnBackButtonClicked()
    {
       
        this.Hide();
        lbw.Show();
    }


    public void OnQButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "Q";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnDeleteButtonClicked()
    {
        name = name.Remove(name.Length-1);
        nameView.text = name;
    }

    public void OnWButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "W";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnEButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "E";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnRButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "R";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnTButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "T";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnZButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "Z";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnUButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "U";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnIButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "I";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnOButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "O";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnPButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "P";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnAButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "A";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnSButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "S";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnDButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "D";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnFButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "F";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnGButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "G";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnHButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "H";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnJButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "J";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnKButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "K";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnLButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "L";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnYButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "Y";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnXButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "X";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnCButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "C";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnVButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "V";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnBButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "B";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnNButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "N";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnMButtonClicked()
    {

        if (nameView.text.Length <= 6)
        {
            letter = "M";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }
}
