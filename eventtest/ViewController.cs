using System;
using CoreGraphics;
using UIKit;
using System.Windows.Input;

namespace eventtest
{



	public partial class ViewController : UIViewController
	{
		public event Action FireEvent;

		public UITextField _txt1;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			View.BackgroundColor = UIColor.White;
			text();

		}

		public static void somthing(string[] args)
		{
			ViewController VC = new ViewController();

			VC.FireEvent += VC.ShowString;

			VC.fireEvent();

			//Console.WriteLine("Hello World!" ); 
		}

		public void fireEvent()
		{
			FireEvent();
		}

		public void ShowString()
		{
			_txt1.Text = "Hello World";


		}
		public void text()
		{
			var rect = new CGRect(25, 300, 150, 50);
			_txt1 = new UITextField(rect);
			_txt1.Layer.BorderWidth = 3f;
			_txt1.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_txt1.Layer.CornerRadius = 15f;
			_txt1.Text = "test";
			View.Add(_txt1);
		}
	}

}
