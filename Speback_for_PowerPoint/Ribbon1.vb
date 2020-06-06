Imports System.IO
Imports System.Net
Imports Microsoft.Office.Tools.Ribbon
Imports System.Collections

Public Class Ribbon1

    Private slide_id As Integer
    Private page_num As Integer
    Private apiHostName As String = "http://magcho.local:3000"
    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
        Call FetchSlideInfo()

        Dim htable As Hashtable = New Hashtable()
        htable("token") = "aabcc"
        Call PostApi("/api/v1/presentation_status", htable)
    End Sub



    Private Sub FetchSlideInfo()
        'get token
        Dim token As String = EditBox1.Text

        'build parameter
        Dim params As String = "token=" & token
        Dim data As Byte() = Encoding.ASCII.GetBytes(params)


        'create request
        Dim ApiReq As HttpWebRequest = HttpWebRequest.Create("http://magcho.local:3000/api/v1/presentation_status")
        ApiReq.Method = "POST"
        ApiReq.ContentType = "application/x-www-form-urlencoded"
        ApiReq.ContentLength = data.Length

        Dim reqStream As Stream = ApiReq.GetRequestStream()
        reqStream.Write(data, 0, data.Length)
        reqStream.Close()



        ' Response
        Dim response As WebResponse = ApiReq.GetResponse()
        Dim resStream As Stream = response.GetResponseStream()
        Dim resStreamReader As StreamReader = New StreamReader(resStream, Encoding.UTF8)
        Dim resString As String = resStreamReader.ReadToEnd()
        resStreamReader.Close()
        resStream.Close()

        MsgBox(resString)



    End Sub

    Private Function PostApi(endpoint As String, paramHash As Hashtable)


        Dim strParams As String = ""
        For Each k As String In paramHash.Keys
            strParams = strParams & String.Format("{0}={1}&", k, paramHash(k))
        Next
        Dim data As Byte() = Encoding.ASCII.GetBytes(strParams)


        ' create request
        Dim ApiReq As HttpWebRequest = HttpWebRequest.Create(apiHostName & endpoint)
        ApiReq.Method = "POST"
        ApiReq.ContentType = "application/x-www-form-urlencoded"
        ApiReq.ContentLength = data.Length

        Dim reqStream As Stream = ApiReq.GetRequestStream()
        reqStream.Write(data, 0, data.Length)
        reqStream.Close()



        ' Response
        Dim response As WebResponse = ApiReq.GetResponse()
        Dim resStream As Stream = response.GetResponseStream()
        Dim resStreamReader As StreamReader = New StreamReader(resStream, Encoding.UTF8)
        Dim resString As String = resStreamReader.ReadToEnd()
        resStreamReader.Close()
        resStream.Close()


        Return resString


    End Function



    Private Sub EditBox1_TextChanged(sender As Object, e As RibbonControlEventArgs) Handles EditBox1.TextChanged

    End Sub
End Class
