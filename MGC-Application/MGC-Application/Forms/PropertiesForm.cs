using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class PropertiesForm : Form
{
    private readonly MainMenuForm mainMenuForm;

    public PropertiesForm(MainMenuForm _mainMenuForm)
    {
        InitializeComponent();

        this.Text = $"{_mainMenuForm.CurrentGame} Properties";
        headerLabel.Text = $"{_mainMenuForm.CurrentGame} Properties";

        configDescTextBox.Text = $"Properties and settings for {_mainMenuForm.CurrentGame}.";

        mainMenuForm = _mainMenuForm;
    }

    #region UI Events

    /// <summary>Event for properties form closed.</summary>
    private void PropertiesForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        // closes the form.
        this.Close();
    }

    #endregion

    #region Button Events

    /// <summary>Event for purgeButton click.</summary>
    private void purgeButton_Click(object sender, EventArgs e)
    {
        if (!mainMenuForm.IsInProcess)
        {
            configDescTextBox.Text = $"Clicking this button will purge any installed files for {mainMenuForm.CurrentGame}.";

            DialogBoxForm decision = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
                $"Are you sure you would like to purge {mainMenuForm.CurrentGame} game files?", true);
            decision.ShowDialog();

            if (decision.DecisionValue == DialogBoxForm.BoolValue.YES)
            {
                Debug.Log($"Started file purge process...");

                FileTools.DeleteDirectory(mainMenuForm.CurrentGame, mainMenuForm.GamePathFile);
                Thread.Sleep(2000);
                FileTools.DeleteFile(mainMenuForm.CurrentGame, mainMenuForm.GamePathFile);
                Thread.Sleep(1000);

                FileTools.ShowDialogMessage($"Successfully purged all {mainMenuForm.CurrentGame} game files.");
                Debug.Log($"Successfully purged {mainMenuForm.CurrentGame} files.");
            }
        }
        else
            FileTools.ShowDialogMessage("Please wait for background processes to complete before purging.");
    }

    /// <summary>Event for closeButton click.</summary>
    private void closeButton_Click(object _sender, EventArgs e)
    {
        // closes the form.
        this.Close();
    }

    #endregion
}
