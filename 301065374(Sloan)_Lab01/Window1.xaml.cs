using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace _301065374_Sloan__Lab01
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		List<Class1.obj> bl = new List<Class1.obj>();
		Class1 c1 = new Class1();
		public Window1()
		{
			InitializeComponent();
			bl.Clear();
			bl = c1.getList();
			dgvBucketList.ItemsSource = null;
			dgvBucketList.ItemsSource = bl;
		}

		private void txtMainMenu_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mWin = new MainWindow();
			mWin.Show();
			this.Close();
		}

		private void txtReload_Click(object sender, RoutedEventArgs e)
		{
			dgvBucketList.ItemsSource = null;
			dgvBucketList.ItemsSource = bl;
		}

		private void txtCreate_Click(object sender, RoutedEventArgs e)
		{
			string bName = txtBucketName.Text;
			addNewBucket(bName);
			bl.Clear();
			bl = c1.getList();
		}


		private async Task addNewBucket(string bName)
		{
			string awsAccessKey = "AKIASBEUMF2ZVMOPWS7S";
			string awsSecretKey = "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";
			var s3Client = new AmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);
			var respons = await s3Client.PutBucketAsync(new PutBucketRequest
			{
				BucketName = bName
			});
		}
	}
}
