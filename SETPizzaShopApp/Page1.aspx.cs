using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace SETPizzaShopApp
{
    public partial class Page1 : System.Web.UI.Page
    {
        private readonly int firstNameIndex = 0;
        private readonly int lastNameIndex = 1;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /* 
         *  Function    : enter_Click
         *  Description : This is the event handler for enter.
         *  Parameter   : object        sender      : object that triggered this event handler.
         *                EventArgs     e           : arguments associated with this event.
         *  Returns     : N/A
         */
        protected void enter_Click(object sender, EventArgs e)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;

            // Validate name input.
            Page.Validate("nameValidation");
            foreach (BaseValidator validator in Page.GetValidators("nameValidation"))
            {
                if (!validator.IsValid)
                {
                    nameInput.Text = string.Empty;
                }
            }
            
            if (Page.IsValid)
            {
                // Parse name input.
                string[] names = nameInput.Text.Split(Convert.ToChar(ConfigurationManager.AppSettings["nameDelimiter"]));
                firstName = names[firstNameIndex];
                lastName = names[lastNameIndex];


                // Preserver user input to the next page
                ViewState["firstName"] = firstName;
                ViewState["lastName"] = lastName;
                Server.Transfer("Page2.aspx", true);
            }
        }

        /* 
         *  Function    : ReturnViewState
         *  Description : Return the ViewState of current page.
         *  Parameter   : N/A
         *  Returns     : StateBag      : ViewState of current page.
         */
        public StateBag ReturnViewState()
        {
            return ViewState;
        }
    }
}