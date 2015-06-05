﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;

namespace NuGet.PackageManagement.UI
{
    public class SummaryToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var summary = (string)value;
            if (String.IsNullOrEmpty(summary))
            {
                // The package metadata is not available from the selected package source.
                // In this case, display a message "not available in this source".
                return Resources.Text_NotAvailableInSource;
            }
            else
            {
                return summary;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // no op
            Debug.Assert(false, "Not Implemented");
            return null;
        }
    }
}