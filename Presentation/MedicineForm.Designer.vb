<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicineForm
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
        Me.medicineList = New System.Windows.Forms.ListBox()
        Me.descBox = New System.Windows.Forms.TextBox()
        Me.priceBox = New System.Windows.Forms.TextBox()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.modifyBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'medicineList
        '
        Me.medicineList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicineList.FormattingEnabled = True
        Me.medicineList.ItemHeight = 17
        Me.medicineList.Location = New System.Drawing.Point(27, 23)
        Me.medicineList.Margin = New System.Windows.Forms.Padding(4)
        Me.medicineList.Name = "medicineList"
        Me.medicineList.Size = New System.Drawing.Size(159, 208)
        Me.medicineList.TabIndex = 0
        '
        'descBox
        '
        Me.descBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descBox.Location = New System.Drawing.Point(104, 25)
        Me.descBox.Margin = New System.Windows.Forms.Padding(4)
        Me.descBox.Name = "descBox"
        Me.descBox.Size = New System.Drawing.Size(132, 23)
        Me.descBox.TabIndex = 2
        '
        'priceBox
        '
        Me.priceBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceBox.Location = New System.Drawing.Point(104, 70)
        Me.priceBox.Margin = New System.Windows.Forms.Padding(4)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.Size = New System.Drawing.Size(132, 23)
        Me.priceBox.TabIndex = 3
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.Location = New System.Drawing.Point(16, 29)
        Me.descLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(79, 17)
        Me.descLabel.TabIndex = 5
        Me.descLabel.Text = "Description"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.Location = New System.Drawing.Point(16, 74)
        Me.priceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(74, 17)
        Me.priceLabel.TabIndex = 6
        Me.priceLabel.Text = "Price/u (€)"
        '
        'addBtn
        '
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(222, 155)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(100, 28)
        Me.addBtn.TabIndex = 4
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'modifyBtn
        '
        Me.modifyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifyBtn.Location = New System.Drawing.Point(395, 155)
        Me.modifyBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.modifyBtn.Name = "modifyBtn"
        Me.modifyBtn.Size = New System.Drawing.Size(100, 28)
        Me.modifyBtn.TabIndex = 5
        Me.modifyBtn.Text = "Modify"
        Me.modifyBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.Location = New System.Drawing.Point(222, 212)
        Me.deleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(100, 28)
        Me.deleteBtn.TabIndex = 6
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(395, 212)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(100, 28)
        Me.clearBtn.TabIndex = 7
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.medicineList)
        Me.GroupBox1.Controls.Add(Me.addBtn)
        Me.GroupBox1.Controls.Add(Me.clearBtn)
        Me.GroupBox1.Controls.Add(Me.modifyBtn)
        Me.GroupBox1.Controls.Add(Me.deleteBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(509, 259)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicine"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.descBox)
        Me.GroupBox2.Controls.Add(Me.priceBox)
        Me.GroupBox2.Controls.Add(Me.descLabel)
        Me.GroupBox2.Controls.Add(Me.priceLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(232, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(255, 108)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General"
        '
        'MedicineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 288)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MedicineForm"
        Me.Text = "Management - Medicine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents medicineList As ListBox
    Friend WithEvents descBox As TextBox
    Friend WithEvents priceBox As TextBox
    Friend WithEvents descLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents addBtn As Button
    Friend WithEvents modifyBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
