namespace MGC_Application.Forms;

public partial class DialogBoxForm : Form
{
    public BoolValue DecisionValue { get; set; }

    public enum MessageSeverity
    {
        MESSAGE,
        WARNING,
        ERROR
    }

    public enum BoolValue
    {
        YES,
        NO
    }

    public DialogBoxForm(MessageSeverity _headerMessage, string _message, bool _isDecisionForm = false)
    {
        InitializeComponent();
        DialogBoxText(_headerMessage);

        messageTextBox.Enabled = false;
        messageTextBox.Text = _message;

        yesButton.Visible = _isDecisionForm;
        noButton.Visible = _isDecisionForm;

        okayButton.Visible = !_isDecisionForm;
    }

    #region Button Events

    /// <summary>Event for yes button click.</summary>
    private void yesButton_Click(object sender, EventArgs e)
    {
        // returns a positive value for yes.
        DecisionValue = BoolValue.YES;
        this.Close();
        this.Dispose();
    }

    /// <summary>Event for no button click.</summary>
    private void noButton_Click(object sender, EventArgs e)
    {
        // returns a negative value for no.
        DecisionValue = BoolValue.NO;
        this.Close();
        this.Dispose();
    }

    /// <summary>Event for okay button click.</summary>
    private void okayButton_Click(object sender, EventArgs e)
    {
        // closes the dialog box.
        this.Close();
        this.Dispose();
    }

    #endregion

    /// <summary>Event for dialog box form closed.</summary>
    private void DialogBoxForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        // close the dialog box
        this.Close();
        this.Dispose();
    }

    /// <summary>Function that changes dialog text boxes name with message severity.</summary>
    /// <param name="_headerMessage">The severity level of dialog box.</param>
    private void DialogBoxText(MessageSeverity _headerMessage)
    {
        // dependent on the messageseverity, change the forms
        // text to the severity level.
        switch (_headerMessage)
        {
            case MessageSeverity.MESSAGE:
                this.Text = "Message";
                break;

            case MessageSeverity.WARNING:
                this.Text = "Warning";
                break;

            case MessageSeverity.ERROR:
                this.Text = "ERROR";
                break;
        }
    }
}
