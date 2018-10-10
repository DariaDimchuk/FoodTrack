using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTrack.utility
{

    public partial class ConfirmForm : Form
    {

        /// <summary>
        /// Create new confirm form, which shows a dialog that asks the input message
        /// and allows the user to either confirm or cancel the prompt.
        /// </summary>
        /// <param name="messageToConfirm">Message to ask user to confirm or deny</param>
        public ConfirmForm(String messageToConfirm)
        {
            InitializeComponent();
            QuestionText.Text = messageToConfirm;

            this.Parent = this.Owner;
            this.StartPosition = FormStartPosition.CenterParent;
        }//end method


        /// <summary>
        /// Confirm the action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }//end method

        /// <summary>
        /// Cancel the action confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }//end method

    }//end class
}
