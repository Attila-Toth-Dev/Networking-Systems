namespace MGC_Application_Release.Forms
{
    public partial class DialogBoxForm : Form
    {
        public BoolValue DecisionValue { get; set; }

        public enum MessageSeverity
        {
            MESSAGE = 0,
            WARNING,
            ERROR
        }

        public enum BoolValue
        {
            YES = 0,
            NO
        }

        public DialogBoxForm(MessageSeverity _headerMessage, string _message, bool _isDecisionForm = false)
        {
            InitializeComponent();
            DialogBoxText(_headerMessage);

            this.Text = "MGC";

            messageTextBox.Enabled = false;
            messageTextBox.Text = _message;

            yesButton.Visible = _isDecisionForm;
            noButton.Visible = _isDecisionForm;

            okayButton.Visible = !_isDecisionForm;
        }

        #region Button Events

        private void yesButton_Click(object sender, EventArgs e)
        {
            DecisionValue = BoolValue.YES;
            this.Close();
            this.Dispose();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            DecisionValue = BoolValue.NO;
            this.Close();
            this.Dispose();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        #endregion

        private void DialogBoxForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>Function that changes dialog text boxes name with message severity.</summary>
        /// <param name="_headerMessage">The severity level of dialog box.</param>
        private void DialogBoxText(MessageSeverity _headerMessage)
        {
            this.Text = _headerMessage switch
            {
                MessageSeverity.MESSAGE => "Message",
                MessageSeverity.WARNING => "Warning",
                MessageSeverity.ERROR => "ERROR",
                _ => this.Text
            };
        }
    }
}
