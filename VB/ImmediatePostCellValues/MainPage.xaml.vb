Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace ImmediatePostCellValues
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New ProductList()
		End Sub

		Private Sub TableView_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.CellValueChangedEventArgs)
			TryCast(sender, TableView).PostEditor()
		End Sub
	End Class
End Namespace
