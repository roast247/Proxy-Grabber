Imports System.Text.RegularExpressions
Imports System.Text

Public Class Form1
    Private draggable As Boolean
    Private mouseY As Integer
    Private mouseX As Integer
    Dim NewPoint As New System.Drawing.Point
    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Close()
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingPic_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingPic_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingPic_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseUp
        draggable = False
    End Sub

    Private Sub getProxy_Click(sender As Object, e As EventArgs) Handles getProxy.Click
        If RadioButton1.Checked Then
            Dim the_request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://sslproxies24.blogspot.com/feeds/posts/default")
            Dim the_response As System.Net.HttpWebResponse = the_request.GetResponse
            Dim stream_reader As System.IO.StreamReader = New System.IO.StreamReader(the_response.GetResponseStream())
            Dim code As String = stream_reader.ReadToEnd
            Dim expression As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim mtac As MatchCollection = expression.Matches(code)
            For Each itemcode As Match In mtac
                ListBox1.Items.Add(itemcode)
            Next
        End If
        If RadioButton2.Checked Then
            Dim the_request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.socks24.org/feeds/posts/default")
            Dim the_response As System.Net.HttpWebResponse = the_request.GetResponse
            Dim stream_reader As System.IO.StreamReader = New System.IO.StreamReader(the_response.GetResponseStream())
            Dim code As String = stream_reader.ReadToEnd
            Dim expression As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim mtac As MatchCollection = expression.Matches(code)
            For Each itemcode As Match In mtac
                ListBox1.Items.Add(itemcode)
            Next
        End If
        If RadioButton3.Checked Then
            Dim the_request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://sslproxies24.blogspot.com/feeds/posts/default")
            Dim the_response As System.Net.HttpWebResponse = the_request.GetResponse
            Dim stream_reader As System.IO.StreamReader = New System.IO.StreamReader(the_response.GetResponseStream())
            Dim code As String = stream_reader.ReadToEnd
            Dim expression As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim mtac As MatchCollection = expression.Matches(code)
            For Each itemcode As Match In mtac
                ListBox1.Items.Add(itemcode)
            Next
        End If
        If RadioButton4.Checked Then
            Dim the_request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.socks24.org/2016/08/02-08-16-socks-45-uncommon-ports_13.html")
            Dim the_response As System.Net.HttpWebResponse = the_request.GetResponse
            Dim stream_reader As System.IO.StreamReader = New System.IO.StreamReader(the_response.GetResponseStream())
            Dim code As String = stream_reader.ReadToEnd
            Dim expression As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim mtac As MatchCollection = expression.Matches(code)
            For Each itemcode As Match In mtac
                ListBox1.Items.Add(itemcode)
            Next
        End If
        If RadioButton5.Checked Then
            Dim the_request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://sockslist.net/list/proxy-socks-4-list/")
            Dim the_response As System.Net.HttpWebResponse = the_request.GetResponse
            Dim stream_reader As System.IO.StreamReader = New System.IO.StreamReader(the_response.GetResponseStream())
            Dim code As String = stream_reader.ReadToEnd
            Dim expression As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim mtac As MatchCollection = expression.Matches(code)
            For Each itemcode As Match In mtac
                ListBox1.Items.Add(itemcode)
            Next
        End If
    End Sub

    Private Sub clrList_Click(sender As Object, e As EventArgs) Handles clrList.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub svList_Click(sender As Object, e As EventArgs) Handles svList.Click
        If ListBox1.Items.Count = (0) Then
            MessageBox.Show("Please Grab Proxies First.", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim S_W As IO.StreamWriter

            Dim itms() As String = {ListBox1.Items.ToString}

            Dim save As New SaveFileDialog
            Dim it As Integer
            save.FileName = "Grabbed Proxies"
            save.Filter = "Grabbed Proxies (*.txt)|*.txt|ALL Files (*.*)|*.*"
            save.CheckPathExists = True
            save.ShowDialog(Me)
            S_W = New IO.StreamWriter(save.FileName)
            For it = 0 To ListBox1.Items.Count - 1
                S_W.WriteLine(ListBox1.Items.Item(it))
            Next
            S_W.Close()
        End If
    End Sub
End Class