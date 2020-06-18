
Imports Microsoft.Office.Tools.Ribbon
Imports System.Collections

Public Class Ribbon1

    Private slide_id As Integer
    Private hostName As String = "http://magcho.local:3000"

    Private apiAccess As ApiAccess = New ApiAccess()


    Public apiToken As String
    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Public Function getToken()
        Return apiAccess.getToken()
    End Function

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
        'fetch slide info
        'Call FetchSlideInfo()


        apiAccess.setToken(EditBox1.Text)
        Dim htable As Hashtable = New Hashtable()
        htable("status") = "fetchid"
        'slide_id = PostApi("/api/v1/presentation_status", htable)
        slide_id = apiAccess.post("/api/v1/presentation_status", htable)
        Button2.Enabled = True
        Button3.Enabled = True



    End Sub






    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs) Handles Button2.Click
        Globals.ThisAddIn.Application.ActivePresentation.FollowHyperlink(hostName & "/slides/" & slide_id)
    End Sub

    Private Sub Button3_Click(sender As Object, e As RibbonControlEventArgs) Handles Button3.Click
        Globals.ThisAddIn.Application.ActivePresentation.FollowHyperlink(hostName & "/slides/" & slide_id)
    End Sub

    Private Sub Button4_Click(sender As Object, e As RibbonControlEventArgs) Handles Button4.Click
        Globals.ThisAddIn.Application.ActivePresentation.SlideShowSettings.Run()
    End Sub
End Class
