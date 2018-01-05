<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.databaseGroup = New System.Windows.Forms.GroupBox()
        Me.databaseLabel = New System.Windows.Forms.Label()
        Me.dbBtn = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.managementGroup = New System.Windows.Forms.GroupBox()
        Me.medicineBtn = New System.Windows.Forms.Button()
        Me.prescriptionBtn = New System.Windows.Forms.Button()
        Me.patientsBtn = New System.Windows.Forms.Button()
        Me.categoryBtn = New System.Windows.Forms.Button()
        Me.consultsGroup = New System.Windows.Forms.GroupBox()
        Me.medIncomeBtn = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.purchasedBtn = New System.Windows.Forms.Button()
        Me.medRankBtn = New System.Windows.Forms.Button()
        Me.femRankBtn = New System.Windows.Forms.Button()
        Me.databaseGroup.SuspendLayout()
        Me.managementGroup.SuspendLayout()
        Me.consultsGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'databaseGroup
        '
        Me.databaseGroup.Controls.Add(Me.databaseLabel)
        Me.databaseGroup.Controls.Add(Me.dbBtn)
        Me.databaseGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.databaseGroup.Location = New System.Drawing.Point(29, 378)
        Me.databaseGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.databaseGroup.Name = "databaseGroup"
        Me.databaseGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.databaseGroup.Size = New System.Drawing.Size(624, 86)
        Me.databaseGroup.TabIndex = 0
        Me.databaseGroup.TabStop = False
        Me.databaseGroup.Text = "Database"
        '
        'databaseLabel
        '
        Me.databaseLabel.BackColor = System.Drawing.Color.White
        Me.databaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.databaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.databaseLabel.Location = New System.Drawing.Point(149, 38)
        Me.databaseLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.databaseLabel.Name = "databaseLabel"
        Me.databaseLabel.Size = New System.Drawing.Size(442, 30)
        Me.databaseLabel.TabIndex = 3
        '
        'dbBtn
        '
        Me.dbBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbBtn.Location = New System.Drawing.Point(24, 38)
        Me.dbBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.dbBtn.Name = "dbBtn"
        Me.dbBtn.Size = New System.Drawing.Size(100, 31)
        Me.dbBtn.TabIndex = 1
        Me.dbBtn.Text = "DB Path"
        Me.dbBtn.UseVisualStyleBackColor = True
        '
        'managementGroup
        '
        Me.managementGroup.Controls.Add(Me.medicineBtn)
        Me.managementGroup.Controls.Add(Me.prescriptionBtn)
        Me.managementGroup.Controls.Add(Me.patientsBtn)
        Me.managementGroup.Controls.Add(Me.categoryBtn)
        Me.managementGroup.Enabled = False
        Me.managementGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managementGroup.Location = New System.Drawing.Point(29, 15)
        Me.managementGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.managementGroup.Name = "managementGroup"
        Me.managementGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.managementGroup.Size = New System.Drawing.Size(624, 170)
        Me.managementGroup.TabIndex = 0
        Me.managementGroup.TabStop = False
        Me.managementGroup.Text = "Management"
        '
        'medicineBtn
        '
        Me.medicineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicineBtn.Location = New System.Drawing.Point(136, 122)
        Me.medicineBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.medicineBtn.Name = "medicineBtn"
        Me.medicineBtn.Size = New System.Drawing.Size(132, 34)
        Me.medicineBtn.TabIndex = 3
        Me.medicineBtn.Text = "Medicines"
        Me.medicineBtn.UseVisualStyleBackColor = True
        '
        'prescriptionBtn
        '
        Me.prescriptionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prescriptionBtn.Location = New System.Drawing.Point(365, 122)
        Me.prescriptionBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.prescriptionBtn.Name = "prescriptionBtn"
        Me.prescriptionBtn.Size = New System.Drawing.Size(132, 34)
        Me.prescriptionBtn.TabIndex = 4
        Me.prescriptionBtn.Text = "Prescriptions"
        Me.prescriptionBtn.UseVisualStyleBackColor = True
        '
        'patientsBtn
        '
        Me.patientsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientsBtn.Location = New System.Drawing.Point(136, 43)
        Me.patientsBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.patientsBtn.Name = "patientsBtn"
        Me.patientsBtn.Size = New System.Drawing.Size(132, 34)
        Me.patientsBtn.TabIndex = 1
        Me.patientsBtn.Text = "Patients"
        Me.patientsBtn.UseVisualStyleBackColor = True
        '
        'categoryBtn
        '
        Me.categoryBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryBtn.Location = New System.Drawing.Point(365, 43)
        Me.categoryBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.categoryBtn.Name = "categoryBtn"
        Me.categoryBtn.Size = New System.Drawing.Size(132, 34)
        Me.categoryBtn.TabIndex = 2
        Me.categoryBtn.Text = "Categories"
        Me.categoryBtn.UseVisualStyleBackColor = True
        '
        'consultsGroup
        '
        Me.consultsGroup.Controls.Add(Me.medIncomeBtn)
        Me.consultsGroup.Controls.Add(Me.Button9)
        Me.consultsGroup.Controls.Add(Me.purchasedBtn)
        Me.consultsGroup.Controls.Add(Me.medRankBtn)
        Me.consultsGroup.Controls.Add(Me.femRankBtn)
        Me.consultsGroup.Enabled = False
        Me.consultsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultsGroup.Location = New System.Drawing.Point(29, 192)
        Me.consultsGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.consultsGroup.Name = "consultsGroup"
        Me.consultsGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.consultsGroup.Size = New System.Drawing.Size(624, 178)
        Me.consultsGroup.TabIndex = 0
        Me.consultsGroup.TabStop = False
        Me.consultsGroup.Text = "Queries"
        '
        'medIncomeBtn
        '
        Me.medIncomeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medIncomeBtn.Location = New System.Drawing.Point(427, 117)
        Me.medIncomeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.medIncomeBtn.Name = "medIncomeBtn"
        Me.medIncomeBtn.Size = New System.Drawing.Size(178, 53)
        Me.medIncomeBtn.TabIndex = 4
        Me.medIncomeBtn.Text = "Medicine Income (4)"
        Me.medIncomeBtn.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(227, 72)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(178, 53)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Most Expensive Prescription (5)"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'purchasedBtn
        '
        Me.purchasedBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchasedBtn.Location = New System.Drawing.Point(24, 27)
        Me.purchasedBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.purchasedBtn.Name = "purchasedBtn"
        Me.purchasedBtn.Size = New System.Drawing.Size(178, 53)
        Me.purchasedBtn.TabIndex = 1
        Me.purchasedBtn.Text = "Prescriptions Between Dates (1)"
        Me.purchasedBtn.UseVisualStyleBackColor = True
        '
        'medRankBtn
        '
        Me.medRankBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medRankBtn.Location = New System.Drawing.Point(427, 27)
        Me.medRankBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.medRankBtn.Name = "medRankBtn"
        Me.medRankBtn.Size = New System.Drawing.Size(178, 53)
        Me.medRankBtn.TabIndex = 2
        Me.medRankBtn.Text = "Medicines Ranking (2)"
        Me.medRankBtn.UseVisualStyleBackColor = True
        '
        'femRankBtn
        '
        Me.femRankBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femRankBtn.Location = New System.Drawing.Point(24, 117)
        Me.femRankBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.femRankBtn.Name = "femRankBtn"
        Me.femRankBtn.Size = New System.Drawing.Size(178, 53)
        Me.femRankBtn.TabIndex = 3
        Me.femRankBtn.Text = "Female Ranking (3)"
        Me.femRankBtn.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 474)
        Me.Controls.Add(Me.consultsGroup)
        Me.Controls.Add(Me.managementGroup)
        Me.Controls.Add(Me.databaseGroup)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Principal"
        Me.Text = "Drugstore"
        Me.databaseGroup.ResumeLayout(False)
        Me.managementGroup.ResumeLayout(False)
        Me.consultsGroup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents databaseGroup As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents managementGroup As GroupBox
    Friend WithEvents consultsGroup As GroupBox
    Friend WithEvents dbBtn As Button
    Friend WithEvents databaseLabel As Label
    Friend WithEvents medicineBtn As Button
    Friend WithEvents prescriptionBtn As Button
    Friend WithEvents patientsBtn As Button
    Friend WithEvents categoryBtn As Button
    Friend WithEvents medIncomeBtn As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents purchasedBtn As Button
    Friend WithEvents medRankBtn As Button
    Friend WithEvents femRankBtn As Button
End Class
