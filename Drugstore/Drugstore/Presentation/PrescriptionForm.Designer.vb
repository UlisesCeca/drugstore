<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrescriptionForm
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
        Me.prescriptionList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.modifyBtn = New System.Windows.Forms.Button()
        Me.medicineList = New System.Windows.Forms.ListBox()
        Me.addMBtn = New System.Windows.Forms.Button()
        Me.modifyMBtn = New System.Windows.Forms.Button()
        Me.deleteMBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.piceLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.descLabel2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.patientList = New System.Windows.Forms.ListBox()
        Me.availableMedicineList = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dateBox = New System.Windows.Forms.TextBox()
        Me.disccountBox = New System.Windows.Forms.Label()
        Me.costBox = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.desc2Label = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.patientBox = New System.Windows.Forms.Label()
        Me.disscountLabel = New System.Windows.Forms.Label()
        Me.dfv = New System.Windows.Forms.Label()
        Me.categoryLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.clearMBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'prescriptionList
        '
        Me.prescriptionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prescriptionList.FormattingEnabled = True
        Me.prescriptionList.ItemHeight = 17
        Me.prescriptionList.Location = New System.Drawing.Point(21, 23)
        Me.prescriptionList.Margin = New System.Windows.Forms.Padding(4)
        Me.prescriptionList.Name = "prescriptionList"
        Me.prescriptionList.Size = New System.Drawing.Size(176, 276)
        Me.prescriptionList.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cost (€)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 116)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Discounted (€)"
        '
        'addBtn
        '
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(725, 538)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(100, 28)
        Me.addBtn.TabIndex = 6
        Me.addBtn.Text = "Add Pres."
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.Location = New System.Drawing.Point(725, 602)
        Me.deleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(100, 28)
        Me.deleteBtn.TabIndex = 8
        Me.deleteBtn.Text = "Delete Pres."
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(876, 602)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(100, 28)
        Me.clearBtn.TabIndex = 9
        Me.clearBtn.Text = "Clear Pres."
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'modifyBtn
        '
        Me.modifyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifyBtn.Location = New System.Drawing.Point(876, 538)
        Me.modifyBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.modifyBtn.Name = "modifyBtn"
        Me.modifyBtn.Size = New System.Drawing.Size(100, 28)
        Me.modifyBtn.TabIndex = 7
        Me.modifyBtn.Text = "Modify Pres."
        Me.modifyBtn.UseVisualStyleBackColor = True
        '
        'medicineList
        '
        Me.medicineList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicineList.FormattingEnabled = True
        Me.medicineList.ItemHeight = 17
        Me.medicineList.Location = New System.Drawing.Point(21, 360)
        Me.medicineList.Margin = New System.Windows.Forms.Padding(4)
        Me.medicineList.Name = "medicineList"
        Me.medicineList.Size = New System.Drawing.Size(176, 276)
        Me.medicineList.TabIndex = 23
        '
        'addMBtn
        '
        Me.addMBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMBtn.Location = New System.Drawing.Point(229, 538)
        Me.addMBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addMBtn.Name = "addMBtn"
        Me.addMBtn.Size = New System.Drawing.Size(100, 28)
        Me.addMBtn.TabIndex = 12
        Me.addMBtn.Text = "Add Med."
        Me.addMBtn.UseVisualStyleBackColor = True
        '
        'modifyMBtn
        '
        Me.modifyMBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifyMBtn.Location = New System.Drawing.Point(380, 538)
        Me.modifyMBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.modifyMBtn.Name = "modifyMBtn"
        Me.modifyMBtn.Size = New System.Drawing.Size(100, 28)
        Me.modifyMBtn.TabIndex = 13
        Me.modifyMBtn.Text = "Modify Med."
        Me.modifyMBtn.UseVisualStyleBackColor = True
        '
        'deleteMBtn
        '
        Me.deleteMBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteMBtn.Location = New System.Drawing.Point(229, 594)
        Me.deleteMBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteMBtn.Name = "deleteMBtn"
        Me.deleteMBtn.Size = New System.Drawing.Size(100, 28)
        Me.deleteMBtn.TabIndex = 14
        Me.deleteMBtn.Text = "Delete Med."
        Me.deleteMBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.patientList)
        Me.GroupBox1.Controls.Add(Me.availableMedicineList)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.medicineList)
        Me.GroupBox1.Controls.Add(Me.modifyBtn)
        Me.GroupBox1.Controls.Add(Me.clearMBtn)
        Me.GroupBox1.Controls.Add(Me.prescriptionList)
        Me.GroupBox1.Controls.Add(Me.addMBtn)
        Me.GroupBox1.Controls.Add(Me.clearBtn)
        Me.GroupBox1.Controls.Add(Me.modifyMBtn)
        Me.GroupBox1.Controls.Add(Me.deleteBtn)
        Me.GroupBox1.Controls.Add(Me.deleteMBtn)
        Me.GroupBox1.Controls.Add(Me.addBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(984, 654)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prescriptions"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.piceLabel)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.descLabel2)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Location = New System.Drawing.Point(706, 361)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(259, 102)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Available Medicines"
        '
        'piceLabel
        '
        Me.piceLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.piceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.piceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piceLabel.Location = New System.Drawing.Point(116, 69)
        Me.piceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.piceLabel.Name = "piceLabel"
        Me.piceLabel.Size = New System.Drawing.Size(133, 24)
        Me.piceLabel.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 70)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Price/u (€)"
        '
        'descLabel2
        '
        Me.descLabel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.descLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel2.Location = New System.Drawing.Point(116, 27)
        Me.descLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.descLabel2.Name = "descLabel2"
        Me.descLabel2.Size = New System.Drawing.Size(133, 24)
        Me.descLabel2.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 28)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Description"
        '
        'patientList
        '
        Me.patientList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientList.FormattingEnabled = True
        Me.patientList.ItemHeight = 17
        Me.patientList.Location = New System.Drawing.Point(522, 23)
        Me.patientList.Margin = New System.Windows.Forms.Padding(4)
        Me.patientList.Name = "patientList"
        Me.patientList.Size = New System.Drawing.Size(176, 276)
        Me.patientList.TabIndex = 23
        '
        'availableMedicineList
        '
        Me.availableMedicineList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.availableMedicineList.FormattingEnabled = True
        Me.availableMedicineList.ItemHeight = 17
        Me.availableMedicineList.Location = New System.Drawing.Point(522, 360)
        Me.availableMedicineList.Margin = New System.Windows.Forms.Padding(4)
        Me.availableMedicineList.Name = "availableMedicineList"
        Me.availableMedicineList.Size = New System.Drawing.Size(176, 276)
        Me.availableMedicineList.TabIndex = 30
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dateBox)
        Me.GroupBox4.Controls.Add(Me.disccountBox)
        Me.GroupBox4.Controls.Add(Me.costBox)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(224, 23)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(277, 143)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "General"
        '
        'dateBox
        '
        Me.dateBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBox.Location = New System.Drawing.Point(123, 23)
        Me.dateBox.Margin = New System.Windows.Forms.Padding(4)
        Me.dateBox.Name = "dateBox"
        Me.dateBox.Size = New System.Drawing.Size(132, 23)
        Me.dateBox.TabIndex = 34
        '
        'disccountBox
        '
        Me.disccountBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.disccountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.disccountBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disccountBox.Location = New System.Drawing.Point(123, 106)
        Me.disccountBox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.disccountBox.Name = "disccountBox"
        Me.disccountBox.Size = New System.Drawing.Size(133, 24)
        Me.disccountBox.TabIndex = 35
        '
        'costBox
        '
        Me.costBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.costBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.costBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costBox.Location = New System.Drawing.Point(123, 65)
        Me.costBox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.costBox.Name = "costBox"
        Me.costBox.Size = New System.Drawing.Size(133, 24)
        Me.costBox.TabIndex = 34
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.quantity)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.descLabel)
        Me.GroupBox5.Controls.Add(Me.desc2Label)
        Me.GroupBox5.Location = New System.Drawing.Point(224, 361)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(277, 102)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Prescription's Medicines"
        '
        'quantity
        '
        Me.quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.Location = New System.Drawing.Point(116, 68)
        Me.quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(132, 23)
        Me.quantity.TabIndex = 36
        '
        'descLabel
        '
        Me.descLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.descLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.Location = New System.Drawing.Point(116, 27)
        Me.descLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(133, 24)
        Me.descLabel.TabIndex = 12
        '
        'desc2Label
        '
        Me.desc2Label.AutoSize = True
        Me.desc2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc2Label.Location = New System.Drawing.Point(19, 28)
        Me.desc2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.desc2Label.Name = "desc2Label"
        Me.desc2Label.Size = New System.Drawing.Size(79, 17)
        Me.desc2Label.TabIndex = 27
        Me.desc2Label.Text = "Description"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.patientBox)
        Me.GroupBox3.Controls.Add(Me.disscountLabel)
        Me.GroupBox3.Controls.Add(Me.dfv)
        Me.GroupBox3.Controls.Add(Me.categoryLabel)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.nameLabel)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(706, 24)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(259, 187)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Patient"
        '
        'patientBox
        '
        Me.patientBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.patientBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patientBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientBox.Location = New System.Drawing.Point(115, 32)
        Me.patientBox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.patientBox.Name = "patientBox"
        Me.patientBox.Size = New System.Drawing.Size(133, 24)
        Me.patientBox.TabIndex = 34
        '
        'disscountLabel
        '
        Me.disscountLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.disscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.disscountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disscountLabel.Location = New System.Drawing.Point(115, 151)
        Me.disscountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.disscountLabel.Name = "disscountLabel"
        Me.disscountLabel.Size = New System.Drawing.Size(133, 24)
        Me.disscountLabel.TabIndex = 32
        '
        'dfv
        '
        Me.dfv.AutoSize = True
        Me.dfv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dfv.Location = New System.Drawing.Point(9, 152)
        Me.dfv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dfv.Name = "dfv"
        Me.dfv.Size = New System.Drawing.Size(89, 17)
        Me.dfv.TabIndex = 33
        Me.dfv.Text = "Discount (%)"
        '
        'categoryLabel
        '
        Me.categoryLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.categoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.categoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryLabel.Location = New System.Drawing.Point(115, 108)
        Me.categoryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.categoryLabel.Name = "categoryLabel"
        Me.categoryLabel.Size = New System.Drawing.Size(133, 24)
        Me.categoryLabel.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 109)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Category"
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(115, 68)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(133, 24)
        Me.nameLabel.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 68)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Name"
        '
        'clearMBtn
        '
        Me.clearMBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearMBtn.Location = New System.Drawing.Point(380, 594)
        Me.clearMBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.clearMBtn.Name = "clearMBtn"
        Me.clearMBtn.Size = New System.Drawing.Size(100, 28)
        Me.clearMBtn.TabIndex = 15
        Me.clearMBtn.Text = "Clear Med."
        Me.clearMBtn.UseVisualStyleBackColor = True
        '
        'PrescriptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 676)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PrescriptionForm"
        Me.Text = "Management - Prescription"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prescriptionList As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents addBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents modifyBtn As Button
    Friend WithEvents medicineList As ListBox
    Friend WithEvents addMBtn As Button
    Friend WithEvents modifyMBtn As Button
    Friend WithEvents deleteMBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clearMBtn As Button
    Friend WithEvents descLabel As Label
    Friend WithEvents desc2Label As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents disscountLabel As Label
    Friend WithEvents dfv As Label
    Friend WithEvents categoryLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents disccountBox As Label
    Friend WithEvents costBox As Label
    Friend WithEvents dateBox As TextBox
    Friend WithEvents patientList As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents piceLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents descLabel2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents availableMedicineList As ListBox
    Friend WithEvents patientBox As Label
    Friend WithEvents quantity As TextBox
End Class
