﻿using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace PageViewController.ViewControllers
{
    [Register("A")]
    public class A : BaseView
    {
        public A()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            Title = "A";
            View.BackgroundColor = UIColor.Red;


            var button = new UIButton();
            button.SetTitle("test", UIControlState.Normal);
            button.Frame = new CoreGraphics.CGRect(20, 100, 200, 40);
            button.TouchUpInside += Button_TouchUpInside;
            View.Add(button);
        }

        private void Button_TouchUpInside(object sender, EventArgs e)
        {
            var parentViewController = this.ParentViewController;
            parentViewController.NavigationController.PushViewController(new B(),true);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }
    }
}