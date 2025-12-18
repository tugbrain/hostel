Imports Newtonsoft.Json
Imports System.IO
Imports System.Collections.Generic
Imports System.Drawing

Public Class DataManager
    Private Shared ReadOnly dataFilePath As String = Path.Combine(Application.StartupPath, "students.json")
    Private Shared ReadOnly imagesFolder As String = Path.Combine(Application.StartupPath, "StudentImages")

    Public Shared Function LoadStudents() As List(Of Student)
        If Not File.Exists(dataFilePath) Then
            Return New List(Of Student)()
        End If

        Try
            Dim json As String = File.ReadAllText(dataFilePath)
            Return JsonConvert.DeserializeObject(Of List(Of Student))(json)
        Catch ex As Exception
            Return New List(Of Student)()
        End Try
    End Function

    Public Shared Sub SaveStudents(students As List(Of Student))
        Try
            Dim json As String = JsonConvert.SerializeObject(students, Formatting.Indented)
            File.WriteAllText(dataFilePath, json)
        Catch ex As Exception
            Throw New Exception("Error saving data: " & ex.Message)
        End Try
    End Sub

    Public Shared Function SaveImage(image As Image, studentID As String) As String
        If Not Directory.Exists(imagesFolder) Then
            Directory.CreateDirectory(imagesFolder)
        End If

        Dim imagePath As String = Path.Combine(imagesFolder, $"{studentID}.jpg")

        Try
            ' Delete existing image if any
            If File.Exists(imagePath) Then
                File.Delete(imagePath)
            End If

            ' Save the new image
            image.Save(imagePath, Imaging.ImageFormat.Jpeg)
            Return imagePath
        Catch ex As Exception
            Throw New Exception("Error saving image: " & ex.Message)
        End Try
    End Function

    Public Shared Function LoadImage(studentID As String) As Image
        Try
            Dim imagePath As String = Path.Combine(imagesFolder, $"{studentID}.jpg")

            If File.Exists(imagePath) Then
                ' Load image from file
                Return Image.FromFile(imagePath)
            Else
                ' Return a default image or Nothing
                Return CreateDefaultProfileImage()
            End If
        Catch ex As Exception
            ' Return default image if there's any error
            Return CreateDefaultProfileImage()
        End Try
    End Function

    Private Shared Function CreateDefaultProfileImage() As Image
        ' Create a simple default profile image
        Dim bitmap As New Bitmap(300, 300)
        Using g As Graphics = Graphics.FromImage(bitmap)
            g.Clear(Color.LightGray)

            ' Draw a simple person icon
            Dim brush As New SolidBrush(Color.DarkGray)
            g.FillEllipse(brush, 75, 50, 150, 150)  ' Head
            g.FillRectangle(brush, 75, 200, 150, 100)  ' Body

            ' Add text
            Dim font As New Font("Arial", 24, FontStyle.Bold)
            Dim textBrush As New SolidBrush(Color.White)
            Dim textRect As New RectangleF(0, 120, 300, 60)
            Dim sf As New StringFormat()
            sf.Alignment = StringAlignment.Center
            sf.LineAlignment = StringAlignment.Center

            g.DrawString("No Image", font, textBrush, textRect, sf)

            brush.Dispose()
            font.Dispose()
            textBrush.Dispose()
        End Using

        Return bitmap
    End Function

    Public Shared Sub DeleteImage(studentID As String)
        Dim imagePath As String = Path.Combine(imagesFolder, $"{studentID}.jpg")
        If File.Exists(imagePath) Then
            Try
                File.Delete(imagePath)
            Catch ex As Exception
                ' Log error if needed
                Debug.WriteLine("Error deleting image: " & ex.Message)
            End Try
        End If
    End Sub
    Public Shared Sub RenameImage(oldStudentID As String, newStudentID As String)
        Try
            Dim oldImagePath As String = Path.Combine(imagesFolder, $"{oldStudentID}.jpg")
            Dim newImagePath As String = Path.Combine(imagesFolder, $"{newStudentID}.jpg")

            If File.Exists(oldImagePath) Then
                ' Delete new image if it already exists (shouldn't happen due to validation)
                If File.Exists(newImagePath) Then
                    File.Delete(newImagePath)
                End If

                ' Rename the file
                File.Move(oldImagePath, newImagePath)
            End If
        Catch ex As Exception
            Debug.WriteLine("Error renaming image: " & ex.Message)
        End Try
    End Sub
End Class