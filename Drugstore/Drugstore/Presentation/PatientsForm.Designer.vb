<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientsForm
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
        Me.patientsList = New System.Windows.Forms.ListBox()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.bdayBox = New System.Windows.Forms.TextBox()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.bdayLabel = New System.Windows.Forms.Label()
        Me.genderLabel = New System.Windows.Forms.Label()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.modifyBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.categoryList = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.genderBox = New System.Windows.Forms.TextBox()
        Me.categoryGroup = New System.Windows.Forms.GroupBox()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.categoryGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'patientsList
        '
        Me.patientsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientsList.FormattingEnabled = True
        Me.patientsList.ItemHeight = 17
        Me.patientsList.Location = New System.Drawing.Point(8, 34)
        Me.patientsList.Margin = New System.Windows.Forms.Padding(4)
        Me.patientsList.Name = "patientsList"
        Me.patientsList.Size = New System.Drawing.Size(159, 259)
        Me.patientsList.TabIndex = 0
        '
        'nameBox
        '
        Me.nameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameBox.Location = New System.Drawing.Point(115, 64)
        Me.nameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(132, 23)
        Me.nameBox.TabIndex = 2
        '
        'bdayBox
        '
        Me.bdayBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdayBox.Location = New System.Drawing.Point(115, 106)
        Me.bdayBox.Margin = New System.Windows.Forms.Padding(4)
        Me.bdayBox.Name = "bdayBox"
        Me.bdayBox.Size = New System.Drawing.Size(132, 23)
        Me.bdayBox.TabIndex = 3
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLabel.Location = New System.Drawing.Point(15, 27)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(21, 17)
        Me.idLabel.TabIndex = 6
        Me.idLabel.Text = "ID"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(15, 68)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(45, 17)
        Me.nameLabel.TabIndex = 7
        Me.nameLabel.Text = "Name"
        '
        'bdayLabel
        '
        Me.bdayLabel.AutoSize = True
        Me.bdayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdayLabel.Location = New System.Drawing.Point(15, 110)
        Me.bdayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bdayLabel.Name = "bdayLabel"
        Me.bdayLabel.Size = New System.Drawing.Size(71, 17)
        Me.bdayLabel.TabIndex = 9
        Me.bdayLabel.Text = "Birth Date"
        '
        'genderLabel
        '
        Me.genderLabel.AutoSize = True
        Me.genderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderLabel.Location = New System.Drawing.Point(15, 155)
        Me.genderLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.genderLabel.Name = "genderLabel"
        Me.genderLabel.Size = New System.Drawing.Size(56, 17)
        Me.genderLabel.TabIndex = 10
        Me.genderLabel.Text = "Gender"
        '
        'addBtn
        '
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(661, 208)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(100, 28)
        Me.addBtn.TabIndex = 6
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'modifyBtn
        '
        Me.modifyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifyBtn.Location = New System.Drawing.Point(821, 208)
        Me.modifyBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.modifyBtn.Name = "modifyBtn"
        Me.modifyBtn.Size = New System.Drawing.Size(100, 28)
        Me.modifyBtn.TabIndex = 7
        Me.modifyBtn.Text = "Modify"
        Me.modifyBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.Location = New System.Drawing.Point(661, 266)
        Me.deleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(100, 28)
        Me.deleteBtn.TabIndex = 8
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(821, 266)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(100, 28)
        Me.clearBtn.TabIndex = 9
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'idBox
        '
        Me.idBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idBox.Location = New System.Drawing.Point(115, 23)
        Me.idBox.Margin = New System.Windows.Forms.Padding(4)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(132, 23)
        Me.idBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.categoryList)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.categoryGroup)
        Me.GroupBox1.Controls.Add(Me.clearBtn)
        Me.GroupBox1.Controls.Add(Me.deleteBtn)
        Me.GroupBox1.Controls.Add(Me.modifyBtn)
        Me.GroupBox1.Controls.Add(Me.addBtn)
        Me.GroupBox1.Controls.Add(Me.patientsList)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(941, 312)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient"
        '
        'categoryList
        '
        Me.categoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryList.FormattingEnabled = True
        Me.categoryList.ItemHeight = 17
        Me.categoryList.Location = New System.Drawing.Point(481, 34)
        Me.categoryList.Margin = New System.Windows.Forms.Padding(4)
        Me.categoryList.Name = "categoryList"
        Me.categoryList.Size = New System.Drawing.Size(159, 259)
        Me.categoryList.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.genderBox)
        Me.GroupBox3.Controls.Add(Me.genderLabel)
        Me.GroupBox3.Controls.Add(Me.idBox)
        Me.GroupBox3.Controls.Add(Me.bdayLabel)
        Me.GroupBox3.Controls.Add(Me.idLabel)
        Me.GroupBox3.Controls.Add(Me.bdayBox)
        Me.GroupBox3.Controls.Add(Me.nameLabel)
        Me.GroupBox3.Controls.Add(Me.nameBox)
        Me.GroupBox3.Location = New System.Drawing.Point(175, 34)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(273, 193)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "General"
        '
        'genderBox
        '
        Me.genderBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderBox.Location = New System.Drawing.Point(115, 151)
        Me.genderBox.Margin = New System.Windows.Forms.Padding(4)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(132, 23)
        Me.genderBox.TabIndex = 4
        '
        'categoryGroup
        '
        Me.categoryGroup.Controls.Add(Me.discountLabel)
        Me.categoryGroup.Controls.Add(Me.Label3)
        Me.categoryGroup.Controls.Add(Me.descLabel)
        Me.categoryGroup.Controls.Add(Me.Label1)
        Me.categoryGroup.Location = New System.Drawing.Point(648, 34)
        Me.categoryGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.categoryGroup.Name = "categoryGroup"
        Me.categoryGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.categoryGroup.Size = New System.Drawing.Size(262, 98)
        Me.categoryGroup.TabIndex = 16
        Me.categoryGroup.TabStop = False
        Me.categoryGroup.Text = "Category"
        '
        'discountLabel
        '
        Me.discountLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountLabel.Location = New System.Drawing.Point(110, 61)
        Me.discountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(133, 24)
        Me.discountLabel.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Discount (%)"
        '
        'descLabel
        '
        Me.descLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.descLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.Location = New System.Drawing.Point(110, 20)
        Me.descLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(133, 24)
        Me.descLabel.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Description"
        '
        'PatientsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 335)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PatientsForm"
        Me.Text = "Management - Patients"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.categoryGroup.ResumeLayout(False)
        Me.categoryGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents patientsList As ListBox
    Friend WithEvents nameBox As TextBox
    Friend WithEvents bdayBox As TextBox
    Friend WithEvents idLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents bdayLabel As Label
    Friend WithEvents genderLabel As Label
    Friend WithEvents addBtn As Button
    Friend WithEvents modifyBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents idBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents descLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents categoryGroup As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents genderBox As TextBox
    Friend WithEvents discountLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents categoryList As ListBox
End Class
