﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007_Lesson1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void SubmitButton_Click1(object sender, EventArgs e)
        {
            FullNameTextBox.Text = FirstNameTextBox.Text.ToString() + " " + LastNameTextBox.Text.ToString();
        }
    }
}