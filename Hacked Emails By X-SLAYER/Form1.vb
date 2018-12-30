Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Text
Imports System.IO


'=========================CODED BY X-SLAYER==============================
'========================================================================
'=YOUTUBE : >> SUBSCRIBE FOR MORE :https://www.youtube.com/c/XSLAYERTN  |
'=FACEBOOK : >> https://www.facebook.com/XSLAYER404/                    |
'=INSTAGRAM : >> https://www.instagram.com/ih3_b                        |
'=GITHUB : >> https://github.com/X-SLAYER                               |
'========================================================================

Public Class Form1

    Public Sub New()
        InitializeComponent()
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12
    End Sub

    Dim ITEM As New Dictionary(Of WebClient, ListViewItem)

    Private Sub BTN_Check_Click(sender As Object, e As EventArgs) Handles BTN_Check.Click
        If Not Regex.IsMatch(txtmail.Text, "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}") Then
            Exit Sub
        End If
        HACKED(txtmail.Text)
        txtmail.Text = String.Empty
    End Sub

    Public Sub HACKED(ByVal Email As String)
        On Error Resume Next
        Dim ITM As New ListViewItem
        ITM.UseItemStyleForSubItems = False
        ITM.Text = Email
        ITM.SubItems.Add("Checking...").ForeColor = Color.Blue
        ITM.SubItems.Add("Checking...").ForeColor = Color.Blue
        LV.Items.Add(ITM)
        Using W As New WebClient
            W.Proxy = Nothing
            W.Encoding = New UTF8Encoding
            W.Encoding = Encoding.UTF8
            W.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/6.0;)")
            W.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8")
            AddHandler W.DownloadDataCompleted, AddressOf COMPLETE
            W.DownloadDataAsync(New Uri("https://haveibeenpwned.com/api/v2/breachedaccount/" & Email))
            ITEM.Add(W, ITM)
        End Using
    End Sub

    Private Sub COMPLETE(sender As Object, e As DownloadDataCompletedEventArgs)
        If e.Cancelled = True Then
            LV.Items(ITEM(sender).Index).ForeColor = Color.LightGoldenrodYellow
            LV.Items(ITEM(sender).Index).SubItems(2).ForeColor = Color.LightGoldenrodYellow
            LV.Items(ITEM(sender).Index).SubItems(1).ForeColor = Color.LightGoldenrodYellow
            LV.Items(ITEM(sender).Index).SubItems(1).Text = "Canceled !!"
            LV.Items(ITEM(sender).Index).SubItems(2).Text = "Canceled !!"
        ElseIf e.Error IsNot Nothing Then
            If e.Error.ToString.Contains("429") Then
                LV.Items(ITEM(sender).Index).SubItems(1).ForeColor = Color.Orange
                LV.Items(ITEM(sender).Index).SubItems(1).Text = "The owner of this website (haveibeenpwned.com) has banned you temporarily from accessing this website."
                LV.Items(ITEM(sender).Index).SubItems(2).ForeColor = Color.Orange
                LV.Items(ITEM(sender).Index).SubItems(2).Text = "The owner of this website (haveibeenpwned.com) has banned you temporarily from accessing this website."
            Else
                GoTo Safe
            End If
        ElseIf e.Result IsNot Nothing Then
            Dim result As String = (New UTF8Encoding).GetString(e.Result)
            If result.Contains("[{") Then
                LV.Items(ITEM(sender).Index).SubItems(1).ForeColor = Color.Red
                LV.Items(ITEM(sender).Index).SubItems(1).Text = "Hacked !!"
                LV.Items(ITEM(sender).Index).SubItems(2).ForeColor = Color.Red
                Dim SLAYER As BreachedInfo = New BreachedInfo()
                SLAYER.InsertInto("{""Name"":""(.*?)"",""Title"":""(.*?)"",""Domain"":""(.*?)"",""BreachDate"":""(.*?)"",", result)
                LV.Items(ITEM(sender).Index).SubItems(2).Text = SLAYER.GetDateN()
                LV.Items(ITEM(sender).Index).Tag = SLAYER
            Else
Safe:
                LV.Items(ITEM(sender).Index).SubItems(1).ForeColor = Color.Green
                LV.Items(ITEM(sender).Index).SubItems(1).Text = "Safe !!"
                LV.Items(ITEM(sender).Index).SubItems(2).ForeColor = Color.Green
                LV.Items(ITEM(sender).Index).SubItems(2).Text = "Safe !!"
            End If
        End If
    End Sub

    Private Sub AccountInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountInfoToolStripMenuItem.Click
        If LV.SelectedItems.Count = 0 Or LV.FocusedItem.SubItems(1).Text <> "Hacked !!" Then
            Exit Sub
        End If
        For Each Itm As ListViewItem In LV.SelectedItems
            Dim FRM As New Info()
            FRM.Text = "Info : " & LV.FocusedItem.Text
            For Each Str As String In LV.FocusedItem.Tag.GetInfo().Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
                Dim IT As New ListViewItem
                IT.UseItemStyleForSubItems = False
                IT.Text = Str.Split("|")(0)
                IT.SubItems.Add(Str.Split("|")(1).Split("T")(0))
                IT.SubItems.Add(Str.Split("|")(2)).Font = New Font("tahoma", 8.5, FontStyle.Regular Or FontStyle.Underline)
                IT.SubItems(2).ForeColor = Color.Blue
                FRM.LV.Items.Add(IT)
            Next
            FRM.Show()
        Next
    End Sub

#Region "Drag Combos Or Emails"

    Private Sub LV_DragDrop(sender As Object, e As DragEventArgs) Handles LV.DragDrop
        For Each Email As String In File.ReadAllLines(e.Data.GetData(DataFormats.FileDrop)(0))
            If Regex.IsMatch(Email, "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}") Then
                Try
                    HACKED(Email.Split(":")(0))
                Catch ex As Exception
                    HACKED(Email)
                End Try
            End If
        Next
    End Sub

    Private Sub LV_DragEnter(sender As Object, e As DragEventArgs) Handles LV.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

#End Region

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start(LinkLabel3.Text)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.facebook.com/XSLAYER404/")
    End Sub
End Class
