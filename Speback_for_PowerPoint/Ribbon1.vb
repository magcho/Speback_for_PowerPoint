
Imports Microsoft.Office.Tools.Ribbon
Imports System.Collections

Public Class Ribbon1

    Private slide_id As Integer
    Private hostName As String = "http://magcho.local:3000"
    Private syncPage As Boolean = False

    Private apiAccess As ApiAccess = New ApiAccess()


    Public apiToken As String
    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Public Function getToken()
        Return apiAccess.getToken()
    End Function

    Public Function getSyncPage()
        Return syncPage
    End Function

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
        'fetch slide info
        'Call FetchSlideInfo()


        apiAccess.setToken(EditBox1.Text)
        Dim htable As Hashtable = New Hashtable()
        htable("status") = "fetchid"
        'slide_id = PostApi("/api/v1/presentation_status", htable)
        slide_id = apiAccess.post("/api/v1/presentation_status", htable)
        Button3.Enabled = True
        CheckBox1.Enabled = True
        Button4.Enabled = True
        Label1.Label = "Spebackと正常に接続できます"




    End Sub






    Private Sub Button3_Click(sender As Object, e As RibbonControlEventArgs) Handles Button3.Click
        Globals.ThisAddIn.Application.ActivePresentation.FollowHyperlink(hostName & "/slides/" & slide_id)
    End Sub

    Private Sub Button4_Click(sender As Object, e As RibbonControlEventArgs) Handles Button4.Click
        If CheckBox1.Checked Then

        End If
        Globals.ThisAddIn.Application.ActivePresentation.SlideShowSettings.Run()

    End Sub

    Private Sub EditBox1_TextChanged(sender As Object, e As RibbonControlEventArgs) Handles EditBox1.TextChanged
        Button1.Enabled = True
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As RibbonControlEventArgs) Handles CheckBox1.Click
        syncPage = sender.Checked
    End Sub
End Class
