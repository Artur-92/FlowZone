using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class S_VirtualKeyboard : S_BaseWindow
{
    [SerializeField] private S_GameUI gameUI;
    [SerializeField]
    private TextMeshProUGUI nameView;

    [SerializeField]
    private TMP_InputField inputName;

    [SerializeField]
    private TMP_InputField leaderBoardInputField;


    private string name;
    private string letter;


    private void Update()
    {
        OnBackButtonClicked();
    }

    public void OnEnterButtonClicked()
    {
        leaderBoardInputField.text = name;
        //this.Hide();
        //lbw.Show();
        gameUI.closeCurrentWindow();

    }

    public void OnBackButtonClicked()
    {

        //this.Hide();
        //lbw.Show();
        if (S_UIInput.instance.BackButtonController)
        {
            gameUI.closeCurrentWindow();
        }
       
    }


    public void OnQButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "Q";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnDeleteButtonClicked()
    {
        name = name.Remove(name.Length - 1);
        nameView.text = name;
    }

    public void OnWButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "W";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnEButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "E";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnRButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "R";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnTButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "T";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnZButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "Z";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnUButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "U";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnIButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "I";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnOButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "O";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnPButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "P";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnAButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "A";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnSButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "S";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnDButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "D";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnFButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "F";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnGButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "G";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnHButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "H";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnJButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "J";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnKButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "K";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnLButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "L";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnYButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "Y";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnXButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "X";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnCButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "C";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnVButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "V";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnBButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "B";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnNButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "N";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }

    public void OnMButtonClicked()
    {

        if (nameView.text.Length <= 9)
        {
            letter = "M";
            name = name + letter;
            nameView.text = name;
        }
        //return name;
    }
}
