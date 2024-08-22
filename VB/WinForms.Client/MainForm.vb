Imports DevExpress.XtraEditors

Namespace WinForms.Client

    Public Partial Class MainForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private loader As VirtualServerModeDataLoader?

        Private Sub VirtualServerModeSource_ConfigurationChanged(ByVal sender As Object?, ByVal e As DevExpress.Data.VirtualServerModeRowsEventArgs)
            loader = New VirtualServerModeDataLoader(e.ConfigurationInfo)
            e.RowsTask = loader.GetRowsAsync(e)
        End Sub

        Private Sub VirtualServerModeSource_MoreRows(ByVal sender As Object?, ByVal e As DevExpress.Data.VirtualServerModeRowsEventArgs)
            If TypeOf loader Is [not] Then Nothing
            If True Then
                e.RowsTask = loader.GetRowsAsync(e)
            End If
        End Sub
    End Class
End Namespace
