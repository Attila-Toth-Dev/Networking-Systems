namespace MGC_Application.Forms;

public partial class PropertiesForm : Form
{
    private MainMenuForm mainMenuForm;

    public PropertiesForm(MainMenuForm _mainMenuForm)
    {
        InitializeComponent();

        this.Text = $"{FileTools.currentGame} Properties";
        headerLabel.Text = $"{FileTools.currentGame} Properties";

        configDescTextBox.Text = $"Properties and settings for {FileTools.currentGame}.";

        mainMenuForm = _mainMenuForm;
    }

    #region Button Events

    /// <summary>Event for purgeButton click.</summary>
    private void purgeButton_Click(object sender, EventArgs e)
    {
        if (!mainMenuForm.IsInProcess)
        {
            configDescTextBox.Text = $"Clicking this button will purge any installed files for {FileTools.currentGame}.";

            DialogBoxForm decision = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
                $"Are you sure you would like to purge {FileTools.currentGame} game files?", true);
            decision.ShowDialog();

            if (decision.DecisionValue == DialogBoxForm.BoolValue.YES)
            {
                Debug.Log($"Started file purge process...");

                FileTools.DeleteDirectory(FileTools.currentGame, mainMenuForm.GamePathFile);
                Thread.Sleep(2000);
                FileTools.DeleteFile(FileTools.currentGame, mainMenuForm.GamePathFile);
                Thread.Sleep(1000);

                FileTools.ShowDialogMessage($"Successfully purged all {FileTools.currentGame} game files.");
                Debug.Log($"Successfully purged {FileTools.currentGame} files.");
            }
        }
        else
            FileTools.ShowDialogMessage("Please wait for background processes to complete before purging.");
    }

    /// <summary>Event for closeButton click.</summary>
    private void closeButton_Click(object sender, EventArgs e)
    {
        // closes the form.
        this.Close();
    }

    #endregion

    /// <summary>Event for PropertiesForm form closed.</summary>
    private void PropertiesForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        // closes the form.
        this.Close();
    }
}
