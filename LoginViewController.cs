// This file has been autogenerated from a class added in the UI designer.

using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace NiftyAppz.Proto
{
	public partial class LoginViewController : UIViewController
	{

		const float JVFieldHeight = 44.0f;
		const float JVFieldHMargin = 10.0f;
		const float JVFieldFontSize = 16.0f;
		const float JVFieldFloatingLabelFontSize = 11.0f;


		public LoginViewController (IntPtr handle) : base (handle)
		{
			//loginViewModel = ServiceContainer.Resolve<LoginViewModel>();
			//Hook up ViewModel events
			//loginViewModel.IsBusyChanged += OnIsBusyChanged;
			//loginViewModel.IsValidChanged += OnIsValidChanged;
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			float topOffset = UIApplication.SharedApplication.StatusBarFrame.Size.Height + NavigationController.NavigationBar.Frame.Size.Height;
			UIColor floatingLabelColor = UIColor.Gray, floatingLabelActiveColor = UIColor.Blue;

			var usernameField = new JVFloatLabeledTextField(new RectangleF(JVFieldHMargin, topOffset, 
				View.Frame.Size.Width - 2 * JVFieldHMargin, 
				JVFieldHeight))
			{
				Placeholder = "Username",
				Font = UIFont.SystemFontOfSize(JVFieldFontSize),
				ClearButtonMode = UITextFieldViewMode.WhileEditing,
				FloatingLabelFont = UIFont.BoldSystemFontOfSize(JVFieldFloatingLabelFontSize),
				FloatingLabelTextColor = floatingLabelColor,
				FloatingLabelActiveTextColor = floatingLabelActiveColor
			};
			View.AddSubview(usernameField);

			var div1 = new UIView(new RectangleF(JVFieldHMargin, 
				usernameField.Frame.Y + usernameField.Frame.Size.Height, 
				View.Frame.Size.Width - 2 * JVFieldHMargin, 1))
			{
				BackgroundColor = UIColor.LightGray.ColorWithAlpha(0.3f)
			};
			View.AddSubview(div1);

			//var passwordField = new JVFloatLabeledEntryElement ("Password", isPassword: true);
			var passwordField = new JVFloatLabeledTextField(new RectangleF(JVFieldHMargin, 
				div1.Frame.Y + div1.Frame.Size.Height,
				View.Frame.Size.Width - 2 * JVFieldHMargin, 
				JVFieldHeight))
			{
				Placeholder = "Password",
				Font = UIFont.SystemFontOfSize(JVFieldFontSize),
				FloatingLabelFont = UIFont.BoldSystemFontOfSize(JVFieldFloatingLabelFontSize),
				FloatingLabelTextColor = floatingLabelColor,
				FloatingLabelActiveTextColor = floatingLabelActiveColor,
				SecureTextEntry = true
			};

			View.AddSubview(passwordField);

			var div2 = new UIView(new RectangleF(JVFieldHMargin, 
				passwordField.Frame.Y + passwordField.Frame.Size.Height, 
				View.Frame.Size.Width - 2 * JVFieldHMargin, 1))
			{
				BackgroundColor = UIColor.LightGray.ColorWithAlpha(0.3f)
			};
			View.AddSubview(div2);

			var passwordConfirmField = new JVFloatLabeledTextField(new RectangleF(JVFieldHMargin, 
				div2.Frame.Y + div2.Frame.Size.Height,
				View.Frame.Size.Width - 2 * JVFieldHMargin, 
				JVFieldHeight))
			{
				Placeholder = "Confirm Password",
				Font = UIFont.SystemFontOfSize(JVFieldFontSize),
				FloatingLabelFont = UIFont.BoldSystemFontOfSize(JVFieldFloatingLabelFontSize),
				FloatingLabelTextColor = floatingLabelColor,
				FloatingLabelActiveTextColor = floatingLabelActiveColor,
				SecureTextEntry = true
			};

			View.AddSubview(passwordConfirmField);

			usernameField.BecomeFirstResponder();

			//Hiding Keypad
			var tap = new UITapGestureRecognizer ();
			tap.AddTarget (() => {
				View.EndEditing (true);
			});
			View.AddGestureRecognizer (tap);

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

	}
}