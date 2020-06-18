Imports System.IO
Imports System.Net
Imports System.Collections

Public Class ApiAccess
    Private apiHostName As String = "http://magcho.local:3000"
    Private apiToken As String

    Public Sub setToken(token As String)
        apiToken = token
    End Sub
    Public Function getToken()
        Return apiToken
    End Function
    Public Function post(endpoint As String, paramHash As Hashtable)

        paramHash("token") = apiToken
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

End Class
