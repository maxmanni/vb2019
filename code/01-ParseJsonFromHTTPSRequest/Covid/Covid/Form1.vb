Imports System.IO
Imports System.Net
Imports Newtonsoft.Json


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Carica.Click
        ' Create a request for the URL.   
        Dim request As WebRequest = WebRequest.Create("https://raw.githubusercontent.com/pcm-dpc/COVID-19/master/dati-json/dpc-covid19-ita-regioni-latest.json")
        ' If required by the server, set the credentials.  
        request.Credentials = CredentialCache.DefaultCredentials

        ' Get the response.  
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.  
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)

        ' Get the stream containing content returned by the server. 
        ' The using block ensures the stream is automatically closed.
        Using dataStream As Stream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.  
            Dim reader As New StreamReader(dataStream)
            ' Read the content.  
            Dim responseFromServer As String = reader.ReadToEnd()
            ' Display the content.  
            rtbJsonData.Text = responseFromServer

            Deserialize()

        End Using

        ' Clean up the response.
        response.Close()
    End Sub


    Public Sub Deserialize()

        Dim listaRegioni As List(Of DatiCovidRegione)
        listaRegioni = JsonConvert.DeserializeObject(Of List(Of DatiCovidRegione))(rtbJsonData.Text)

        For Each r In listaRegioni
            cbRegioni.Items.Add(r)
        Next

        If (listaRegioni.Count > 0) Then
            cbRegioni.SelectedItem = cbRegioni.Items(0)
        End If

    End Sub


    Private Sub cbRegioni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRegioni.SelectedIndexChanged
        Dim currentElement As DatiCovidRegione
        currentElement = cbRegioni.SelectedItem
        txtTotale.Text = currentElement.TotaleCasi.ToString()
        txtDeceduti.Text = currentElement.Deceduti.ToString()
        txtGuariti.Text = currentElement.DimessiGuariti.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
