Public Class Info

    Private Sub LV_DoubleClick(sender As Object, e As EventArgs) Handles LV.DoubleClick
        Process.Start(LV.FocusedItem.SubItems(2).Text)
    End Sub
End Class