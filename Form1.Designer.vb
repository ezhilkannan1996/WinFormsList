<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Lst_Month = New ListBox()
        Btn_Add = New Button()
        Btn_Remove = New Button()
        Txt_Data = New TextBox()
        Lst_Transfer = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lbl_left_selected_row = New Label()
        lbl_left_count = New Label()
        lbl_right_selected_row = New Label()
        lbl_right_count = New Label()
        lbl_alert = New Label()
        SuspendLayout()
        ' 
        ' Lst_Month
        ' 
        Lst_Month.FormattingEnabled = True
        Lst_Month.ItemHeight = 15
        Lst_Month.Location = New Point(34, 90)
        Lst_Month.Name = "Lst_Month"
        Lst_Month.Size = New Size(184, 259)
        Lst_Month.TabIndex = 0
        ' 
        ' Btn_Add
        ' 
        Btn_Add.Location = New Point(224, 49)
        Btn_Add.Name = "Btn_Add"
        Btn_Add.Size = New Size(75, 23)
        Btn_Add.TabIndex = 1
        Btn_Add.Text = "Add"
        Btn_Add.UseVisualStyleBackColor = True
        ' 
        ' Btn_Remove
        ' 
        Btn_Remove.Location = New Point(224, 78)
        Btn_Remove.Name = "Btn_Remove"
        Btn_Remove.Size = New Size(75, 23)
        Btn_Remove.TabIndex = 2
        Btn_Remove.Text = "Remove"
        Btn_Remove.UseVisualStyleBackColor = True
        ' 
        ' Txt_Data
        ' 
        Txt_Data.Location = New Point(34, 49)
        Txt_Data.Name = "Txt_Data"
        Txt_Data.Size = New Size(184, 23)
        Txt_Data.TabIndex = 3
        ' 
        ' Lst_Transfer
        ' 
        Lst_Transfer.FormattingEnabled = True
        Lst_Transfer.ItemHeight = 15
        Lst_Transfer.Location = New Point(421, 90)
        Lst_Transfer.Name = "Lst_Transfer"
        Lst_Transfer.Size = New Size(191, 259)
        Lst_Transfer.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(340, 188)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Transfer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(340, 217)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 6
        Button2.Text = "Transfer All"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 366)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 15)
        Label1.TabIndex = 7
        Label1.Text = "Selected row no :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(421, 366)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 8
        Label2.Text = "Selected row no :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 392)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 9
        Label3.Text = "Count :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(421, 392)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 10
        Label4.Text = "Count :"
        ' 
        ' lbl_left_selected_row
        ' 
        lbl_left_selected_row.AutoSize = True
        lbl_left_selected_row.Location = New Point(131, 366)
        lbl_left_selected_row.Name = "lbl_left_selected_row"
        lbl_left_selected_row.Size = New Size(0, 15)
        lbl_left_selected_row.TabIndex = 11
        ' 
        ' lbl_left_count
        ' 
        lbl_left_count.AutoSize = True
        lbl_left_count.Location = New Point(131, 392)
        lbl_left_count.Name = "lbl_left_count"
        lbl_left_count.Size = New Size(0, 15)
        lbl_left_count.TabIndex = 12
        ' 
        ' lbl_right_selected_row
        ' 
        lbl_right_selected_row.AutoSize = True
        lbl_right_selected_row.Location = New Point(511, 366)
        lbl_right_selected_row.Name = "lbl_right_selected_row"
        lbl_right_selected_row.Size = New Size(0, 15)
        lbl_right_selected_row.TabIndex = 13
        ' 
        ' lbl_right_count
        ' 
        lbl_right_count.AutoSize = True
        lbl_right_count.Location = New Point(513, 392)
        lbl_right_count.Name = "lbl_right_count"
        lbl_right_count.Size = New Size(0, 15)
        lbl_right_count.TabIndex = 14
        ' 
        ' lbl_alert
        ' 
        lbl_alert.ForeColor = Color.DarkBlue
        lbl_alert.Location = New Point(224, 261)
        lbl_alert.Name = "lbl_alert"
        lbl_alert.Size = New Size(191, 66)
        lbl_alert.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(651, 431)
        Controls.Add(lbl_alert)
        Controls.Add(lbl_right_count)
        Controls.Add(lbl_right_selected_row)
        Controls.Add(lbl_left_count)
        Controls.Add(lbl_left_selected_row)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Lst_Transfer)
        Controls.Add(Txt_Data)
        Controls.Add(Btn_Remove)
        Controls.Add(Btn_Add)
        Controls.Add(Lst_Month)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lst_Month As ListBox
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Remove As Button
    Friend WithEvents Txt_Data As TextBox
    Friend WithEvents Lst_Transfer As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_left_selected_row As Label
    Friend WithEvents lbl_left_count As Label
    Friend WithEvents lbl_right_selected_row As Label
    Friend WithEvents lbl_right_count As Label
    Friend WithEvents lbl_alert As Label
End Class
