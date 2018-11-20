using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestTool.DAO;
using TestTool.Controller;
using System.Collections;
using System.Runtime.InteropServices;

namespace TestTool
{
	public class Util
	{
		[DllImport("user32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool EnumChildWindows(IntPtr window, EnumedWindow callback, ArrayList lParam);

		[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
		public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

		private delegate bool EnumedWindow(IntPtr handleWindow, ArrayList handles);

		static CommonCodeController cmController;


		static Util()
		{
			cmController = new CommonCodeController();
		}

		public static List<CommonCode> GetCommonCodeByCategory(string category_cd)
		{
			List<CommonCode> list = cmController.SelectCmCodeByCategory(category_cd);


			return list;
		}

		public static List<CommonCode> SelectCmCodeByParent(string parent_cd)
		{
			List<CommonCode> list = cmController.SelectCmCodeByParent(parent_cd);


			return list;
		}


		public static IntPtr  GetEditWindowHandler(string WindowTitle)
		{
			var hList = new ArrayList();

			IntPtr parent = FindWindowByCaption(IntPtr.Zero, WindowTitle);

			hList = GetAllWindows(parent);

			int nRet;
			// Pre-allocate 256 characters, since this is the maximum class name length.
			StringBuilder ClassName = new StringBuilder(256);
			string name = "";

			foreach (IntPtr hwnd in hList)
			{
				//Get the window class name
				nRet = GetClassName(hwnd, ClassName, ClassName.Capacity);
				if (nRet != 0)
				{
					name = ClassName.ToString();
				}
				else
				{
					name = "";
				}

				if (name == "Edit")
				{
					return hwnd;
				}
			}

			return IntPtr.Zero;
		}

		private static ArrayList GetAllWindows(IntPtr parent)
		{
			var windowHandles = new ArrayList();

			EnumedWindow callBackPtr = GetWindowHandle;

			EnumChildWindows(parent, callBackPtr, windowHandles);

			return windowHandles;
		}

		private static bool GetWindowHandle(IntPtr windowHandle, ArrayList windowHandles)
		{
			windowHandles.Add(windowHandle);
			return true;
		}
	}
}
