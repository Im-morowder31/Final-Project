<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProd
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
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.btnAddProd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbPic = New System.Windows.Forms.PictureBox()
        Me.btnSelectIImg = New System.Windows.Forms.Button()
        Me.fdImg = New System.Windows.Forms.OpenFileDialog()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(354, 77)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(193, 20)
        Me.txtItem.TabIndex = 14
        '
        'btnAddProd
        '
        Me.btnAddProd.Location = New System.Drawing.Point(350, 335)
        Me.btnAddProd.Name = "btnAddProd"
        Me.btnAddProd.Size = New System.Drawing.Size(189, 32)
        Me.btnAddProd.TabIndex = 18
        Me.btnAddProd.Text = "Add"
        Me.btnAddProd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Quantity Stocks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(357, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Item"
        '
        'txtQTY
        '
        Me.txtQTY.Location = New System.Drawing.Point(353, 286)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(193, 20)
        Me.txtQTY.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(350, 176)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(193, 20)
        Me.txtPrice.TabIndex = 19
        '
        'cbSize
        '
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"Extra Small", "Small", "Medium", "Large", "Extra Large"})
        Me.cbSize.Location = New System.Drawing.Point(352, 225)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(193, 21)
        Me.cbSize.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(349, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Size"
        '
        'pbPic
        '
        Me.pbPic.Location = New System.Drawing.Point(43, 77)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(265, 206)
        Me.pbPic.TabIndex = 25
        Me.pbPic.TabStop = False
        '
        'btnSelectIImg
        '
        Me.btnSelectIImg.Location = New System.Drawing.Point(43, 289)
        Me.btnSelectIImg.Name = "btnSelectIImg"
        Me.btnSelectIImg.Size = New System.Drawing.Size(128, 32)
        Me.btnSelectIImg.TabIndex = 26
        Me.btnSelectIImg.Text = "Select Image"
        Me.btnSelectIImg.UseVisualStyleBackColor = True
        '
        'fdImg
        '
        Me.fdImg.FileName = "OpenFileDialogImage"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(354, 124)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(193, 20)
        Me.txtCategory.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(353, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Category"
        '
        'AddProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 422)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSelectIImg)
        Me.Controls.Add(Me.pbPic)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.btnAddProd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQTY)
        Me.Name = "AddProd"
        Me.Text = "Add Product"
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItem As TextBox
    Friend WithEvents btnAddProd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQTY As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pbPic As PictureBox
    Friend WithEvents btnSelectIImg As Button
    Friend WithEvents fdImg As OpenFileDialog
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label5 As Label
End Class
