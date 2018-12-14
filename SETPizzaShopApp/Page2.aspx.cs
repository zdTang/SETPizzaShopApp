using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Data;

namespace SETPizzaShopApp
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;

            if(!Page.IsPostBack)
            {
                DataTable ingredientTable = new DataTable();
                ingredientTable.Columns.Add("Ingredient", Type.GetType("System.String"));
                ingredientTable.Columns.Add("Price", Type.GetType("System.Double"));
                ingredientView.DataSource = ingredientTable;
                ingredientView.DataBind();
            }

            try
            {
                firstName = PreviousPageViewState["firstName"].ToString();    // Get user name from redirecting page.
                lastName = PreviousPageViewState["lastName"].ToString();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // If order ID is 0, last page's operation failed.
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                feedback.Text = "THIS PAGE CANNOT BE ACCESSED DIRECTLY";
            }
            else
            {
                //greetingLabel.Text = "Ciao " + firstName;
            }

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
            
        }

        /* 
         *  Function    : PreviousPageViewState
         *  Description : Get the ViewState of previous page.
         *  Parameter   : N/A
         *  Returns     : StateBag      : ViewState of previous page.
         */
        private StateBag PreviousPageViewState
        {
            get
            {
                StateBag returnValue = null;
                if (Page.PreviousPage != null)
                {
                    Object objPreviousPage = (Object)PreviousPage;
                    MethodInfo objMethod = objPreviousPage.GetType().GetMethod("ReturnViewState");
                    return (StateBag)objMethod.Invoke(objPreviousPage, null);
                }
                return returnValue;
            }
        }
    }
}