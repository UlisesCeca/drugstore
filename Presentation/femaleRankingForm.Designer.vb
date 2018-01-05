<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class femaleRankingForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.units = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.units2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.searchbt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date2Box = New System.Windows.Forms.DateTimePicker()
        Me.date1Box = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.units, Me.units2})
        Me.DataGridView1.Location = New System.Drawing.Point(219, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(458, 343)
        Me.DataGridView1.TabIndex = 19
        '
        'Description
        '
        Me.Description.HeaderText = "ID"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'units
        '
        Me.units.HeaderText = "Name"
        Me.units.Name = "units"
        Me.units.ReadOnly = True
        Me.units.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'units2
        '
        Me.units2.HeaderText = "Units Bought"
        Me.units2.Name = "units2"
        Me.units2.ReadOnly = True
        Me.units2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'searchbt
        '
        Me.searchbt.Location = New System.Drawing.Point(85, 101)
        Me.searchbt.Name = "searchbt"
        Me.searchbt.Size = New System.Drawing.Size(95, 26)
        Me.searchbt.TabIndex = 18
        Me.searchbt.Text = "Search"
        Me.searchbt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Date 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Date 1"
        '
        'date2Box
        '
        Me.date2Box.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date2Box.Location = New System.Drawing.Point(81, 60)
        Me.date2Box.Name = "date2Box"
        Me.date2Box.Size = New System.Drawing.Size(118, 22)
        Me.date2Box.TabIndex = 28
        '
        'date1Box
        '
        Me.date1Box.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date1Box.Location = New System.Drawing.Point(81, 16)
        Me.date1Box.Name = "date1Box"
        Me.date1Box.Size = New System.Drawing.Size(118, 22)
        Me.date1Box.TabIndex = 27
        '
        'femaleRankingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 377)
        Me.Controls.Add(Me.date2Box)
        Me.Controls.Add(Me.date1Box)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.searchbt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "femaleRankingForm"
        Me.Text = "Queries - Female Ranking"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents searchbt As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents units As DataGridViewTextBoxColumn
    Friend WithEvents units2 As DataGridViewTextBoxColumn
    Friend WithEvents date2Box As DateTimePicker
    Friend WithEvents date1Box As DateTimePicker
End Class
