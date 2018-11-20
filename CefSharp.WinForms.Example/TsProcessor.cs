using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Example;
using TestTool.DAO;
using TestTool.WinForms;

namespace TestTool
{
	public class TsProcessor
	{

		const int WM_PASTE = 0x0302;
		const int VK_RETURN = 0x0D;
		const int WM_KEYDOWN = 0x100;
		const int WM_KEYUP = 0x101;

		#region "Image Search DLL"

		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetDC(IntPtr hWnd);

		[DllImport("user32.dll", ExactSpelling = true)]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

		[DllImport("gdi32.dll", ExactSpelling = true)]
		public static extern IntPtr BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

		[DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);

		[DllImport(@".\ImageSearch\ImageSearchDLL64.dll")]
		public static extern unsafe IntPtr ImageSearch(int x, int y, int right, int bottom, [MarshalAs(UnmanagedType.LPStr)]string imagePath);

		#endregion

		#region "Mouse Click Event "

		[DllImport("user32.dll")]
		static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

		const uint MOUSEMOVE = 0x0001;      // 마우스 이동
		const uint ABSOLUTEMOVE = 0x8000;   // 전역 위치
		const uint LBUTTONDOWN = 0x0002;    // 왼쪽 마우스 버튼 눌림
		const uint LBUTTONUP = 0x0004;      // 왼쪽 마우스 버튼 떼어짐
		const uint RBUTTONDOWN = 0x0008;    // 오른쪽 마우스 버튼 눌림
		const uint RBUTTONUP = 0x00010;     // 오른쪽 마우스 버튼 떼어짐

		[DllImport("user32")]
		public static extern Int32 GetCursorPos(out POINT pt);
		[DllImport("user32")]
		public static extern Int32 SetCursorPos(Int32 x, Int32 y);

		public struct POINT
		{
			public Int32 x;
			public Int32 y;
		}

		#endregion

		[DllImport("user32.dll")]
		public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
		
		ChromiumWebBrowser TestBowser = null;
		TsManager TestManager = null;
		TsCase TestCase = null;

		object EvaluateJavaScriptResult = null;

		public bool IsStartTest { get; set; }

		public TsProcessor(TsManager tsManager, ChromiumWebBrowser browser)
		{
			TestBowser = browser;
			TestManager = tsManager;
			
			TestBowser.LoadingStateChanged -= Browser_LoadingStateChanged;
			TestBowser.LoadingStateChanged += Browser_LoadingStateChanged;

			TestBowser.FrameLoadEnd -= TestBowser_FrameLoadEnd;
			TestBowser.FrameLoadEnd += TestBowser_FrameLoadEnd;

			TestBowser.FrameLoadStart -= TestBowser_FrameLoadStart;
			TestBowser.FrameLoadStart += TestBowser_FrameLoadStart;

		}

		private void TestBowser_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
		{
			
		}

		private async void TestBowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
		{
			bool result = false;

			//Wait for the MainFrame to finish loading
			if (e.Frame.IsMain)
			{

				//Frame finished
				//e.Frame.ExecuteJavaScriptAsync("alert('MainFrame finished loading');");
			}
		}

		private async void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
		{
			bool result = false;

			//Loading이 완료되고 테스트 중인 상태만 실행됨
			if (e.IsLoading == false && IsStartTest == true)
			{
				await Task.Delay(200);

				switch (TestCase.check_type_key)
				{
					case "HTML_CHECK":
						//Browser Loading 완료된 상태에서 소스 체크
						TestManager.ControlEnabled(false);

						result = await CheckHtmlContents(TestCase.tc_check_string, TestCase.tc_check_timeout);

						TestManager.ControlEnabled(true);

						TestManager.SetTestResultTreeView(result);
						break;
					case "IMAGE_COMPARE":
						TestManager.ControlEnabled(false);
						result = await CheckImageContents(TestCase.tc_check_string, TestCase.tc_check_timeout);
						TestManager.ControlEnabled(true);
						TestManager.SetTestResultTreeView(result);
						break;
				}
			}
		}
		//Testcase 실행 후 성공여부 반환.
		public async Task<bool> runTestCase(TsCase tsCase)
		{
			bool result = false;

			TestCase = tsCase;

			string testType = TestCase.test_type_key;

			switch (testType)
			{
				case "HTML":
					result = await HtmlEventProcess();
					break;
				case "IMAGE":
					result = await ImageEventProcess();
					break;
				case "WINDOWS":
					result = await WindowsEventProcess();
					break;
			}
			return result;
		}

		//HTML 이벤트 
		private async Task<bool> HtmlEventProcess()
		{
			bool result = false;

			string eventName = TestCase.event_type_key;

			switch (eventName)
			{
				case "GO_PAGE":
					HtmlGoToPage(TestCase);
					break;
				case "INPUT_DATA":
					result = HtmlInputData(TestCase);

					TestManager.SetTestResultTreeView(result);

					break;
				case "INPUT_SCRIPT":
					result = HtmlInputScript(TestCase);
					TestManager.SetTestResultTreeView(result);
					break;
				case "CLICK_ID":
					result = await HtmlEventClickID(TestCase);
					TestManager.SetTestResultTreeView(result);
					break;
				case "CLICK_SPAN":
					result = await HtmlEventClickTagSpan(TestCase);
					TestManager.SetTestResultTreeView(result);
					break;
				case "CLICK_BUTTON":
					result = await HtmlEventClickTagButton(TestCase);
					TestManager.SetTestResultTreeView(result);
					break;
			}
			return result;
		}

		private void HtmlGoToPage(TsCase tsCase)
		{
			string URL = tsCase.tc_value;
			string checkString = tsCase.tc_check_string;

			TestBowser.Load(URL);			
		}

		private bool HtmlInputData(TsCase tsCase)
		{
			bool result = false; // 테스트 결과 입력

			if (TestBowser.IsLoading == false)
			{
				string ElementID = tsCase.tc_element_id.Trim();
				string Value = tsCase.tc_value.Trim();

				var frame = TestBowser.GetFocusedFrame();
				TestBowser.Focus();

				string js = "";
				js += @" var element = document.getElementById('" + ElementID + "'); ";
				js += @" if (element !== null)";
				js += @" { ";
				js += @"    document.getElementById('" + ElementID + "').value = '" + Value + "'; ";
				js += @"    return document.getElementById('" + ElementID + "').value;";
				js += @" }";
				js += @" else";
				js += @" { ";
				js += @"     var element = document.getElementsByName('" + ElementID + "'); ";
				js += @"     if (element !== null)";
				js += @"     { ";
				js += @"        element[0].value = '" + Value + "'; ";
				js += @"        return element[0].value;";
				js += @"     }";
				js += @" }";

				// Get Document Height
				var task = frame.EvaluateScriptAsync("(function() {  " + js + " })();", null);

				task.ContinueWith(t =>
				{
					if (!t.IsFaulted)
					{
						var response = t.Result;
						EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;
					}
				}, TaskScheduler.FromCurrentSynchronizationContext());

				task.Wait();

				//입력한 결과가 정확하게 입력되었는지 확인
				if (task.Result.Result != null && task.Result.Result.ToString() == Value)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}

			return result;
		}

		private bool HtmlInputScript(TsCase tsCase)
		{
			bool result = false; // 테스트 결과 입력

			if (TestBowser.IsLoading == false)
			{
				string Value = tsCase.tc_value.Trim();

				var frame = TestBowser.GetFocusedFrame();
				TestBowser.Focus();

				string js = "";

				js += @Value;
				js += @"return 'script_ok';";

				/*
				js += @"var doc = document.getElementById('se2_iframe').contentDocument;";
				js += @"doc.body.innerText = 'Add Mail Contents Test Tool';";
				js += @"return 'script_ok';";
				*/
				// Get Document Height
				var task = frame.EvaluateScriptAsync("(function() {  " + js + " })();", null);

				task.ContinueWith(t =>
				{
					if (!t.IsFaulted)
					{
						var response = t.Result;
						EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;
					}
				}, TaskScheduler.FromCurrentSynchronizationContext());

				task.Wait();

				//입력한 결과가 정확하게 입력되었는지 확인
				if (task.Result.Result.ToString() == "script_ok")
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}

			return result;
		}

		private async Task<bool> HtmlEventClickID(TsCase tsCase)
		{
			string ElementID = tsCase.tc_element_id.Trim();
			string checkString = tsCase.tc_check_string.Trim();

			var frame = TestBowser.GetFocusedFrame();
			TestBowser.Focus();

			string js = @" document.getElementById('" + ElementID.Trim() + "').submit(); ";

			frame.ExecuteJavaScriptAsync(js);

			//Check String이 포함되어 있으면 True
			return await CheckHtmlContents(checkString, TestCase.tc_check_timeout);
		}

		private async Task<bool> HtmlEventClickTagSpan(TsCase tsCase)
		{
			string Value = tsCase.tc_value.Trim();
			string checkString = tsCase.tc_check_string.Trim();

			var frame = TestBowser.GetFocusedFrame();
			TestBowser.Focus();

			string js = "";

			js += @" var spans = document.getElementsByTagName('span'); ";

			js += @" for (var i = 0; i < spans.length; i++)";
			js += @" {";
			js += @"     if (spans[i].innerText == '" + Value.Trim() + "')";
			js += @"     {";
			js += @"         spans[i].click();";
			js += @"      }";
			js += @"  }";

			frame.ExecuteJavaScriptAsync(js);

			//Check String이 포함되어 있으면 True
			return await CheckHtmlContents(checkString, TestCase.tc_check_timeout);
		}

		private async Task<bool> HtmlEventClickTagButton(TsCase tsCase)
		{
			bool result = false;

			string Value = tsCase.tc_value.Trim();
			string checkString = tsCase.tc_check_string.Trim();

			var frame = TestBowser.GetFocusedFrame();
			TestBowser.Focus();

			string js = "";

			js += @" var buttons = document.getElementsByTagName('button'); ";
			js += @" for (var i = 0; i < buttons.length; i++)";
			js += @" {";
			js += @"     if (buttons[i].innerText.search('" + Value + "') >= 0 )";
			js += @"     {";
			js += @"         buttons[i].click();";
			js += @"      }";
			js += @"  }";

			frame.ExecuteJavaScriptAsync(js);

			await Task.Delay(100);

			//Check String이 포함되어 있으면 True
			if (TestCase.check_type_key == "HTML_CHECK")
			{
				result = await CheckHtmlContents(checkString, TestCase.tc_check_timeout);
			}
			else if (TestCase.check_type_key == "IMAGE_COMPARE")
			{
				result = await CheckImageContents(checkString, TestCase.tc_check_timeout);
			}
			return result;
		}

		private async Task<bool> CheckHtmlContents(string CheckString, int timeout)
		{
			Stopwatch watch = new Stopwatch();
			watch.Start();
			while (true)
			{
				var html = await TestBowser.GetSourceAsync();

				//Give the browser a few ms to finish rendering before we try to Dispose it
				await Task.Delay(100);

				if (html.Contains(CheckString))
				{
					return true;
				}

				Thread.Sleep(50);

				//Timeout된 경우 
				if (timeout < watch.ElapsedMilliseconds)
				{
					return false;
				}

				//30초 이상 되면 종료
				if (300000 < watch.ElapsedMilliseconds)
					return false;
			}
		}

		private async Task<bool> CheckImageContents(string image_path, int timeout)
		{
			Application.DoEvents();


			string search_option = "1";

			Stopwatch watch = new Stopwatch();
			watch.Start();

			while (true)
			{
				IntPtr str = ImageSearch(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, "*" + search_option + " " + @image_path);

				String res = Marshal.PtrToStringAnsi(str);

				//MessageBox.Show(res);

				//위치정보를 찾은 경우
				string[] pos = res.Split('|');

				if (pos.Length == 5)
				{
					return true;
				}

				await Task.Delay(100);

				//Timeout된 경우 
				if (timeout < watch.ElapsedMilliseconds)
				{
					return false;
				}

				//30초 이상 되면 종료
				if (300000 < watch.ElapsedMilliseconds)
					return false;
			}
			
		}

		//IMAGE 이벤트
		private async Task<bool> ImageEventProcess()
		{
			bool result = false;

			string eventName = TestCase.event_type_key;

			switch (eventName)
			{
				case "IMAGE_CLICK":
					result = await ImageEventClick(TestCase);

					//클릭한 성공한 경우 확인
					if (result)
					{
						result = await CheckImageContents(TestCase.tc_check_string, TestCase.tc_check_timeout);
					}

					TestManager.SetTestResultTreeView(result);

					break;
			}
			return result;
		}
		private async Task<bool> ImageEventClick(TsCase tsCase)
		{
			bool result = false;

			result = await ImageSearchClick(tsCase.tc_value);

			return result;
		}

		private async Task<bool> ImageSearchClick(string image_path)
		{
			bool result = false;

			//현재 커서 설정
			POINT currentPT;
			GetCursorPos(out currentPT);

			string search_option = "1";
			
			IntPtr str = ImageSearch(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, "*" + search_option + " " + image_path);

			String res = Marshal.PtrToStringAnsi(str);

			//MessageBox.Show(res.ToString());

			//위치정보를 찾은 경우
			string[] pos = res.Split('|');

			if (pos.Length == 5)
			{
				int x = 0, y = 0;
				int.TryParse(pos[1],out x);
				int.TryParse(pos[2], out y);

				SetCursorPos(x + 15, y + 35);

				mouse_event(LBUTTONDOWN, 0, 0, 0, 0);

				await Task.Delay(200);

				mouse_event(LBUTTONUP, 0, 0, 0, 0);

				await Task.Delay(100);

				//커서 위치 원위치
				SetCursorPos(currentPT.x, currentPT.y);

				result = true;
			}

			return result;

		}

		//Windows 이벤트
		private async Task<bool> WindowsEventProcess()
		{
			bool result = false;

			string eventName = TestCase.event_type_key;

			switch (eventName)
			{
				case "TEXT_PASTE":
					bool resutl = await WindowsTextPaste();

					TestManager.SetTestResultTreeView(result);

					break;
			}
			return result;
		}
		private async Task<bool> WindowsTextPaste()
		{
			bool result = false;

			IntPtr hwnd = Util.GetEditWindowHandler(TestCase.tc_element_id.Trim());

			if ((int)hwnd > 0)
			{
				result = true;
			}

			Clipboard.SetText( TestCase.tc_value);

			PostMessage(hwnd, WM_PASTE, IntPtr.Zero, IntPtr.Zero);

			await Task.Delay(50);
			
			PostMessage(hwnd, WM_KEYDOWN, new IntPtr(VK_RETURN), new IntPtr(0));
			PostMessage(hwnd, WM_KEYUP, new IntPtr(VK_RETURN), new IntPtr(0));

			await Task.Delay(500);

			Application.DoEvents();

			await Task.Delay(1500);

			result = await CheckImageContents(TestCase.tc_check_string, TestCase.tc_check_timeout);

			return result;
		}
	}
}
