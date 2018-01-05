<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medicineRankingForm
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
        Me.searchbt = New System.Windows.Forms.Button()
        Me.date2Box = New System.Windows.Forms.TextBox()
        Me.date1Box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Medicine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.units = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchbt
        '
        Me.searchbt.Location = New System.Drawing.Point(95, 101)
        Me.searchbt.Name = "searchbt"
        Me.searchbt.Size = New System.Drawing.Size(95, 26)
        Me.searchbt.TabIndex = 12
        Me.searchbt.Text = "Search"
        Me.searchbt.UseVisualStyleBackColor = True
        '
        'date2Box
        '
        Me.date2Box.Location = New System.Drawing.Point(95, 62)
        Me.date2Box.Name = "date2Box"
        Me.date2Box.Size = New System.Drawing.Size(100, 22)
        Me.date2Box.TabIndex = 11
        '
        'date1Box
        '
        Me.date1Box.Location = New System.Drawing.Point(95, 18)
        Me.date1Box.Name = "date1Box"
        Me.date1Box.Size = New System.Drawing.Size(100, 22)
        Me.date1Box.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Date 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date 1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Medicine, Me.units})
        Me.DataGridView1.Location = New System.Drawing.Point(229, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(326, 229)
        Me.DataGridView1.TabIndex = 13
        '
        'Medicine
        '
        Me.Medicine.HeaderText = "Medicine"
        Me.Medicine.Name = "Medicine"
        Me.Medicine.ReadOnly = True
        Me.Medicine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'units
        '
        Me.units.HeaderText = "Units Sold"
        Me.units.Name = "units"
        Me.units.ReadOnly = True
        Me.units.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'medicineRankingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 251)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.searchbt)
        Me.Controls.Add(Me.date2Box)
        Me.Controls.Add(Me.date1Box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "medicineRankingForm"
        Me.Text = "Queries - Medicines Ranking"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchbt As Button
    Friend WithEvents date2Box As TextBox
    Friend WithEvents date1Box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Medicine As DataGridViewTextBoxColumn
    Friend WithEvents units As DataGridViewTextBoxColumn
End Class
