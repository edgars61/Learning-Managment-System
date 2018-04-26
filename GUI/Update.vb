Imports MySql.Data.MySqlClient
Public Class updateForm

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public SelectedCRN As String
    Public Midterm1 As String
    Public Midterm2 As String
    Public Final As String
    Public CourseGrade As String
    Public Semester As String

    Dim READER As MySqlDataReader

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server = localhost; userid = root; password = cs3321; database = slmsdb"



        Try
            MysqlConn.Open()

            Dim Query2 As String
            Query2 = "UPDATE slmsdb.Grade_Record 
                        SET " & SelectedCRN & " = '" & CInt(CRNtxt.Text) & "',
                        " & Midterm1 & " = '" & CInt(Midterm1txt.Text) & "',
                        " & Midterm2 & " = '" & CInt(Midterm2txt.Text) & "',
                        " & Final & " = '" & CInt(FinalMidtermtxt.Text) & "',
                        " & CourseGrade & " = '" & CInt(CourseGradetxt.Text) & "',
                        Semester = '" & Semester & "'
                        WHERE Student_Id = '" & Admin.StudentIDInput & "';"

            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER = COMMAND.ExecuteReader

            COMMAND.Dispose()
            READER.Dispose()

            Dim Query3 As String
            Query3 = "UPDATE slmsdb.GPA_Data
                        SET;"

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            READER.Dispose()
            MysqlConn.Dispose()
        End Try


    End Sub

    Private Sub updateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server = localhost; userid = root; password = cs3321; database = slmsdb"

        Try
            MysqlConn.Open()

            Dim Query1 As String
            Dim Query2 As String

            Query1 = "SELECT * FROM slmsdb.Grade_Record
                        WHERE Student_Id = '" & Admin.StudentIDtxt.Text & "';"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read

                SemesterComBox.Text = READER.GetString("Semester")

                If Admin.CRNComboBox.SelectedIndex = 0 Then
                    CRNtxt.Text = CStr(READER.GetInt64("CRN1"))
                    Midterm1txt.Text = CStr(READER.GetInt64("Midterm_1_1"))
                    Midterm2txt.Text = CStr(READER.GetInt64("Midterm_2_1"))
                    FinalMidtermtxt.Text = CStr(READER.GetInt64("Final_1"))
                    CourseGradetxt.Text = CStr(READER.GetInt64("CourseGrade_1"))

                    SelectedCRN = "CRN1"
                    Midterm1 = "Midterm_1_1"
                    Midterm2 = "Midterm_2_1"
                    Final = "Final_1"
                    CourseGrade = "CourseGrade_1"


                ElseIf Admin.CRNComboBox.SelectedIndex = 1 Then
                    CRNtxt.Text = CStr(READER.GetInt64("CRN2"))
                    Midterm1txt.Text = CStr(READER.GetInt64("Midterm_1_2"))
                    Midterm2txt.Text = CStr(READER.GetInt64("Midterm_2_2"))
                    FinalMidtermtxt.Text = CStr(READER.GetInt64("Final_2"))
                    CourseGradetxt.Text = CStr(READER.GetInt64("CourseGrade_2"))

                    SelectedCRN = "CRN2"
                    Midterm1 = "Midterm_1_2"
                    Midterm2 = "Midterm_2_2"
                    Final = "Final_2"
                    CourseGrade = "CourseGrade_2"

                ElseIf Admin.CRNComboBox.SelectedIndex = 2 Then
                    CRNtxt.Text = CStr(READER.GetInt64("CRN3"))
                    Midterm1txt.Text = CStr(READER.GetInt64("Midterm_1_3"))
                    Midterm2txt.Text = CStr(READER.GetInt64("Midterm_2_3"))
                    FinalMidtermtxt.Text = CStr(READER.GetInt64("Final_3"))
                    CourseGradetxt.Text = CStr(READER.GetInt64("CourseGrade_3"))

                    SelectedCRN = "CRN3"
                    Midterm1 = "Midterm_1_3"
                    Midterm2 = "Midterm_2_3"
                    Final = "Final_3"
                    CourseGrade = "CourseGrade_3"

                ElseIf Admin.CRNComboBox.SelectedIndex = 3 Then
                    CRNtxt.Text = CStr(READER.GetInt64("CRN4"))
                    Midterm1txt.Text = CStr(READER.GetInt64("Midterm_1_4"))
                    Midterm2txt.Text = CStr(READER.GetInt64("Midterm_2_4"))
                    FinalMidtermtxt.Text = CStr(READER.GetInt64("Final_4"))
                    CourseGradetxt.Text = CStr(READER.GetInt64("CourseGrade_4"))

                    SelectedCRN = "CRN4"
                    Midterm1 = "Midterm_1_4"
                    Midterm2 = "Midterm_2_4"
                    Final = "Final_4"
                    CourseGrade = "CourseGrade_4"

                ElseIf Admin.CRNComboBox.SelectedIndex = 4 Then
                    CRNtxt.Text = CStr(READER.GetInt64("CRN5"))
                    Midterm1txt.Text = CStr(READER.GetInt64("Midterm_1_5"))
                    Midterm2txt.Text = CStr(READER.GetInt64("Midterm_2_5"))
                    FinalMidtermtxt.Text = CStr(READER.GetInt64("Final_5"))
                    CourseGradetxt.Text = CStr(READER.GetInt64("CourseGrade_5"))

                    SelectedCRN = "CRN5"
                    Midterm1 = "Midterm_1_5"
                    Midterm2 = "Midterm_2_5"
                    Final = "Final_5"
                    CourseGrade = "CourseGrade_5"

                End If
            End While

            COMMAND.Dispose()
            READER.Dispose()

            Query2 = "SELECT * FROM slmsdb.Course_Data"
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read

                Dim Course_ID As String = READER.GetString("Course_ID")
                CRNComboBox.Items.Add(Course_ID)

            End While

            COMMAND.Dispose()
            READER.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub updateForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub updateForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Dispose()
        Admin.Show()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Midterm1txt.Text = Nothing
        Midterm2txt.Text = Nothing
        FinalMidtermtxt.Text = Nothing
        CourseGradetxt.Text = Nothing
    End Sub

    Private Sub CRNComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CRNComboBox.SelectedIndexChanged

        CourseDataLSTBOX.Items.Clear()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server = localhost; userid = root; password = cs3321; database = slmsdb"

        Try
            MysqlConn.Open()

            Dim Query1 As String

            Query1 = "SELECT * FROM slmsdb.Course_Data WHERE Course_ID = '" & CRNComboBox.Text & "';"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read

                Dim CRN_Number As Integer = READER.GetInt64("CRN_Number")
                Dim Course_ID As String = READER.GetString("Course_ID")
                Dim Course_Name As String = READER.GetString("Course_Name")
                Dim Course_Time As String = READER.GetString("Course_Time")
                Dim First_Name As String = READER.GetString("First_Name")
                Dim Last_Name As String = READER.GetString("Last_Name")
                Dim Course_Hours As Integer = READER.GetInt64("Course_Hours")

                CourseDataLSTBOX.Items.Add("CRN_Number: " + CStr(CRN_Number))
                CourseDataLSTBOX.Items.Add("Course ID: " + Course_ID)
                CourseDataLSTBOX.Items.Add("Course Name: " + Course_Name)
                CourseDataLSTBOX.Items.Add("Course Time: " + Course_Time)
                CourseDataLSTBOX.Items.Add("Professor: " + First_Name + " " + Last_Name)
                CourseDataLSTBOX.Items.Add("Course Hours: " + CStr(Course_Hours))

                CRNtxt.Text = CStr(CRN_Number)

            End While

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            READER.Dispose()
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub SemesterComBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SemesterComBox.SelectedIndexChanged
        If SemesterComBox.SelectedIndex = 0 Then
            Semester = "Fall2017"
        ElseIf SemesterComBox.SelectedIndex = 1 Then
            Semester = "Spring2017"
        Else
            Semester = "Not Enrolled"
        End If
    End Sub
End Class
