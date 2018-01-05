<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mostExpensivePresc
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
        Me.prescriptionList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.medicineList = New System.Windows.Forms.ListBox()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.patientLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'prescriptionList
        '
        Me.prescriptionList.FormattingEnabled = True
        Me.prescriptionList.ItemHeight = 16
        Me.prescriptionList.Location = New System.Drawing.Point(12, 38)
        Me.prescriptionList.Name = "prescriptionList"
        Me.prescriptionList.Size = New System.Drawing.Size(158, 308)
        Me.prescriptionList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patient"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Discounted (€)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cost (€)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(599, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(599, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Quantity"
        '
        'medicineList
        '
        Me.medicineList.FormattingEnabled = True
        Me.medicineList.ItemHeight = 16
        Me.medicineList.Location = New System.Drawing.Point(421, 38)
        Me.medicineList.Name = "medicineList"
        Me.medicineList.Size = New System.Drawing.Size(158, 308)
        Me.medicineList.TabIndex = 7
        '
        'dateLabel
        '
        Me.dateLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dateLabel.Location = New System.Drawing.Point(305, 37)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(95, 22)
        Me.dateLabel.TabIndex = 8
        '
        'descLabel
        '
        Me.descLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.descLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descLabel.Location = New System.Drawing.Point(683, 37)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(95, 22)
        Me.descLabel.TabIndex = 9
        '
        'discountLabel
        '
        Me.discountLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountLabel.Location = New System.Drawing.Point(305, 148)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(95, 22)
        Me.discountLabel.TabIndex = 10
        '
        'quantityLabel
        '
        Me.quantityLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.quantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quantityLabel.Location = New System.Drawing.Point(683, 74)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(95, 22)
        Me.quantityLabel.TabIndex = 12
        '
        'costLabel
        '
        Me.costLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.costLabel.Location = New System.Drawing.Point(305, 111)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(95, 22)
        Me.costLabel.TabIndex = 13
        '
        'patientLabel
        '
        Me.patientLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.patientLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patientLabel.Location = New System.Drawing.Point(305, 74)
        Me.patientLabel.Name = "patientLabel"
        Me.patientLabel.Size = New System.Drawing.Size(95, 22)
        Me.patientLabel.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Prescriptions"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(418, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Medicines"
        '
        'mostExpensivePresc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 361)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.patientLabel)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.quantityLabel)
        Me.Controls.Add(Me.discountLabel)
        Me.Controls.Add(Me.descLabel)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.medicineList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prescriptionList)
        Me.Name = "mostExpensivePresc"
        Me.Text = "Queries - Most Expensive Prescription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prescriptionList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents medicineList As ListBox
    Friend WithEvents dateLabel As Label
    Friend WithEvents descLabel As Label
    Friend WithEvents discountLabel As Label
    Friend WithEvents quantityLabel As Label
    Friend WithEvents costLabel As Label
    Friend WithEvents patientLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
