Imports MySql.Data.MySqlClient

Public Class Admin
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim SelectedCRN As String
    Public StudentIDInput As String

    Dim CRN1 As Integer
    Dim CRN2 As Integer
    Dim CRN3 As Integer
    Dim CRN4 As Integer
    Dim CRN5 As Integer


    Dim Grade_Points1 As Double
    Dim Grade_Points2 As Double
    Dim Grade_Points3 As Double
    Dim Grade_Points4 As Double
    Dim Grade_Points5 As Double
    Dim Grade_Points_Total As Double

    Dim GradeG(4) As Double

    Dim Hours(4) As Double
    Dim HoursTotal As Double = 0

    Dim GPA_Final As Double = 0

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Me.Dispose()
        Login.Show()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        StudentIDtxt.Text = Nothing
        StudentGridLSTBOX.Items.Clear()
        CRNComboBox.Text = "Choose One"
        SemesterComboBox.Text = "Choose One"
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles gradeUpdatebtn.Click

        If CRNComboBox.Text = "Choose One" Or SemesterComboBox.Text = "Choose One" Then
            MessageBox.Show("Please choose from CRN Field and Semester Field")
        Else
            Me.Hide()
            updateForm.Show()
        End If

    End Sub

    Private Sub SearchIconBtn_Click(sender As Object, e As EventArgs) Handles SearchIconBtn.Click

        StudentGridLSTBOX.Items.Clear()
        CRNComboBox.Text = "Choose One"
        SemesterComboBox.Text = "Choose One"


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server = localhost; userid = root; password = cs3321; database = slmsdb"

        Dim READER1 As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim Query1 As String
            Query1 = "SELECT * FROM slmsdb.Student_Data
                        INNER JOIN slmsdb.Grade_Record
                        ON Student_Data.Student_Id = Grade_Record.Student_Id
                        WHERE Student_Data.Student_Id = '" & StudentIDtxt.Text & "';"

            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER1 = COMMAND.ExecuteReader

            While READER1.Read

                StudentIDtxt.Text = READER1.GetInt32("Student_Id")
                StudentIDInput = StudentIDtxt.Text
                ToolStripStatusLabel1.Text = "Searching..."
                SemesterComboBox.Items.Clear()
                SemesterComboBox.Items.Add(READER1.GetString("Semester"))

                StudentGridLSTBOX.Items.Add("CRN 1: " + CStr(READER1.GetInt64("CRN1")) +
                                     "; Course Grade: " + CStr(READER1.GetInt64("CourseGrade_1")))
                StudentGridLSTBOX.Items.Add("Midterm 1: " + CStr(READER1.GetInt64("Midterm_1_1")))
                StudentGridLSTBOX.Items.Add("Midterm 2: " + CStr(READER1.GetInt64("Midterm_2_1")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER1.GetInt64("Final_1")))

                StudentGridLSTBOX.Items.Add("CRN 2: " + CStr(READER1.GetInt64("CRN2")) +
                                     "; Course Grade: " + CStr(READER1.GetInt64("CourseGrade_2")))
                StudentGridLSTBOX.Items.Add("Midterm 1: " + CStr(READER1.GetInt64("Midterm_1_2")))
                StudentGridLSTBOX.Items.Add("Midterm 2: " + CStr(READER1.GetInt64("Midterm_2_2")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER1.GetInt64("Final_2")))

                StudentGridLSTBOX.Items.Add("CRN 3: " + CStr(READER1.GetInt64("CRN3")) +
                                     "; Course Grade: " + CStr(READER1.GetInt64("CourseGrade_3")))
                StudentGridLSTBOX.Items.Add("Midterm 1: " + CStr(READER1.GetInt64("Midterm_1_3")))
                StudentGridLSTBOX.Items.Add("Midterm 2: " + CStr(READER1.GetInt64("Midterm_2_3")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER1.GetInt64("Final_3")))

                StudentGridLSTBOX.Items.Add("CRN 4: " + CStr(READER1.GetInt64("CRN4")) +
                                     "; Course Grade: " + CStr(READER1.GetInt64("CourseGrade_4")))
                StudentGridLSTBOX.Items.Add("Midterm 1: " + CStr(READER1.GetInt64("Midterm_1_4")))
                StudentGridLSTBOX.Items.Add("Midterm 2: " + CStr(READER1.GetInt64("Midterm_2_4")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER1.GetInt64("Final_4")))

                StudentGridLSTBOX.Items.Add("CRN 5: " + CStr(READER1.GetInt64("CRN5")) +
                                     "; Course Grade: " + CStr(READER1.GetInt64("CourseGrade_5")))
                StudentGridLSTBOX.Items.Add("Midterm 1: " + CStr(READER1.GetInt64("Midterm_1_5")))
                StudentGridLSTBOX.Items.Add("Midterm 2: " + CStr(READER1.GetInt64("Midterm_2_5")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER1.GetInt64("Final_5")))

            End While
            ToolStripStatusLabel1.Text = "Done"

            Dim Index As Integer = 0

            Do While Index <= 4
                If READER1.GetInt64("CourseGrade_" & Index + 1 & "") <= 100 And READER1.GetInt64("CourseGrade_" & Index + 1 & "") >= 90 Then
                    GradeG(Index) = 4.0
                ElseIf READER1.GetInt64("CourseGrade_" & Index + 1 & "") <= 89 And READER1.GetInt64("CourseGrade_" & Index + 1 & "") >= 80 Then
                    GradeG(Index) = 3.0
                ElseIf READER1.GetInt64("CourseGrade_" & Index + 1 & "") <= 79 And READER1.GetInt64("CourseGrade_" & Index + 1 & "") >= 70 Then
                    GradeG(Index) = 2.0
                ElseIf READER1.GetInt64("CourseGrade_" & Index + 1 & "") <= 69 And READER1.GetInt64("CourseGrade_" & Index + 1 & "") >= 60 Then
                    GradeG(Index) = 1.0
                Else
                    GradeG(Index) = 0.0
                End If
                Index = Index + 1
            Loop

            CRN1 = READER1.GetInt64("CRN1")
            CRN2 = READER1.GetInt64("CRN2")
            CRN3 = READER1.GetInt64("CRN3")
            CRN4 = READER1.GetInt64("CRN4")
            CRN5 = READER1.GetInt64("CRN5")

            READER1.Dispose()
            COMMAND.Dispose()

            Dim Query2 As String
            Query2 = "select * from slmsdb.course_data
                        WHERE FIELD(CRN_Number, " & CRN1 & ", " & CRN2 & ", " & CRN3 & ", " & CRN4 & ", " & CRN5 & ")
                        ORDER BY FIELD(CRN_Number, " & CRN1 & ", " & CRN2 & ", " & CRN3 & ", " & CRN4 & ", " & CRN5 & ");"

            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER1 = COMMAND.ExecuteReader

            Dim count As Integer = 0
            While READER1.Read
                Hours(count) = READER1.GetInt64("Course_Hours")
                'StudentGridLSTBOX.Items.Add(CStr(Hours(count)))
                'StudentGridLSTBOX.Items.Add(CStr(GradeG(count)))
                count = count + 1
            End While

            READER1.Dispose()
            COMMAND.Dispose()

            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            Grade_Points1 = Hours(0) * GradeG(0)
            Grade_Points2 = Hours(1) * GradeG(1)
            Grade_Points3 = Hours(2) * GradeG(2)
            Grade_Points4 = Hours(3) * GradeG(3)
            Grade_Points5 = Hours(4) * GradeG(4)

            Grade_Points_Total = Grade_Points1 + Grade_Points2 + Grade_Points3 + Grade_Points4 + Grade_Points5

            HoursTotal = Hours(0) + Hours(1) + Hours(2) + Hours(3) + Hours(4)

            GPA_Final = Decimal.Round((Grade_Points_Total / HoursTotal), 2, MidpointRounding.AwayFromZero)

            GPAlbl.Text = Decimal.Round(GPA_Final, 2, MidpointRounding.AwayFromZero)
            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            Dim Query3 As String
            Query3 = "UPDATE slmsdb.gpa_data
                        SET GPA = " & CDec(GPA_Final) & "
                        WHERE Student_Id = '" & CInt(StudentIDtxt.Text) & "';"

            COMMAND = New MySqlCommand(Query3, MysqlConn)
            READER1 = COMMAND.ExecuteReader

            READER1.Dispose()
            COMMAND.Dispose()


            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try



        Try
            MysqlConn.Open()





        Catch ex As Exception

        End Try

    End Sub

    Private Sub Admin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub CRNComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CRNComboBox.SelectedIndexChanged
        If CRNComboBox.SelectedIndex = 0 Then

        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Me.Hide()
        NewStudent.Show()
    End Sub

    Private Sub StudentGridLSTBOX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentGridLSTBOX.SelectedIndexChanged

    End Sub
End Class