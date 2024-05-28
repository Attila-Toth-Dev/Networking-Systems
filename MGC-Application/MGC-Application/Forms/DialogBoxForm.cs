namespace MGC_Application.Forms;

public partial class DialogBoxForm : Form
{
    public int DecisionValue { get; set; }

    private bool isDecisionForm;

    public enum MessageSeverity
    {
        MESSAGE,
        WARNING,
        ERROR
    }

    public DialogBoxForm(MessageSeverity _headerMessage, string _message, bool _isDecisionForm = false)
    {
        InitializeComponent();
        DialogBoxText(_headerMessage);

        messageTextBox.Enabled = false;
        messageTextBox.Text = _message;

        isDecisionForm = _isDecisionForm;

        yesButton.Visible = isDecisionForm;
        noButton.Visible = isDecisionForm;

        okayButton.Visible = !isDecisionForm;
    }

    /// <summary>Event for yesButton click.</summary>
    private void yesButton_Click(object sender, EventArgs e)
    {
        // returns a positive value for yes.
        DecisionValue = 1;
        this.Close();
        this.Dispose();
    }

    /// <summary>Event for noButton click.</summary>
    private void noButton_Click(object sender, EventArgs e)
    {
        // returns a negative value for no.
        DecisionValue = -1;
        this.Close();
        this.Dispose();
    }

    /// <summary>Event for okayButton click.</summary>
    private void okayButton_Click(object sender, EventArgs e)
    {
        // closes the dialog box.
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
