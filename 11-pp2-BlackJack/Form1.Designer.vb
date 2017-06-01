<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlackJack
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlackJack))
        Me.lstPlayerHand = New System.Windows.Forms.ListBox()
        Me.lstDealerHand = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnNewHand = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.txtDealerTotal = New System.Windows.Forms.Label()
        Me.txtPlayerTotal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstPlayerHand
        '
        Me.lstPlayerHand.FormattingEnabled = True
        Me.lstPlayerHand.Location = New System.Drawing.Point(12, 35)
        Me.lstPlayerHand.Name = "lstPlayerHand"
        Me.lstPlayerHand.Size = New System.Drawing.Size(158, 95)
        Me.lstPlayerHand.TabIndex = 0
        '
        'lstDealerHand
        '
        Me.lstDealerHand.FormattingEnabled = True
        Me.lstDealerHand.Location = New System.Drawing.Point(201, 36)
        Me.lstDealerHand.Name = "lstDealerHand"
        Me.lstDealerHand.Size = New System.Drawing.Size(173, 95)
        Me.lstDealerHand.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Player's Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(197, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dealer's Total:"
        '
        'btnHit
        '
        Me.btnHit.Enabled = False
        Me.btnHit.Location = New System.Drawing.Point(12, 197)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(75, 23)
        Me.btnHit.TabIndex = 6
        Me.btnHit.Text = "Hit Me"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnNewHand
        '
        Me.btnNewHand.Location = New System.Drawing.Point(135, 197)
        Me.btnNewHand.Name = "btnNewHand"
        Me.btnNewHand.Size = New System.Drawing.Size(116, 23)
        Me.btnNewHand.TabIndex = 7
        Me.btnNewHand.Text = "New Hand"
        Me.btnNewHand.UseVisualStyleBackColor = True
        '
        'btnHold
        '
        Me.btnHold.Enabled = False
        Me.btnHold.Location = New System.Drawing.Point(299, 197)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(75, 23)
        Me.btnHold.TabIndex = 8
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseVisualStyleBackColor = True
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(12, 226)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ReadOnly = True
        Me.txtMsg.Size = New System.Drawing.Size(362, 20)
        Me.txtMsg.TabIndex = 9
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'txtDealerTotal
        '
        Me.txtDealerTotal.AutoSize = True
        Me.txtDealerTotal.Font = New System.Drawing.Font("Modern No. 20", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerTotal.ForeColor = System.Drawing.Color.White
        Me.txtDealerTotal.Location = New System.Drawing.Point(337, 9)
        Me.txtDealerTotal.Name = "txtDealerTotal"
        Me.txtDealerTotal.Size = New System.Drawing.Size(0, 25)
        Me.txtDealerTotal.TabIndex = 10
        '
        'txtPlayerTotal
        '
        Me.txtPlayerTotal.AutoSize = True
        Me.txtPlayerTotal.Font = New System.Drawing.Font("Modern No. 20", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerTotal.ForeColor = System.Drawing.Color.White
        Me.txtPlayerTotal.Location = New System.Drawing.Point(142, 10)
        Me.txtPlayerTotal.Name = "txtPlayerTotal"
        Me.txtPlayerTotal.Size = New System.Drawing.Size(0, 25)
        Me.txtPlayerTotal.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(45, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 54)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmBlackJack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(392, 258)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPlayerTotal)
        Me.Controls.Add(Me.txtDealerTotal)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.btnNewHand)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstDealerHand)
        Me.Controls.Add(Me.lstPlayerHand)
        Me.Name = "frmBlackJack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Black Jack"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPlayerHand As System.Windows.Forms.ListBox
    Friend WithEvents lstDealerHand As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHit As System.Windows.Forms.Button
    Friend WithEvents btnNewHand As System.Windows.Forms.Button
    Friend WithEvents btnHold As System.Windows.Forms.Button
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents txtDealerTotal As System.Windows.Forms.Label
    Friend WithEvents txtPlayerTotal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
