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

    private void yesButton_Click(object sender, EventArgs e)
    {
        DecisionValue = 1;
        this.Close();
        this.Dispose();
    }

    private void noButton_Click(object sender, EventArgs e)
    {
        DecisionValue = -1;
        this.Close();
        this.Dispose();
    }

    private void okayButton_Click(object sender, EventArgs e)
    {
        this.Close();
        this.Dispose();
    }

    private void DialogBoxText(MessageSeverity _headerMessage)
    {
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
