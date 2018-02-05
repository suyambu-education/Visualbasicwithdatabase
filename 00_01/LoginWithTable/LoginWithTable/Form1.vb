Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection
    Dim cmd, pcmd As SqlCommand
    Dim DataAdapter, pDataAdapter As SqlDataAdapter
    Dim DataReder, pDataReader As SqlDataReader
    Dim tbl, ptbl As DataTable

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles shhdbtn.Click
        If sh = 0 Then
            sh = 1
            shhdbtn.BackgroundImage = My.Resources.show_hide_password_11_512
            PasswordTxt.PasswordChar = ""

        ElseIf sh = 1 Then
            sh = 0
            shhdbtn.BackgroundImage = My.Resources.show_hide_password_12_512
            PasswordTxt.PasswordChar = "+"
        End If
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Me.Close()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clears()
    End Sub
    Public Sub clears()
        usrname.Clear()
        PasswordTxt.Clear()
    End Sub

    Dim userid, password As String
    Dim sh As Int16

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("SERVER=Bluedyne-004; Database=LoginDb; User Id=sa;Password=14uit007")
        con.Open()
        sh = 0
        shhdbtn.BackgroundImage = My.Resources.show_hide_password_12_512




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        cmd = New SqlCommand("select * from Usr where Usrname='" & usrname.Text & "'", con)
        'DataReder = cmd.ExecuteReader()
        DataAdapter = New SqlDataAdapter(cmd)
        tbl = New DataTable()

        DataAdapter.Fill(tbl)
        If tbl.Rows.Count() <= 0 Then
            MsgBox("User Name is not valid")
            usrname.Focus()
        Else
            DataReder = cmd.ExecuteReader()
            While DataReder.Read()
                userid = DataReder("UID")
            End While
            con.Close()
            con.Open()
            pcmd = New SqlCommand("select * from psswd where UID='" & userid & "'", con)

            pDataReader = pcmd.ExecuteReader()
            While pDataReader.Read()
                password = pDataReader("psswd")
            End While
            If PasswordTxt.Text = password Then
                MsgBox("LogIn Success !")
            Else
                MsgBox("Password Wrong !")
                PasswordTxt.Focus()
            End If
            con.Close()

        End If

    End Sub
End Class
