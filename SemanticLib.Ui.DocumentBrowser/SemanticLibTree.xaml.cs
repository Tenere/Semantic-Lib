using System.Collections;
using System.Windows.Controls;

namespace SemanticLib.Ui.DocumentBrowser
{
	public partial class SemanticLibTree : UserControl
	{
		public SemanticLibTree()
		{
			InitializeComponent();
		}

		public void Bind(IEnumerable source)
		{
			trvDocumentStructure.ItemsSource = source;
		}
	}
}
