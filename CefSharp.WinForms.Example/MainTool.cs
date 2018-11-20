/*
namespace CefSharp.WinForms.Example
{
	public partial class TestTool : Form
	{
	*/

// Copyright © 2010-2017 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.Example;
using CefSharp.Example.Properties;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;

using TestTool.Controller;
using TestTool.DAO;


namespace TestTool.WinForms
{
	public partial class MainTool : Form
	{
		private ChromiumWebBrowser browser;

		bool IsLoading = false;

		public MainTool()
		{
			InitializeComponent();

			Text = "CefSharp";
			WindowState = FormWindowState.Maximized;

			var bitness = Environment.Is64BitProcess ? "x64" : "x86";
			var version = String.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}, Environment: {3}", Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion, bitness);
			DisplayOutput(version);

			//Only perform layout when control has completly finished resizing
			ResizeBegin += (s, e) => SuspendLayout();
			ResizeEnd += (s, e) => ResumeLayout(true);

			Load += OnLoad;
		}

		private void OnLoad(object sender, EventArgs e)
		{
			CreateBrowser();
		}

		private void CreateBrowser()
		{
			browser = new ChromiumWebBrowser("aboud:blank")
			{
				Dock = DockStyle.Fill,
			};
			toolStripContainer.ContentPanel.Controls.Add(browser);

			browser.LoadingStateChanged += OnBrowserLoadingStateChanged;
			browser.ConsoleMessage += OnBrowserConsoleMessage;
			browser.StatusMessage += OnBrowserStatusMessage;
			browser.TitleChanged += OnBrowserTitleChanged;
			browser.AddressChanged += OnBrowserAddressChanged;
			browser.JavascriptObjectRepository.Register("bound", new BoundObject());
		}

		private void OnBrowserConsoleMessage(object sender, ConsoleMessageEventArgs args)
		{
			DisplayOutput(string.Format("Line: {0}, Source: {1}, Message: {2}", args.Line, args.Source, args.Message));
		}

		private void OnBrowserStatusMessage(object sender, StatusMessageEventArgs args)
		{
			this.InvokeOnUiThreadIfRequired(() => statusLabel.Text = args.Value);
		}

		private void OnBrowserLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
		{
			SetCanGoBack(args.CanGoBack);
			SetCanGoForward(args.CanGoForward);

			this.InvokeOnUiThreadIfRequired(() => SetIsLoading(!args.CanReload));
		}

		private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
		{
			this.InvokeOnUiThreadIfRequired(() => Text = args.Title);
		}

		private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
		{
			this.InvokeOnUiThreadIfRequired(() => urlTextBox.Text = args.Address);
		}

		private void SetCanGoBack(bool canGoBack)
		{
			this.InvokeOnUiThreadIfRequired(() => backButton.Enabled = canGoBack);
		}

		private void SetCanGoForward(bool canGoForward)
		{
			this.InvokeOnUiThreadIfRequired(() => forwardButton.Enabled = canGoForward);
		}

		private void SetIsLoading(bool isLoading)
		{
			goButton.Text = isLoading ?
				"Stop" :
				"Go";
			/*
			goButton.Image = isLoading ?
				CefSharp.Example.Properties.Resources.nav_plain_red :
				Properties.Resources.nav_plain_green;
			*/
			HandleToolStripLayout();

			IsLoading = isLoading;
		}

		public void DisplayOutput(string output)
		{
			this.InvokeOnUiThreadIfRequired(() => outputLabel.Text = output);
		}

		private void HandleToolStripLayout(object sender, LayoutEventArgs e)
		{
			HandleToolStripLayout();
		}

		private void HandleToolStripLayout()
		{
			var width = toolStrip1.Width;
			foreach (ToolStripItem item in toolStrip1.Items)
			{
				if (item != urlTextBox)
				{
					width -= item.Width - item.Margin.Horizontal;
				}
			}
			urlTextBox.Width = Math.Max(0, width - urlTextBox.Margin.Horizontal - 18);
		}

		private void ExitMenuItemClick(object sender, EventArgs e)
		{
			browser.Dispose();
			Cef.Shutdown();
			Close();
		}

		private void GoButtonClick(object sender, EventArgs e)
		{
			LoadUrl(urlTextBox.Text);
		}

		private void BackButtonClick(object sender, EventArgs e)
		{
			browser.Back();
		}

		private void ForwardButtonClick(object sender, EventArgs e)
		{
			browser.Forward();
		}

		private void UrlTextBoxKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
			{
				return;
			}

			LoadUrl(urlTextBox.Text);
		}

		private void LoadUrl(string url)
		{
			if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
			{
				browser.Load(url);
			}
		}

		private void mnTestPlan_Click(object sender, EventArgs e)
		{
			TsManager tsManger = new TsManager(this, browser);

			tsManger.Show(this);
		}

		private void mnAbout_Click(object sender, EventArgs e)
		{
			TsDomTree domTree = new TsDomTree(browser);

			domTree.Show(this);
		}

		private async void endToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void urlTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
			{
				return;
			}

			LoadUrl(urlTextBox.Text);
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			browser.Back();
		}

		private void forwardButton_Click(object sender, EventArgs e)
		{
			browser.Forward();
		}

		private void mnCategoryCode_Click(object sender, EventArgs e)
		{
			frmCaegory category = new frmCaegory();
			category.Show(this);
		}

		private void mnCommonCode_Click(object sender, EventArgs e)
		{
			frmCode code = new frmCode();
			code.Show(this);
		}
	}
}
