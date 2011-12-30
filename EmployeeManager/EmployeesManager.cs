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
using System.Collections.ObjectModel;

namespace EmployeeManager
{
  public class EmployeesManager
  {
    public ObservableCollection<Employee> Employees { get; set; }

    public EmployeesManager()
    {
      Employees = new ObservableCollection<Employee>();

      FillData();
    }

    private void FillData()
    {
      Employees.Add(new Employee()
      {
        FirstName = "FName1",
        LastName = "LName1",
        PhoneNumber = "555-555-5555",
        Birthday = DateTime.Parse("1980/10/12"),
        Group = "IT",
        Income = 45000.00f,
        TaxPercent = 0.057f,
        NationalID = "IL1234567890"
      });

      Employees.Add(new Executive()
      {
        FirstName = "FName2",
        LastName = "LName2",
        PhoneNumber = "555-555-6666",
        Birthday = DateTime.Parse("1975/03/01"),
        Income = 45500.00f,
        TaxPercent = 0.057f,
        NationalID = "UK1234567890",
        ManagedEmployees=3
      });

      Employees.Add(new Employee()
      {
        FirstName = "FName3",
        LastName = "LName3",
        PhoneNumber = "555-555-7777",
        Group = "Students",
        Income = 35000.00f,
        TaxPercent = 0.025f,
        NationalID = "IZ1234567890"
      });

      Employees.Add(new Employee()
      {
        FirstName = "FName4",
        LastName = "LName4",
        PhoneNumber = "555-555-4536",
        Birthday = DateTime.Parse("1988/01/03"),
        Group = "IT",
        Income = 35500.00f,
        TaxPercent = 0.027f,
        NationalID = "BB1234567890"
      });

      Employees.Add(new Employee()
      {
        FirstName = "FName5",
        LastName = "LName5",
        PhoneNumber = "555-555-0099",
        Birthday = DateTime.Parse("1975/10/23"),
        Group = "Managers",
        Income = 85000.00f,
        TaxPercent = 0.155f,
        NationalID = "IL00112233"
      });

      Employees.Add(new Employee()
      {
        FirstName = "FName6",
        LastName = "LName6",
        PhoneNumber = "555-555-7774",
        Group = "Students",
        Income = 15000.00f,
        TaxPercent = 0.015f,
        NationalID = "IC123456789B",
      });

      Employees.Add(new Employee()
      {
        FirstName = "FName7",
        LastName = "LName7",
        PhoneNumber = "555-305-0844",
        Birthday = DateTime.Parse("1973/12/14"),
        Group = "Managers",
        Income = 88000.00f,
        TaxPercent = 0.25f,
        NationalID = "IL306864992"
      });

      Employees.Add(new Employee()
      {
        FirstName = "FName8",
        LastName = "LName8",
        PhoneNumber = "555-555-1123",
        Group = "Students",
        Income = 14000.00f,
        TaxPercent = 0.015f,
        NationalID = "NZ1234567890"
      });

      Employees.Add(new Executive()
      {
          FirstName = "FName9",
          LastName = "LName9",
          PhoneNumber = "555-555-6666",
          Birthday = DateTime.Parse("1966/04/03"),
          Income = 95500.00f,
          TaxPercent = 0.057f,
          NationalID = "UK0987654321",
          ManagedEmployees = 2
      });

    }
  }


}