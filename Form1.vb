Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        If Not String.IsNullOrEmpty(Txt_Data.Text.Trim) Then

            Dim itemToAdd As String = Txt_Data.Text.Trim.ToLower()

            If Lst_Month.Items.Count() > 0 Then

                Dim exist As New Boolean

                For Each existingItem As String In Lst_Month.Items
                    If existingItem.ToLower() = itemToAdd Then
                        Txt_Data.Clear()
                        exist = True
                        MessageBox.Show("Already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Next

                If Not exist Then
                    add()
                    lbl_alert.Text = "successfully added"
                End If
            Else
                add()
                lbl_alert.Text = "successfully added"
            End If

        Else
            MessageBox.Show("Please type some data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        DataRefresh()
    End Sub

    Public Function add()
        Lst_Month.Items.Add(Txt_Data.Text)
        Txt_Data.Clear()
        'MessageBox.Show("Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return Nothing
    End Function

    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        Lst_Month.Items.Remove(Lst_Month.SelectedItem)
        DataRefresh()
        lbl_alert.Text = "successfully removed"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Lst_Month.SelectedIndex > -1 Then

            Dim itemToTransfer As String = Lst_Month.SelectedItem.ToString().Trim().ToLower()

            If Lst_Transfer.Items.Count() > 0 Then

                Dim exist As New Boolean

                For Each existingItem As String In Lst_Transfer.Items
                    If existingItem.ToLower() = itemToTransfer Then
                        exist = True
                        MessageBox.Show("Already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Next

                If Not exist Then
                    Lst_Transfer.Items.Add(Lst_Month.SelectedItem)
                    Lst_Month.Items.Remove(Lst_Month.SelectedItem)
                    lbl_alert.Text = "transfer success"
                End If
            Else
                Lst_Transfer.Items.Add(Lst_Month.SelectedItem)
                Lst_Month.Items.Remove(Lst_Month.SelectedItem)
                lbl_alert.Text = "transfer success"
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        DataRefresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item As String In Lst_Month.Items
            Lst_Transfer.Items.Add(item)
        Next
        Lst_Month.Items.Clear()
        lbl_alert.Text = "successfully added"
        DataRefresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataRefresh()
    End Sub

    Public Function DataRefresh()
        lbl_left_count.Text = Lst_Month.Items.Count()
        lbl_right_count.Text = Lst_Transfer.Items.Count()
        selectRow()
        Return Nothing
    End Function

    Public Function selectRow()
        lbl_left_selected_row.Text = Lst_Month.SelectedIndex + 1
        lbl_right_selected_row.Text = Lst_Transfer.SelectedIndex + 1
        Return Nothing
    End Function

    Private Sub Lst_Month_Click(sender As Object, e As EventArgs) Handles Lst_Month.Click
        selectRow()
        lbl_alert.Text = String.Empty
    End Sub

    Private Sub Lst_Transfer_Click(sender As Object, e As EventArgs) Handles Lst_Transfer.Click
        selectRow()
        lbl_alert.Text = String.Empty
    End Sub

    Private Sub Txt_Data_Click(sender As Object, e As EventArgs) Handles Txt_Data.Click
        lbl_alert.Text = String.Empty
    End Sub
End Class
