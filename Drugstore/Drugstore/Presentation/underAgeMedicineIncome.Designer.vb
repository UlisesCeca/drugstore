<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class underAgeMedicineIncome
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
        Me.medicine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.income = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.medicine, Me.income})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(326, 229)
        Me.DataGridView1.TabIndex = 20
        '
        'medicine
        '
        Me.medicine.HeaderText = "Medicine"
        Me.medicine.Name = "medicine"
        Me.medicine.ReadOnly = True
        Me.medicine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'income
        '
        Me.income.HeaderText = "Income (€)"
        Me.income.Name = "income"
        Me.income.ReadOnly = True
        Me.income.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'underAgeMedicineIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "underAgeMedicineIncome"
        Me.Text = "Queries - Underage Medicines Income"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents medicine As DataGridViewTextBoxColumn
    Friend WithEvents income As DataGridViewTextBoxColumn
End Class
