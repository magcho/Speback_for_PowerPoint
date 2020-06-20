Imports Microsoft.Office.Interop.PowerPoint
Imports System.Collections
Public Class ThisAddIn
    Private apiAccess As ApiAccess = New ApiAccess()
    Private clickedSlideStartButton As Boolean = False

    Private Sub ThisAddIn_Startup() Handles Me.Startup

    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub Application_SlideShowBegin(Wn As SlideShowWindow) Handles Application.SlideShowBegin
        apiAccess.setToken(Globals.Ribbons.Ribbon1.getToken())
    End Sub



    Private Sub Change_page(index As Integer)
        Dim htable As Hashtable = New Hashtable()
        htable("page_num") = index
        apiAccess.post("/api/v1/page_change", htable)
    End Sub



    Private Sub Application_SlideShowNextSlide(Wn As SlideShowWindow) Handles Application.SlideShowNextSlide
        clickedSlideStartButton = True
        If clickedSlideStartButton And Globals.Ribbons.Ribbon1.getSyncPage Then
            Change_page(Wn.View.CurrentShowPosition - 1)
        End If
    End Sub

    Private Sub Application_SlideShowEnd(Pres As Presentation) Handles Application.SlideShowEnd
        clickedSlideStartButton = False
    End Sub
End Class
