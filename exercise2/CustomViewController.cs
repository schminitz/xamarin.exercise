using System;
using UIKit;
using CoreGraphics;
using exercise2pcl;

namespace exercise2
{
	public class CustomViewController : UIViewController
	{
		UILabel nameLabel;
		UIButton nameButton;
		UITextField nameField;

		nfloat h;
		nfloat w;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.Gray;

			h = 31.0f;
			w = View.Bounds.Width;

			AddNameLabel();
			AddNameField ();
			AddNameButton ();
		}

		void AddNameLabel()
		{
			nameLabel = new UILabel (new CGRect (10, 32, w - 20, h));
			nameLabel.Text = Settings.UserName;

			View.AddSubview (nameLabel);

		}

		void AddNameField()
		{
			nameField = new UITextField
			{
				Placeholder = "Enter your username",
				BorderStyle = UITextBorderStyle.RoundedRect,
				Frame = new CGRect(10, 62, w - 20, h)
			};
			nameField.AccessibilityLabel = "namefieldid";
			View.AddSubview (nameField);
		}

		void AddNameButton()
		{
			nameButton = new UIButton (new CGRect (10, 102, w - 20, h));
			nameButton.SetTitle ("Change name", UIControlState.Normal);
			nameButton.BackgroundColor = UIColor.Blue;

			nameButton.TouchUpInside += (object sender, EventArgs e) => {
				Settings.UserName = nameField.Text;
				nameLabel.Text = Settings.UserName;
			};
			View.AddSubview (nameButton);

		}

	}
}

