Imports System.Text.RegularExpressions

Public Class BreachedInfo

    Private Info As String = ""
    Private DateN As Integer = 0

    Public Sub InsertInto(ByVal RGX As String, ByVal FromR As String)
        For Each o As Match In New Regex(RGX).Matches(FromR)
            DateN += 1
            Me.Info += o.Groups(1).Value & "|" & o.Groups(4).Value & "|" & o.Groups(3).Value & vbCrLf
        Next
    End Sub

    Public Function GetInfo()
        Return Me.Info
    End Function

    Public Function GetDateN()
        Return Me.DateN
    End Function
End Class
