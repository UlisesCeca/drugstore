<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryForm
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
        Me.categoryList = New System.Windows.Forms.ListBox()
        Me.descriptionBox = New System.Windows.Forms.TextBox()
        Me.disccountBox = New System.Windows.Forms.TextBox()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.disccountLabel = New System.Windows.Forms.Label()
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
        'categoryList
        '
        Me.categoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryList.FormattingEnabled = True
        Me.categoryList.Location = New System.Drawing.Point(6, 19)
        Me.categoryList.Name = "categoryList"
        Me.categoryList.Size = New System.Drawing.Size(120, 173)
        Me.categoryList.TabIndex = 0
        '
        'descriptionBox
        '
        Me.descriptionBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionBox.Location = New System.Drawing.Point(84, 18)
        Me.descriptionBox.Name = "descriptionBox"
        Me.descriptionBox.Size = New System.Drawing.Size(100, 20)
        Me.descriptionBox.TabIndex = 2
        '
        'disccountBox
        '
        Me.disccountBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disccountBox.Location = New System.Drawing.Point(84, 52)
        Me.disccountBox.Name = "disccountBox"
        Me.disccountBox.Size = New System.Drawing.Size(100, 20)
        Me.disccountBox.TabIndex = 3
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionLabel.Location = New System.Drawing.Point(14, 25)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(60, 13)
        Me.descriptionLabel.TabIndex = 5
        Me.descriptionLabel.Text = "Description"
        '
        'disccountLabel
        '
        Me.disccountLabel.AutoSize = True
        Me.disccountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disccountLabel.Location = New System.Drawing.Point(14, 59)
        Me.disccountLabel.Name = "disccountLabel"
        Me.disccountLabel.Size = New System.Drawing.Size(66, 13)
        Me.disccountLabel.TabIndex = 6
        Me.disccountLabel.Text = "Discount (%)"
        '
        'addBtn
        '
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(151, 119)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(75, 23)
        Me.addBtn.TabIndex = 4
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'modifyBtn
        '
        Me.modifyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifyBtn.Location = New System.Drawing.Point(265, 119)
        Me.modifyBtn.Name = "modifyBtn"
        Me.modifyBtn.Size = New System.Drawing.Size(75, 23)
        Me.modifyBtn.TabIndex = 5
        Me.modifyBtn.Text = "Modify"
        Me.modifyBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.Location = New System.Drawing.Point(151, 173)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.deleteBtn.TabIndex = 6
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(265, 173)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 7
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.clearBtn)
        Me.GroupBox1.Controls.Add(Me.deleteBtn)
        Me.GroupBox1.Controls.Add(Me.modifyBtn)
        Me.GroupBox1.Controls.Add(Me.addBtn)
        Me.GroupBox1.Controls.Add(Me.categoryList)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 208)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Category"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.disccountLabel)
        Me.GroupBox2.Controls.Add(Me.descriptionLabel)
        Me.GroupBox2.Controls.Add(Me.descriptionBox)
        Me.GroupBox2.Controls.Add(Me.disccountBox)
        Me.GroupBox2.Location = New System.Drawing.Point(151, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 84)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General"
        '
        'CategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 227)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CategoryForm"
        Me.Text = "Management - Categories"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents categoryList As ListBox
    Friend WithEvents descriptionBox As TextBox
    Friend WithEvents disccountBox As TextBox
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents disccountLabel As Label
    Friend WithEvents addBtn As Button
    Friend WithEvents modifyBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
