using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTool.WinForms
{
	public partial class TsDomTree : Form
	{
		ChromiumWebBrowser CHROME;

		object EvaluateJavaScriptResult = null;

		public TsDomTree(ChromiumWebBrowser browser)
		{
			InitializeComponent();

			CHROME = browser;
		}

		private void EventClickTagButton( )
		{
			int frameCount = CHROME.GetBrowser().GetFrameCount();

			if (frameCount > 0)
			{
				CefSharp.IFrame frame = CHROME.GetBrowser().MainFrame;

				string js = "";

				js += @" function getNodeTree(node) { ";
				
				js += @"     if (node.hasChildNodes()) { ";
				
				js += @"         var children = []; ";
				js += @"         for (var j = 0; j < node.childNodes.length; j++) { ";
				js += @"             children.push(getNodeTree(node.childNodes[j])); ";
				js += @"         } ";

				js += @"         return { ";
				js += @"             nodeName: node.nodeName, parentName: node.parentNode.nodeName, children: children, content: node.innerText || '', ";
				js += @"         }; ";
				js += @"     } ";
				js += @"     return false; ";
				js += @" } ";

				js += @"  var nodeTree = getNodeTree(document.documentElement); ";

				js += @" function muestraArbol(node) { ";
				js += @" 	if (!node) return ''; ";

				js += @"     var txt = ''; ";
				js += @"     if (node.children.length > 0) { ";
				js += @"         txt += '<ul><li>Nodo: ' + node.nodeName + '</li>'; ";
				js += @"         txt += '<li> Padre: ' + node.parentName + '</li>'; ";
				js += @"         txt += '<li>Contenido: ' + node.content + '</li>'; ";
				js += @"         for (var i = 0; i < node.children.length; i++) ";
				js += @"         	if (node.children[i]) ";
				js += @"             	txt += '<li> Hijos: ' + muestraArbol(node.children[i]) + '</li>'; ";
				js += @"         txt += '</ul>'; ";
				js += @"     } ";
				js += @"     return txt; ";
				js += @" } ";

				js += @"(function(){ return muestraArbol(nodeTree); })();";

				frame.ExecuteJavaScriptAsync(js);

				// Get Document Height
				//var task = frame.EvaluateScriptAsync("(function() {  " + js + " })();", null);
				var task = frame.EvaluateScriptAsync(js, null);

				task.ContinueWith(t =>
				{
					if (!t.IsFaulted)
					{
						var response = t.Result;
						EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;
					}
				}, TaskScheduler.FromCurrentSynchronizationContext());

				task.Wait();

				if (task.Result.Result != null)
				{
					string temp = task.Result.Result.ToString();
					Debug.Print(temp);
				}
				else
				{
					MessageBox.Show("'task.Result.Result' is null");
				}
				
			}			
	
			return;
		}

		private void TsDomTree_Load(object sender, EventArgs e)
		{
			EventClickTagButton();
		}
	}
}
