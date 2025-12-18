Imports System.IO
Imports System.Drawing.Imaging

Public Class MainForm
    Private students As New List(Of Student)()
    Private currentStudentID As String = ""
    Private isEditing As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
        ClearForm()
        SetupDataGridView()
    End Sub

    Private Sub SetupDataGridView()
        dgvStudents.AutoGenerateColumns = False
        dgvStudents.Columns.Clear()

        Dim columns As String() = {"StudentID", "FirstName", "LastName", "Gender", "Age", "RoomNumber", "ContactNumber", "Email"}
        Dim headers As String() = {"Student ID", "First Name", "Last Name", "Gender", "Age", "Room No.", "Contact", "Email"}

        For i As Integer = 0 To columns.Length - 1
            Dim col As New DataGridViewTextBoxColumn()
            col.DataPropertyName = columns(i)
            col.HeaderText = headers(i)
            col.Name = columns(i)
            dgvStudents.Columns.Add(col)
        Next
    End Sub

    Private Sub LoadStudents()
        students = DataManager.LoadStudents()
        RefreshDataGridView()
    End Sub

    Private Sub RefreshDataGridView()
        dgvStudents.DataSource = Nothing
        dgvStudents.DataSource = students
    End Sub

    Private Sub ClearForm()
        txtStudentID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cmbGender.SelectedIndex = -1
        txtAge.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        txtRoomNumber.Text = ""
        dtpDateOfJoining.Value = Date.Today
        txtGuardianName.Text = ""
        txtGuardianContact.Text = ""
        txtAddress.Text = ""
        txtSearch.Text = ""

        picProfile.Image = Nothing
        currentStudentID = ""
        isEditing = False

        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnUpload.Enabled = False

        ' Load default image when form is cleared
        picProfile.Image = CreateDefaultProfileImage()
    End Sub

    Private Function CreateDefaultProfileImage() As Image
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

    Private Sub ValidateForm()
        If String.IsNullOrEmpty(txtStudentID.Text) Then
            Throw New Exception("Student ID is required")
        End If
        If String.IsNullOrEmpty(txtFirstName.Text) Then
            Throw New Exception("First Name is required")
        End If
        If String.IsNullOrEmpty(txtLastName.Text) Then
            Throw New Exception("Last Name is required")
        End If
        If cmbGender.SelectedIndex = -1 Then
            Throw New Exception("Gender is required")
        End If
        If Not Integer.TryParse(txtAge.Text, Nothing) Then
            Throw New Exception("Age must be a number")
        End If
        If String.IsNullOrEmpty(txtContact.Text) Then
            Throw New Exception("Contact Number is required")
        End If
        If String.IsNullOrEmpty(txtRoomNumber.Text) Then
            Throw New Exception("Room Number is required")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ClearForm()
        ' Generate a default Student ID but allow user to change it
        txtStudentID.Text = "STU" & DateTime.Now.ToString("yyyyMMddHHmmss")
        currentStudentID = txtStudentID.Text

        btnSave.Enabled = True
        btnUpload.Enabled = True
        txtStudentID.Focus() ' Focus on Student ID field first
        txtStudentID.SelectAll() ' Select all text for easy editing
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ValidateForm()

            Dim studentID As String = txtStudentID.Text.Trim()

            ' Check if Student ID already exists when adding new student
            If Not isEditing Then
                If students.Any(Function(s) s.StudentID = studentID) Then
                    Throw New Exception("Student ID already exists. Please use a different Student ID.")
                End If
            Else
                ' If editing and Student ID changed, check if new ID already exists
                If studentID <> currentStudentID Then
                    If students.Any(Function(s) s.StudentID = studentID AndAlso s.StudentID <> currentStudentID) Then
                        Throw New Exception("Student ID already exists. Please use a different Student ID.")
                    End If
                End If
            End If

            Dim student As Student

            If isEditing Then
                ' Find and update existing student
                student = students.FirstOrDefault(Function(s) s.StudentID = currentStudentID)
                If student Is Nothing Then
                    Throw New Exception("Student not found")
                End If

                ' If Student ID changed, handle image file renaming
                If student.StudentID <> studentID Then
                    ' Rename the image file if it exists
                    DataManager.RenameImage(student.StudentID, studentID)
                End If

                ' Update Student ID
                student.StudentID = studentID

            Else
                ' Create new student
                student = New Student()
                student.StudentID = studentID
                students.Add(student)
            End If

            ' Update student properties
            With student
                .FirstName = txtFirstName.Text
                .LastName = txtLastName.Text
                .Gender = cmbGender.SelectedItem.ToString()
                .Age = Integer.Parse(txtAge.Text)
                .ContactNumber = txtContact.Text
                .Email = txtEmail.Text
                .RoomNumber = txtRoomNumber.Text
                .DateOfJoining = dtpDateOfJoining.Value
                .GuardianName = txtGuardianName.Text
                .GuardianContact = txtGuardianContact.Text
                .Address = txtAddress.Text
            End With

            ' Save to JSON
            DataManager.SaveStudents(students)

            ' Update currentStudentID to the new ID
            currentStudentID = studentID

            RefreshDataGridView()
            MessageBox.Show("Student saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            isEditing = False
            btnSave.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not String.IsNullOrEmpty(currentStudentID) Then
            isEditing = True
            btnSave.Enabled = True
            btnUpload.Enabled = True

            ' Enable Student ID field for editing
            txtStudentID.ReadOnly = False
            txtStudentID.BackColor = Color.White

            MessageBox.Show("You can now edit the student details including Student ID. Click Save when done.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(currentStudentID) Then
            MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                ' Remove from list
                students.RemoveAll(Function(s) s.StudentID = currentStudentID)

                ' Delete profile picture
                DataManager.DeleteImage(currentStudentID)

                ' Save changes
                DataManager.SaveStudents(students)

                ' Refresh UI
                RefreshDataGridView()
                ClearForm()

                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error deleting student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If String.IsNullOrEmpty(currentStudentID) Then
            MessageBox.Show("Please add or select a student first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Select Profile Picture"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    ' Load and resize image
                    Dim originalImage As Image = Image.FromFile(ofd.FileName)
                    Dim resizedImage As Image = ResizeImage(originalImage, New Size(300, 300))

                    ' Save image using current Student ID
                    Dim imagePath As String = DataManager.SaveImage(resizedImage, currentStudentID)

                    ' Display image
                    picProfile.Image = resizedImage

                    ' Update student's profile picture path
                    Dim student As Student = students.FirstOrDefault(Function(s) s.StudentID = currentStudentID)
                    If student IsNot Nothing Then
                        student.ProfilePicturePath = imagePath
                        DataManager.SaveStudents(students)
                    End If

                    MessageBox.Show("Profile picture uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error uploading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Function ResizeImage(image As Image, size As Size) As Image
        Dim bitmap As New Bitmap(size.Width, size.Height)
        Using g As Graphics = Graphics.FromImage(bitmap)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(image, 0, 0, size.Width, size.Height)
        End Using
        Return bitmap
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        If String.IsNullOrEmpty(searchText) Then
            RefreshDataGridView()
            Return
        End If

        Dim filteredStudents = students.Where(Function(s) _
            s.StudentID.ToLower().Contains(searchText) OrElse
            s.FirstName.ToLower().Contains(searchText) OrElse
            s.LastName.ToLower().Contains(searchText) OrElse
            s.RoomNumber.ToLower().Contains(searchText) OrElse
            s.ContactNumber.ToLower().Contains(searchText) OrElse
            s.Email.ToLower().Contains(searchText)).ToList()

        dgvStudents.DataSource = Nothing
        dgvStudents.DataSource = filteredStudents
    End Sub

    Private Sub dgvStudents_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStudents.SelectionChanged
        If dgvStudents.SelectedRows.Count > 0 Then
            Dim selectedStudent As Student = TryCast(dgvStudents.SelectedRows(0).DataBoundItem, Student)
            If selectedStudent IsNot Nothing Then
                DisplayStudent(selectedStudent)
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnUpload.Enabled = True
            End If
        End If
    End Sub

    Private Sub DisplayStudent(student As Student)
        Try
            currentStudentID = student.StudentID

            txtStudentID.Text = student.StudentID
            txtFirstName.Text = student.FirstName
            txtLastName.Text = student.LastName

            ' Set Student ID field as read-only initially
            txtStudentID.ReadOnly = True
            txtStudentID.BackColor = Color.FromArgb(240, 240, 240) ' Light gray background

            ' Safely set gender combobox
            If Not String.IsNullOrEmpty(student.Gender) Then
                If cmbGender.Items.Contains(student.Gender) Then
                    cmbGender.SelectedItem = student.Gender
                Else
                    cmbGender.SelectedIndex = -1
                End If
            Else
                cmbGender.SelectedIndex = -1
            End If

            txtAge.Text = student.Age.ToString()
            txtContact.Text = student.ContactNumber
            txtEmail.Text = student.Email
            txtRoomNumber.Text = student.RoomNumber
            dtpDateOfJoining.Value = student.DateOfJoining
            txtGuardianName.Text = student.GuardianName
            txtGuardianContact.Text = student.GuardianContact
            txtAddress.Text = student.Address

            ' Load profile picture
            Try
                Dim profileImage As Image = DataManager.LoadImage(student.StudentID)
                If profileImage IsNot Nothing Then
                    picProfile.Image = profileImage
                Else
                    picProfile.Image = CreateDefaultProfileImage()
                End If
            Catch imgEx As Exception
                picProfile.Image = CreateDefaultProfileImage()
            End Try

        Catch ex As Exception
            MessageBox.Show("Error loading student details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadStudents()
        ClearForm()
        txtSearch.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Hostel Management System v1.0.0" & vbCrLf & "Developed using VB.NET" & vbCrLf & "© 2024", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        ' Allow only numbers and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        ' Allow only numbers, plus, hyphen, and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso e.KeyChar <> "-"c AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Clean up images to prevent memory leaks
        If picProfile.Image IsNot Nothing Then
            picProfile.Image.Dispose()
        End If
    End Sub

    ' Add a new method to handle when Student ID is being edited
    Private Sub txtStudentID_Enter(sender As Object, e As EventArgs) Handles txtStudentID.Enter
        ' When entering the Student ID field, make it editable if in edit mode
        If isEditing Then
            txtStudentID.ReadOnly = False
            txtStudentID.BackColor = Color.White
        End If
    End Sub

    Private Sub txtStudentID_Leave(sender As Object, e As EventArgs) Handles txtStudentID.Leave
        ' When leaving the Student ID field in view mode, make it read-only again
        If Not isEditing AndAlso Not String.IsNullOrEmpty(currentStudentID) Then
            txtStudentID.ReadOnly = True
            txtStudentID.BackColor = Color.FromArgb(240, 240, 240)
        End If
    End Sub
End Class