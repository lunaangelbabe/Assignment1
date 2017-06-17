﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BookUniversal
{
    public sealed partial class cdOrderDialogue : ContentDialog
    {
        public cdOrderDialogue()
        {
            this.InitializeComponent();
            SetDetail();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void SetDetail()
        {
            Title = "Confirm Your Order";
            Content = "Are your details correct? Do you want to make this order?";
            PrimaryButtonText = "Confirm Order";
            SecondaryButtonText = "Cancel Order";
        }
    }
}
