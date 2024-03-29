﻿using System;
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

namespace SilverlightApplication1
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            Student std = new Student();
            LayoutRoot.DataContext = std;
        }

        private void LayoutRoot_BindingValidationError(object sender, ValidationErrorEventArgs e)
        {
            if(e.Action == ValidationErrorEventAction.Added)
            {
                (e.OriginalSource as Control).Background = new SolidColorBrush(Colors.Yellow);

                ToolTipService.SetToolTip((e.OriginalSource as TextBox), e.Error.Exception.Message);
            }

            if(e.Action == ValidationErrorEventAction.Removed)
            {
                (e.OriginalSource as Control).Background = new SolidColorBrush(Colors.White);

                ToolTipService.SetToolTip((e.OriginalSource as TextBox), null);
            }
        }

        private void butSave_Click(object sender, RoutedEventArgs e)
        {
            foreach (var ele in LayoutRoot.Children)
            {
                if (ele is TextBox)
                {
                    (ele as TextBox).GetBindingExpression(TextBox.TextProperty).UpdateSource();
                }
            }
        }
    }
}
