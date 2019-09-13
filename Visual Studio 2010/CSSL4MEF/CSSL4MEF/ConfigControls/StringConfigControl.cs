﻿/****************************** Module Header ******************************\
* Module Name:                StringConfigControl.cs
* Project:                    CSSL4MEF
* Copyright (c) Microsoft Corporation.
* 
* StringConfigControl
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using ConfigControl.Contract;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Data;

namespace CSSL4MEF.ConfigControls
{
    /// <summary>
    /// String type config control
    /// </summary>
    [ExportConfigControl(Name = "String", PropertyValueType = typeof(string))]
    public class StringConfigControl : IConfigControl
    {
        public FrameworkElement CreateView(PropertyInfo property)
        {
            var inputControl = new TextBox();
            var binding = new Binding(property.Name);
            binding.Mode = BindingMode.TwoWay;
            inputControl.SetBinding(TextBox.TextProperty, binding);
            return inputControl;
        }

        public MatchResult MatchTest(PropertyInfo property)
        {
            if (property.PropertyType.Equals(typeof(string)))
                return MatchResult.Match;
            else
                return MatchResult.NotMatch;
        }
    }
}
