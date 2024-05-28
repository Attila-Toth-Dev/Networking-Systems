namespace MGC_Application.Forms;

public partial class PropertiesForm : Form
{
    private MainMenuForm mainMenuForm;

    private string selectedGame;
    private string gamePathFile;

    public PropertiesForm(MainMenuForm _mainMenuForm)
    {
        InitializeComponent();

        mainMenuForm = _mainMenuForm;

        selectedGame = mainMenuForm.currentSelectedGame;
        gamePathFile = mainMenuForm.gameFilePathTextBox.Text;

        this.Text = $"{selectedGame} Properties";
        headerLabel.Text = $"{selectedGame} Properties";
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        mainMenuForm.PropertiesRestrict = 0;
        this.Close();
        this.Dispose();
    }
    
    private void PropertiesForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        mainMenuForm.PropertiesRestrict = 0;
        this.Close();
        this.Dispose();
    }
}
