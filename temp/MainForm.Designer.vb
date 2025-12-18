<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        panel1 = New Panel()
        label1 = New Label()
        panel2 = New Panel()
        pictureBox1 = New PictureBox()
        panel3 = New Panel()
        btnClear = New Button()
        btnRefresh = New Button()
        btnUpload = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnSave = New Button()
        btnAdd = New Button()
        groupBox1 = New GroupBox()
        picProfile = New PictureBox()
        groupBox2 = New GroupBox()
        txtSearch = New TextBox()
        btnSearch = New Button()
        dgvStudents = New DataGridView()
        groupBox3 = New GroupBox()
        txtAddress = New TextBox()
        Label13 = New Label()
        txtGuardianContact = New TextBox()
        Label12 = New Label()
        txtGuardianName = New TextBox()
        Label11 = New Label()
        dtpDateOfJoining = New DateTimePicker()
        Label10 = New Label()
        txtRoomNumber = New TextBox()
        Label9 = New Label()
        txtEmail = New TextBox()
        Label8 = New Label()
        txtContact = New TextBox()
        Label7 = New Label()
        txtAge = New TextBox()
        Label6 = New Label()
        cmbGender = New ComboBox()
        Label5 = New Label()
        txtLastName = New TextBox()
        Label4 = New Label()
        txtFirstName = New TextBox()
        Label3 = New Label()
        txtStudentID = New TextBox()
        Label2 = New Label()
        MenuStrip1.SuspendLayout()
        panel1.SuspendLayout()
        panel2.SuspendLayout()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panel3.SuspendLayout()
        groupBox1.SuspendLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        groupBox2.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        groupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1200, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(139, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(139, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(127, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.Red
        panel1.Controls.Add(label1)
        panel1.Dock = DockStyle.Top
        panel1.Location = New Point(0, 28)
        panel1.Name = "panel1"
        panel1.Size = New Size(1200, 60)
        panel1.TabIndex = 1
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = Color.White
        label1.Location = New Point(434, 15)
        label1.Name = "label1"
        label1.Size = New Size(365, 35)
        label1.TabIndex = 0
        label1.Text = "Hostel Management System"
        ' 
        ' panel2
        ' 
        panel2.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        panel2.Controls.Add(pictureBox1)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(0, 670)
        panel2.Name = "panel2"
        panel2.Size = New Size(1200, 30)
        panel2.TabIndex = 2
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Location = New Point(10, 3)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(24, 24)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 0
        pictureBox1.TabStop = False
        ' 
        ' panel3
        ' 
        panel3.BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        panel3.Controls.Add(btnClear)
        panel3.Controls.Add(btnRefresh)
        panel3.Controls.Add(btnUpload)
        panel3.Controls.Add(btnDelete)
        panel3.Controls.Add(btnEdit)
        panel3.Controls.Add(btnSave)
        panel3.Controls.Add(btnAdd)
        panel3.Dock = DockStyle.Top
        panel3.Location = New Point(0, 88)
        panel3.Name = "panel3"
        panel3.Size = New Size(1200, 60)
        panel3.TabIndex = 3
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Red
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Times New Roman", 9F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(600, 10)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(100, 40)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Times New Roman", 9F)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(610, 10)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(90, 40)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnUpload
        ' 
        btnUpload.BackColor = Color.Green
        btnUpload.FlatStyle = FlatStyle.Flat
        btnUpload.Font = New Font("Times New Roman", 9F)
        btnUpload.ForeColor = Color.White
        btnUpload.Location = New Point(500, 10)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(100, 40)
        btnUpload.TabIndex = 4
        btnUpload.Text = "Upload"
        btnUpload.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpload.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Times New Roman", 9F)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(400, 10)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 40)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Yellow
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Times New Roman", 9F)
        btnEdit.ForeColor = Color.Black
        btnEdit.Location = New Point(200, 10)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(100, 40)
        btnEdit.TabIndex = 2
        btnEdit.Text = "Edit"
        btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.White
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Times New Roman", 9F)
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(300, 10)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 40)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.ForestGreen
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Times New Roman", 9F)
        btnAdd.ForeColor = Color.Transparent
        btnAdd.Location = New Point(100, 10)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(100, 40)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add New"
        btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' groupBox1
        ' 
        groupBox1.Controls.Add(picProfile)
        groupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        groupBox1.Location = New Point(800, 150)
        groupBox1.Name = "groupBox1"
        groupBox1.Size = New Size(380, 300)
        groupBox1.TabIndex = 4
        groupBox1.TabStop = False
        groupBox1.Text = "Profile Picture"
        ' 
        ' picProfile
        ' 
        picProfile.BorderStyle = BorderStyle.FixedSingle
        picProfile.Location = New Point(20, 30)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(340, 250)
        picProfile.SizeMode = PictureBoxSizeMode.Zoom
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' groupBox2
        ' 
        groupBox2.Controls.Add(txtSearch)
        groupBox2.Controls.Add(btnSearch)
        groupBox2.Controls.Add(dgvStudents)
        groupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        groupBox2.Location = New Point(20, 460)
        groupBox2.Name = "groupBox2"
        groupBox2.Size = New Size(1160, 200)
        groupBox2.TabIndex = 5
        groupBox2.TabStop = False
        groupBox2.Text = "Student List"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(10, 30)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(250, 27)
        txtSearch.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.SeaGreen
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(270, 25)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 30)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.BackgroundColor = Color.White
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(10, 65)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.Size = New Size(1140, 125)
        dgvStudents.TabIndex = 0
        ' 
        ' groupBox3
        ' 
        groupBox3.Controls.Add(txtAddress)
        groupBox3.Controls.Add(Label13)
        groupBox3.Controls.Add(txtGuardianContact)
        groupBox3.Controls.Add(Label12)
        groupBox3.Controls.Add(txtGuardianName)
        groupBox3.Controls.Add(Label11)
        groupBox3.Controls.Add(dtpDateOfJoining)
        groupBox3.Controls.Add(Label10)
        groupBox3.Controls.Add(txtRoomNumber)
        groupBox3.Controls.Add(Label9)
        groupBox3.Controls.Add(txtEmail)
        groupBox3.Controls.Add(Label8)
        groupBox3.Controls.Add(txtContact)
        groupBox3.Controls.Add(Label7)
        groupBox3.Controls.Add(txtAge)
        groupBox3.Controls.Add(Label6)
        groupBox3.Controls.Add(cmbGender)
        groupBox3.Controls.Add(Label5)
        groupBox3.Controls.Add(txtLastName)
        groupBox3.Controls.Add(Label4)
        groupBox3.Controls.Add(txtFirstName)
        groupBox3.Controls.Add(Label3)
        groupBox3.Controls.Add(txtStudentID)
        groupBox3.Controls.Add(Label2)
        groupBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        groupBox3.Location = New Point(20, 150)
        groupBox3.Name = "groupBox3"
        groupBox3.Size = New Size(760, 300)
        groupBox3.TabIndex = 6
        groupBox3.TabStop = False
        groupBox3.Text = "Student Details"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(470, 200)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(280, 80)
        txtAddress.TabIndex = 23
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(470, 180)
        Label13.Name = "Label13"
        Label13.Size = New Size(65, 20)
        Label13.TabIndex = 22
        Label13.Text = "Address:"
        ' 
        ' txtGuardianContact
        ' 
        txtGuardianContact.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGuardianContact.Location = New Point(470, 140)
        txtGuardianContact.Name = "txtGuardianContact"
        txtGuardianContact.Size = New Size(280, 27)
        txtGuardianContact.TabIndex = 21
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(470, 120)
        Label12.Name = "Label12"
        Label12.Size = New Size(127, 20)
        Label12.TabIndex = 20
        Label12.Text = "Guardian Contact:"
        ' 
        ' txtGuardianName
        ' 
        txtGuardianName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGuardianName.Location = New Point(470, 80)
        txtGuardianName.Name = "txtGuardianName"
        txtGuardianName.Size = New Size(280, 27)
        txtGuardianName.TabIndex = 19
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(470, 60)
        Label11.Name = "Label11"
        Label11.Size = New Size(116, 20)
        Label11.TabIndex = 18
        Label11.Text = "Guardian Name:"
        ' 
        ' dtpDateOfJoining
        ' 
        dtpDateOfJoining.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDateOfJoining.Location = New Point(470, 30)
        dtpDateOfJoining.Name = "dtpDateOfJoining"
        dtpDateOfJoining.Size = New Size(280, 27)
        dtpDateOfJoining.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(470, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 20)
        Label10.TabIndex = 16
        Label10.Text = "Date of Joining:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRoomNumber.Location = New Point(140, 260)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(280, 27)
        txtRoomNumber.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(10, 263)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 20)
        Label9.TabIndex = 14
        Label9.Text = "Room Number:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(140, 230)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(280, 27)
        txtEmail.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(10, 233)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 20)
        Label8.TabIndex = 12
        Label8.Text = "Email:"
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContact.Location = New Point(140, 200)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(280, 27)
        txtContact.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(10, 203)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 20)
        Label7.TabIndex = 10
        Label7.Text = "Contact Number:"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(140, 170)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(280, 27)
        txtAge.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(10, 173)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 20)
        Label6.TabIndex = 8
        Label6.Text = "Age:"
        ' 
        ' cmbGender
        ' 
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        cmbGender.Location = New Point(140, 140)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(280, 28)
        cmbGender.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 143)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 6
        Label5.Text = "Gender:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(140, 110)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(280, 27)
        txtLastName.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 20)
        Label4.TabIndex = 4
        Label4.Text = "Last Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(140, 80)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(280, 27)
        txtFirstName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 2
        Label3.Text = "First Name:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(140, 30)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(280, 27)
        txtStudentID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 0
        Label2.Text = "Student ID:"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1200, 700)
        Controls.Add(groupBox3)
        Controls.Add(groupBox2)
        Controls.Add(groupBox1)
        Controls.Add(panel3)
        Controls.Add(panel2)
        Controls.Add(panel1)
        Controls.Add(MenuStrip1)
        Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hostel Management System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        panel2.ResumeLayout(False)
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panel3.ResumeLayout(False)
        groupBox1.ResumeLayout(False)
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        groupBox2.ResumeLayout(False)
        groupBox2.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        groupBox3.ResumeLayout(False)
        groupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private WithEvents MenuStrip1 As MenuStrip
    Private WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Private WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Private WithEvents panel1 As Panel
    Private WithEvents label1 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents panel3 As Panel
    Private WithEvents btnUpload As Button
    Private WithEvents btnDelete As Button
    Private WithEvents btnEdit As Button
    Private WithEvents btnSave As Button
    Private WithEvents btnAdd As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents picProfile As PictureBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txtSearch As TextBox
    Private WithEvents btnSearch As Button
    Private WithEvents dgvStudents As DataGridView
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents txtAddress As TextBox
    Private WithEvents Label13 As Label
    Private WithEvents txtGuardianContact As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents txtGuardianName As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents dtpDateOfJoining As DateTimePicker
    Private WithEvents Label10 As Label
    Private WithEvents txtRoomNumber As TextBox
    Private WithEvents Label9 As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents txtContact As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents txtAge As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents cmbGender As ComboBox
    Private WithEvents Label5 As Label
    Private WithEvents txtLastName As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents txtFirstName As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents txtStudentID As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents btnRefresh As Button
    Private WithEvents btnClear As Button
End Class