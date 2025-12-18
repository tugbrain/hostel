Imports Newtonsoft.Json
Imports System.Drawing

<Serializable()>
Public Class Student
    Public Property StudentID As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Gender As String
    Public Property Age As Integer
    Public Property ContactNumber As String
    Public Property Email As String
    Public Property RoomNumber As String
    Public Property GuardianName As String
    Public Property GuardianContact As String
    Public Property Address As String
    Public Property DateOfJoining As Date
    Public Property ProfilePicturePath As String

    Public Sub New()
        StudentID = GenerateStudentID()
        DateOfJoining = Date.Today
    End Sub

    Private Function GenerateStudentID() As String
        Return "STU" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Public Overrides Function ToString() As String
        Return $"{FirstName} {LastName} ({StudentID})"
    End Function
End Class