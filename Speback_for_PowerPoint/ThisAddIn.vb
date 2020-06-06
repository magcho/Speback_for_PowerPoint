Imports Microsoft.Office.Interop.PowerPoint

Public Class ThisAddIn

    Private Sub ThisAddIn_Startup() Handles Me.Startup

    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub Application_SlideShowBegin(Wn As SlideShowWindow) Handles Application.SlideShowBegin
        MsgBox("hello")

    End Sub
End Class
