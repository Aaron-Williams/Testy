// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace EmployeeManager
{
    [TemplatePart(Name = "txtFirstName", Type = typeof(TextBox)),
     TemplatePart(Name = "txtLastName", Type = typeof(TextBox)),
     TemplatePart(Name = "txtBirthday", Type = typeof(TextBox)),
     TemplatePart(Name = "txtGroup", Type = typeof(TextBox)),
     TemplatePart(Name = "txtPhoneNumber", Type = typeof(TextBox)),
     TemplatePart(Name = "txtAddress", Type = typeof(TextBox)),
     TemplatePart(Name = "txtIncome", Type = typeof(TextBox)),
     TemplatePart(Name = "txtTaxPercent", Type = typeof(TextBox)),
     TemplatePart(Name = "txtNationalID", Type = typeof(TextBox))]
    public class EmployeeDataForm : Control
    {
        public EmployeeDataForm()
        {
            this.DefaultStyleKey = typeof(EmployeeDataForm);

            this.DataContext = this;
        }

        public bool IsLocked
        {
            get { return (bool)GetValue(IsLockedProperty); }
            set { SetValue(IsLockedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsEditing.  This 	enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsLockedProperty =
            DependencyProperty.Register("IsLocked", typeof(bool), typeof(EmployeeDataForm), null);

        public bool IsValid
        {
            get { return !HasBindingErrors(); }
        }

        public Employee TheEmployee
        {
            get { return (Employee)GetValue(TheEmployeeProperty); }
            set { SetValue(TheEmployeeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TheEmployee.  This 	enables animation, styling, binding, etc...
        public static readonly DependencyProperty TheEmployeeProperty =
            DependencyProperty.Register("TheEmployee", typeof(Employee), typeof(EmployeeDataForm), null);


        private bool HasBindingErrors()
        {
            bool res = false; //assume success
            res |= Validation.GetHasError(GetTemplateChild("txtFirstName"));
            res |= Validation.GetHasError(GetTemplateChild("txtLastName"));
            res |= Validation.GetHasError(GetTemplateChild("txtBirthday"));
            res |= Validation.GetHasError(GetTemplateChild("txtGroup"));
            res |= Validation.GetHasError(GetTemplateChild("txtPhoneNumber"));
            res |= Validation.GetHasError(GetTemplateChild("txtAddress"));
            res |= Validation.GetHasError(GetTemplateChild("txtIncome"));
            res |= Validation.GetHasError(GetTemplateChild("txtTaxPercent"));
            res |= Validation.GetHasError(GetTemplateChild("txtNationalID"));

            return res;
        }
    }
}