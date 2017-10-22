<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.typeLabel = New System.Windows.Forms.Label()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        Me.bdayPictureBox = New System.Windows.Forms.PictureBox()
        Me.weddingPictureBox = New System.Windows.Forms.PictureBox()
        Me.weddingButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.bdayButton = New System.Windows.Forms.Button()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weddingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'typeLabel
        '
        Me.typeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.typeLabel.Location = New System.Drawing.Point(172, 20)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(180, 30)
        Me.typeLabel.TabIndex = 0
        Me.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayPictureBox
        '
        Me.displayPictureBox.Location = New System.Drawing.Point(150, 61)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(225, 205)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 1
        Me.displayPictureBox.TabStop = False
        '
        'bdayPictureBox
        '
        Me.bdayPictureBox.Image = CType(resources.GetObject("bdayPictureBox.Image"), System.Drawing.Image)
        Me.bdayPictureBox.Location = New System.Drawing.Point(29, 320)
        Me.bdayPictureBox.Name = "bdayPictureBox"
        Me.bdayPictureBox.Size = New System.Drawing.Size(165, 125)
        Me.bdayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bdayPictureBox.TabIndex = 2
        Me.bdayPictureBox.TabStop = False
        '
        'weddingPictureBox
        '
        Me.weddingPictureBox.Image = CType(resources.GetObject("weddingPictureBox.Image"), System.Drawing.Image)
        Me.weddingPictureBox.Location = New System.Drawing.Point(221, 320)
        Me.weddingPictureBox.Name = "weddingPictureBox"
        Me.weddingPictureBox.Size = New System.Drawing.Size(165, 125)
        Me.weddingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.weddingPictureBox.TabIndex = 3
        Me.weddingPictureBox.TabStop = False
        '
        'weddingButton
        '
        Me.weddingButton.Location = New System.Drawing.Point(225, 282)
        Me.weddingButton.Name = "weddingButton"
        Me.weddingButton.Size = New System.Drawing.Size(75, 23)
        Me.weddingButton.TabIndex = 5
        Me.weddingButton.Text = "Wedding"
        Me.weddingButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(300, 282)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'bdayButton
        '
        Me.bdayButton.Location = New System.Drawing.Point(150, 282)
        Me.bdayButton.Name = "bdayButton"
        Me.bdayButton.Size = New System.Drawing.Size(75, 23)
        Me.bdayButton.TabIndex = 4
        Me.bdayButton.Text = "Birrthday"
        Me.bdayButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bdayButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 314)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.weddingButton)
        Me.Controls.Add(Me.bdayButton)
        Me.Controls.Add(Me.weddingPictureBox)
        Me.Controls.Add(Me.bdayPictureBox)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.typeLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cake Shoppe"
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weddingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents typeLabel As Label
    Friend WithEvents displayPictureBox As PictureBox
    Friend WithEvents bdayPictureBox As PictureBox
    Friend WithEvents weddingPictureBox As PictureBox
    Friend WithEvents weddingButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents bdayButton As Button
End Class
