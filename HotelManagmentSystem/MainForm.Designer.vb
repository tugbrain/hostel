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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtGuardianContact = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGuardianName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDateOfJoining = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1200, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Red
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 24)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1200, 60)
        Me.panel1.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(434, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(296, 26)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Hostel Management System"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panel2.Controls.Add(Me.pictureBox1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 670)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1200, 30)
        Me.panel2.TabIndex = 2
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.panel3.Controls.Add(Me.btnClear)
        Me.panel3.Controls.Add(Me.btnRefresh)
        Me.panel3.Controls.Add(Me.btnUpload)
        Me.panel3.Controls.Add(Me.btnDelete)
        Me.panel3.Controls.Add(Me.btnEdit)
        Me.panel3.Controls.Add(Me.btnSave)
        Me.panel3.Controls.Add(Me.btnAdd)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel3.Location = New System.Drawing.Point(0, 84)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1200, 60)
        Me.panel3.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(600, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(610, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 40)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Green
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(500, 10)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(100, 40)
        Me.btnUpload.TabIndex = 4
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(400, 10)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 40)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Yellow
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(200, 10)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 40)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(300, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 40)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.Transparent
        Me.btnAdd.Location = New System.Drawing.Point(100, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 40)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.picProfile)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(800, 150)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(380, 300)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Profile Picture"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtSearch)
        Me.groupBox2.Controls.Add(Me.btnSearch)
        Me.groupBox2.Controls.Add(Me.dgvStudents)
        Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(20, 460)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(1160, 200)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Student List"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(10, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 23)
        Me.txtSearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(270, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(10, 65)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.Size = New System.Drawing.Size(1140, 125)
        Me.dgvStudents.TabIndex = 0
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtAddress)
        Me.groupBox3.Controls.Add(Me.Label13)
        Me.groupBox3.Controls.Add(Me.txtGuardianContact)
        Me.groupBox3.Controls.Add(Me.Label12)
        Me.groupBox3.Controls.Add(Me.txtGuardianName)
        Me.groupBox3.Controls.Add(Me.Label11)
        Me.groupBox3.Controls.Add(Me.dtpDateOfJoining)
        Me.groupBox3.Controls.Add(Me.Label10)
        Me.groupBox3.Controls.Add(Me.txtRoomNumber)
        Me.groupBox3.Controls.Add(Me.Label9)
        Me.groupBox3.Controls.Add(Me.txtEmail)
        Me.groupBox3.Controls.Add(Me.Label8)
        Me.groupBox3.Controls.Add(Me.txtContact)
        Me.groupBox3.Controls.Add(Me.Label7)
        Me.groupBox3.Controls.Add(Me.txtAge)
        Me.groupBox3.Controls.Add(Me.Label6)
        Me.groupBox3.Controls.Add(Me.cmbGender)
        Me.groupBox3.Controls.Add(Me.Label5)
        Me.groupBox3.Controls.Add(Me.txtLastName)
        Me.groupBox3.Controls.Add(Me.Label4)
        Me.groupBox3.Controls.Add(Me.txtFirstName)
        Me.groupBox3.Controls.Add(Me.Label3)
        Me.groupBox3.Controls.Add(Me.txtStudentID)
        Me.groupBox3.Controls.Add(Me.Label2)
        Me.groupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(20, 150)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(760, 300)
        Me.groupBox3.TabIndex = 6
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Student Details"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(470, 200)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(280, 80)
        Me.txtAddress.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(470, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Address:"
        '
        'txtGuardianContact
        '
        Me.txtGuardianContact.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianContact.Location = New System.Drawing.Point(470, 140)
        Me.txtGuardianContact.Name = "txtGuardianContact"
        Me.txtGuardianContact.Size = New System.Drawing.Size(280, 23)
        Me.txtGuardianContact.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(470, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Guardian Contact:"
        '
        'txtGuardianName
        '
        Me.txtGuardianName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianName.Location = New System.Drawing.Point(470, 80)
        Me.txtGuardianName.Name = "txtGuardianName"
        Me.txtGuardianName.Size = New System.Drawing.Size(280, 23)
        Me.txtGuardianName.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(470, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Guardian Name:"
        '
        'dtpDateOfJoining
        '
        Me.dtpDateOfJoining.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOfJoining.Location = New System.Drawing.Point(470, 30)
        Me.dtpDateOfJoining.Name = "dtpDateOfJoining"
        Me.dtpDateOfJoining.Size = New System.Drawing.Size(280, 23)
        Me.dtpDateOfJoining.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(470, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Date of Joining:"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNumber.Location = New System.Drawing.Point(140, 260)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(280, 23)
        Me.txtRoomNumber.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Room Number:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(140, 230)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 23)
        Me.txtEmail.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Email:"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(140, 200)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(280, 23)
        Me.txtContact.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Contact Number:"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(140, 170)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(280, 23)
        Me.txtAge.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Age:"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(140, 140)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(280, 23)
        Me.cmbGender.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Gender:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(140, 110)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(280, 23)
        Me.txtLastName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(140, 80)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(280, 23)
        Me.txtFirstName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(140, 30)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(280, 23)
        Me.txtStudentID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID:"
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(10, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'picProfile
        '
        Me.picProfile.Location = New System.Drawing.Point(22, 36)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(337, 241)
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hostel Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents picProfile As PictureBox
End Class