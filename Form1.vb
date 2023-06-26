﻿Public Class Form1
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
                End If
            Else
                add()
            End If

        Else
            MessageBox.Show("Please type some data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Function add()
        Lst_Month.Items.Add(Txt_Data.Text)
        Txt_Data.Clear()
        'MessageBox.Show("Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return Nothing
    End Function

    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        Lst_Month.Items.Remove(Lst_Month.SelectedItem)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Move to another list box
        'remove it from old box
        If Lst_Month.SelectedIndex > -1 Then
            Lst_Transfer.Items.Add(Lst_Month.SelectedItem)
            Lst_Month.Items.Remove(Lst_Month.SelectedItem)
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item As String In Lst_Month.Items
            Lst_Transfer.Items.Add(item)
        Next
        Lst_Month.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class