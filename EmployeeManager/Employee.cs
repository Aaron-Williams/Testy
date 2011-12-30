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
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace EmployeeManager
{
    public class Employee : INotifyPropertyChanged, IDataErrorInfo
    {

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; NotifyPropertyChanged("FirstName"); }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; NotifyPropertyChanged("LastName"); }
        }

        private DateTime _Birthday;
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; NotifyPropertyChanged("Birthday"); }
        }

        private string _Group;
        public string Group
        {
            get { return _Group; }
            set { _Group = value; NotifyPropertyChanged("Group"); }
        }

        private string _PhoneNumber;
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; NotifyPropertyChanged("PhoneNumber"); }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; NotifyPropertyChanged("Address"); }
        }

        private float _Income;
        public float Income
        {
            get { return _Income; }
            set { _Income = value; NotifyPropertyChanged("Income"); }
        }

        private float _TaxPercent;
        public float TaxPercent
        {
            get { return _TaxPercent; }
            set { _TaxPercent = value; NotifyPropertyChanged("TaxPercent"); }
        }

        private string _NationalID;
        public string NationalID
        {
            get { return _NationalID; }
            set { _NationalID = value; NotifyPropertyChanged("NationalID"); }
        }

        protected void NotifyPropertyChanged(string PropertyName)
        {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        string errors = null;
        public string Error
        {
            get { return errors; }
        }

        public string this[string columnName]
        {
            get
            {
                string result = null;

                if (columnName == "FirstName")
                {
                    if (String.IsNullOrEmpty(FirstName))
                        result = "Firstname has to be set!";
                    else if (FirstName.Length < 3)
                        result = "Firstname's length has to be at least 5 characters!";
                }
                else if (columnName == "LastName")
                {
                    if (String.IsNullOrEmpty(LastName))
                        result = "LastName has to be set!";
                    else if (LastName.Length < 3)
                        result = "LastName's length has to be at least 5 characters!";
                }
                else if (columnName == "Income")
                {
                    if (Income <= 0)
                        result = "The income has to be positive!";
                }
                else if (columnName == "TaxPercent")
                {
                    if (TaxPercent <= 0)
                        result = "The tax has to be positive!";
                    else if (TaxPercent >= 1)
                        TaxPercent /= 100;
                }
                else if (columnName == "NationalID")
                {
                    if (null != NationalID)
                        if (NationalID.Length < 10 || NationalID.Length > 12)
                            result = "National ID is wrong!";
                }

                return result;
            }
        }

    }

    public class Executive : Employee
    {
        private string _DepartmentName;
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; NotifyPropertyChanged("DepartmentName"); }
        }

        private int _ManagedEmployees;
        public int ManagedEmployees
        {
            get { return _ManagedEmployees; }
            set { _ManagedEmployees = value; NotifyPropertyChanged("ManagedEmployees"); }
        }
    }
}