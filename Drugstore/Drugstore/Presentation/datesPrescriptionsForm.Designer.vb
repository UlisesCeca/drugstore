<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datesPrescriptionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.patientsList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.date1Box = New System.Windows.Forms.TextBox()
        Me.date2Box = New System.Windows.Forms.TextBox()
        Me.prescriptionsList = New System.Windows.Forms.ListBox()
        Me.medicinesList = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pDateLabel = New System.Windows.Forms.Label()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.patientLabel = New System.Windows.Forms.Label()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'patientsList
        '
        Me.patientsList.FormattingEnabled = True
        Me.patientsList.ItemHeight = 16
        Me.patientsList.Location = New System.Drawing.Point(12, 35)
        Me.patientsList.Name = "patientsList"
        Me.patientsList.Size = New System.Drawing.Size(180, 356)
        Me.patientsList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date 2"
        '
        'date1Box
        '
        Me.date1Box.Location = New System.Drawing.Point(281, 32)
        Me.date1Box.Name = "date1Box"
        Me.date1Box.Size = New System.Drawing.Size(100, 22)
        Me.date1Box.TabIndex = 3
        '
        'date2Box
        '
        Me.date2Box.Location = New System.Drawing.Point(281, 76)
        Me.date2Box.Name = "date2Box"
        Me.date2Box.Size = New System.Drawing.Size(100, 22)
        Me.date2Box.TabIndex = 4
        '
        'prescriptionsList
        '
        Me.prescriptionsList.FormattingEnabled = True
        Me.prescriptionsList.ItemHeight = 16
        Me.prescriptionsList.Location = New System.Drawing.Point(448, 35)
        Me.prescriptionsList.Name = "prescriptionsList"
        Me.prescriptionsList.Size = New System.Drawing.Size(180, 356)
        Me.prescriptionsList.TabIndex = 5
        '
        'medicinesList
        '
        Me.medicinesList.FormattingEnabled = True
        Me.medicinesList.ItemHeight = 16
        Me.medicinesList.Location = New System.Drawing.Point(883, 32)
        Me.medicinesList.Name = "medicinesList"
        Me.medicinesList.Size = New System.Drawing.Size(180, 356)
        Me.medicinesList.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(647, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1085, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1085, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantity"
        '
        'pDateLabel
        '
        Me.pDateLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pDateLabel.Location = New System.Drawing.Point(761, 35)
        Me.pDateLabel.Name = "pDateLabel"
        Me.pDateLabel.Size = New System.Drawing.Size(95, 22)
        Me.pDateLabel.TabIndex = 13
        '
        'descLabel
        '
        Me.descLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.descLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descLabel.Location = New System.Drawing.Point(1180, 34)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(100, 22)
        Me.descLabel.TabIndex = 14
        '
        'quantityLabel
        '
        Me.quantityLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.quantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quantityLabel.Location = New System.Drawing.Point(1180, 80)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(100, 22)
        Me.quantityLabel.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Patients"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(445, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Prescriptions"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(880, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Medicines"
        '
        'patientLabel
        '
        Me.patientLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.patientLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patientLabel.Location = New System.Drawing.Point(761, 74)
        Me.patientLabel.Name = "patientLabel"
        Me.patientLabel.Size = New System.Drawing.Size(95, 22)
        Me.patientLabel.TabIndex = 24
        '
        'costLabel
        '
        Me.costLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.costLabel.Location = New System.Drawing.Point(761, 111)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(95, 22)
        Me.costLabel.TabIndex = 23
        '
        'discountLabel
        '
        Me.discountLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountLabel.Location = New System.Drawing.Point(761, 148)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(95, 22)
        Me.discountLabel.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(647, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cost (€)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(647, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Discounted (€)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(647, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Patient"
        '
        'datesPrescriptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 405)
        Me.Controls.Add(Me.patientLabel)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.discountLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.quantityLabel)
        Me.Controls.Add(Me.descLabel)
        Me.Controls.Add(Me.pDateLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.medicinesList)
        Me.Controls.Add(Me.prescriptionsList)
        Me.Controls.Add(Me.date2Box)
        Me.Controls.Add(Me.date1Box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.patientsList)
        Me.Name = "datesPrescriptionsForm"
        Me.Text = "Queries - Search Prescription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents patientsList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents date1Box As TextBox
    Friend WithEvents date2Box As TextBox
    Friend WithEvents prescriptionsList As ListBox
    Friend WithEvents medicinesList As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pDateLabel As Label
    Friend WithEvents descLabel As Label
    Friend WithEvents quantityLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents patientLabel As Label
    Friend WithEvents costLabel As Label
    Friend WithEvents discountLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
